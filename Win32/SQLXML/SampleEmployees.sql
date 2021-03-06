IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'SampleEmployees')
	DROP DATABASE [SampleEmployees]
GO

CREATE DATABASE [SampleEmployees]  ON (NAME = N'SampleEmployees_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\data\SampleEmployees_Data.MDF' , SIZE = 1, FILEGROWTH = 10%) LOG ON (NAME = N'SampleEmployees_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL\data\SampleEmployees_Log.LDF' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO


use [SampleEmployees]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Address_Employee]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Address] DROP CONSTRAINT FK_Address_Employee
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FetchEmployee]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[FetchEmployee]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PersistEmployees]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[PersistEmployees]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Address]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Address]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Employee]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Employee]
GO

if not exists (select * from master.dbo.syslogins where loginname = N'test')
BEGIN
	declare @logindb nvarchar(132), @loginlang nvarchar(132) select @logindb = N'SampleEmployees', @loginlang = N'us_english'
	if @logindb is null or not exists (select * from master.dbo.sysdatabases where name = @logindb)
		select @logindb = N'master'
	if @loginlang is null or (not exists (select * from master.dbo.syslanguages where name = @loginlang) and @loginlang <> N'us_english')
		select @loginlang = @@language
	exec sp_addlogin N'test', null, @logindb, @loginlang
END
GO

if not exists (select * from dbo.sysusers where name = N'test' and uid < 16382)
	EXEC sp_grantdbaccess N'test', N'test'
GO

CREATE TABLE [dbo].[Address] (
	[EmployeeID] [int] NOT NULL ,
	[AddressType] [nvarchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Street] [nvarchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[City] [nvarchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[State] [nvarchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Zip] [nvarchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Employee] (
	[EmployeeID] [int] NOT NULL ,
	[LastName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FirstName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Title] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Overflow] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Address] ADD 
	CONSTRAINT [PK_Address] PRIMARY KEY  CLUSTERED 
	(
		[EmployeeID],
		[AddressType]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Employee] ADD 
	CONSTRAINT [PK_Employee] PRIMARY KEY  CLUSTERED 
	(
		[EmployeeID]
	)  ON [PRIMARY] 
GO

GRANT  SELECT ,  UPDATE ,  INSERT ,  DELETE  ON [dbo].[Address]  TO [public]
GO

GRANT  SELECT ,  UPDATE ,  INSERT ,  DELETE  ON [dbo].[Employee]  TO [public]
GO

ALTER TABLE [dbo].[Address] ADD 
	CONSTRAINT [FK_Address_Employee] FOREIGN KEY 
	(
		[EmployeeID]
	) REFERENCES [dbo].[Employee] (
		[EmployeeID]
	)
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE FetchEmployee
	@LastName nvarchar(100)
AS

SELECT 1          as Tag, 
       null       as Parent,
       null       as [EmployeeList!1!],
       null       as [Employee!2!EmployeeID!element],
       null       as [Employee!2!LastName!element],
       null       as [Employee!2!FirstName!element],
       null       as [Employee!2!Title!element],
       null   	  as [Employee!2!!xmltext],
       null       as [AddressList!3!],
       null       as [Address!4!Street!element],
       null       as [Address!4!City!element],
       null       as [Address!4!State!element],
       null       as [Address!4!Zip!element],
       null       as [Address!4!Type!element]
UNION ALL
SELECT 2, 1, null, EmployeeID, LastName, FirstName, Title, Overflow ,null, null, null, null, null, null           
FROM Employee
where LastName = @LastName
UNION ALL
SELECT 3, 2, null, EmployeeID, null, null, null, null, null, null, null, null, null, null                
FROM Employee
where LastName = @LastName
UNION ALL
SELECT 4, 3, null, Address.EmployeeID, null, null, null, null, null, Street, City, State, Zip, AddressType        
FROM Address, Employee
where Address.EmployeeID = Employee.EmployeeID and Employee.LastName = @LastName
order by [Employee!2!EmployeeId!element], Tag, Parent
FOR XML EXPLICIT


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[FetchEmployee]  TO [public]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE PersistEmployees 
	@employeeXML nvarchar(4000),
	@remove bit = 0 
AS

DECLARE @hdoc int

exec sp_xml_preparedocument @hdoc OUTPUT, @employeeXML

DELETE Address where EmployeeID in
(SELECT EmployeeID
FROM OpenXML(@hdoc,'/EmployeeList/Employee')
     WITH (EmployeeID  	int 'EmployeeID'))

DELETE Employee where EmployeeID in
(SELECT EmployeeID
FROM OpenXML(@hdoc,'/EmployeeList/Employee')
     WITH (EmployeeID  	int 'EmployeeID'))

if (@remove = 0)
BEGIN
    INSERT INTO Employee(EmployeeID, LastName, FirstName, Title, Overflow)
    SELECT EmployeeID, LastName, FirstName, Title, Overflow 
    FROM OpenXML(@hdoc,'/EmployeeList/Employee', 8)
    WITH (EmployeeID   int 		'EmployeeID',
          LastName     nvarchar(100)	'LastName',
	  FirstName    nvarchar(100)	'FirstName',
	  Title        nvarchar(100)	'Title',
	  Address      nvarchar(1)      'AddressList',
          Overflow     ntext         	'@mp:xmltext')

    INSERT INTO Address(EmployeeID, AddressType, Street, City, State, Zip)
    SELECT EmployeeID, AddressType, Street, City, State, Zip
    FROM OpenXML(@hdoc, '/EmployeeList/Employee/AddressList/Address', 8)
    WITH (EmployeeID   int 		'../../EmployeeID',
	  AddressType  nvarchar(10)	'Type',
	  Street       nvarchar(200)	'Street',
	  City         nvarchar(100)	'City',
	  State        nvarchar(4)	'State', 
	  Zip          nvarchar(20)	'Zip')
END


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

GRANT  EXECUTE  ON [dbo].[PersistEmployees]  TO [public]
GO

