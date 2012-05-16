﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication_ChekSession
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sessions")]
	public partial class SessionsDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActiveSession(ActiveSession instance);
    partial void UpdateActiveSession(ActiveSession instance);
    partial void DeleteActiveSession(ActiveSession instance);
    partial void InsertSessionHistory(SessionHistory instance);
    partial void UpdateSessionHistory(SessionHistory instance);
    partial void DeleteSessionHistory(SessionHistory instance);
    #endregion
		
		public SessionsDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SessionsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SessionsDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SessionsDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SessionsDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SessionsDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ActiveSession> ActiveSessions
		{
			get
			{
				return this.GetTable<ActiveSession>();
			}
		}
		
		public System.Data.Linq.Table<SessionHistory> SessionHistories
		{
			get
			{
				return this.GetTable<SessionHistory>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ActiveSessions")]
	public partial class ActiveSession : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SessionID;
		
		private string _UserName;
		
		private System.DateTime _LoggedInDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSessionIDChanging(string value);
    partial void OnSessionIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnLoggedInDateChanging(System.DateTime value);
    partial void OnLoggedInDateChanged();
    #endregion
		
		public ActiveSession()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionID", DbType="NVarChar(80) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SessionID
		{
			get
			{
				return this._SessionID;
			}
			set
			{
				if ((this._SessionID != value))
				{
					this.OnSessionIDChanging(value);
					this.SendPropertyChanging();
					this._SessionID = value;
					this.SendPropertyChanged("SessionID");
					this.OnSessionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoggedInDate", DbType="DateTime NOT NULL")]
		public System.DateTime LoggedInDate
		{
			get
			{
				return this._LoggedInDate;
			}
			set
			{
				if ((this._LoggedInDate != value))
				{
					this.OnLoggedInDateChanging(value);
					this.SendPropertyChanging();
					this._LoggedInDate = value;
					this.SendPropertyChanged("LoggedInDate");
					this.OnLoggedInDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SessionHistory")]
	public partial class SessionHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SessionID;
		
		private string _UserName;
		
		private System.DateTime _StatusDate;
		
		private string _Status;
		
		private int _HistoryId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSessionIDChanging(string value);
    partial void OnSessionIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnStatusDateChanging(System.DateTime value);
    partial void OnStatusDateChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnHistoryIdChanging(int value);
    partial void OnHistoryIdChanged();
    #endregion
		
		public SessionHistory()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionID", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
		public string SessionID
		{
			get
			{
				return this._SessionID;
			}
			set
			{
				if ((this._SessionID != value))
				{
					this.OnSessionIDChanging(value);
					this.SendPropertyChanging();
					this._SessionID = value;
					this.SendPropertyChanged("SessionID");
					this.OnSessionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusDate", DbType="DateTime NOT NULL")]
		public System.DateTime StatusDate
		{
			get
			{
				return this._StatusDate;
			}
			set
			{
				if ((this._StatusDate != value))
				{
					this.OnStatusDateChanging(value);
					this.SendPropertyChanging();
					this._StatusDate = value;
					this.SendPropertyChanged("StatusDate");
					this.OnStatusDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Char(7) NOT NULL", CanBeNull=false)]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HistoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int HistoryId
		{
			get
			{
				return this._HistoryId;
			}
			set
			{
				if ((this._HistoryId != value))
				{
					this.OnHistoryIdChanging(value);
					this.SendPropertyChanging();
					this._HistoryId = value;
					this.SendPropertyChanged("HistoryId");
					this.OnHistoryIdChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
