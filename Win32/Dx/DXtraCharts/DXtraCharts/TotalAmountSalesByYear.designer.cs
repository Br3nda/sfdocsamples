﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXtraCharts
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="AdventureWorks")]
	public partial class TotalAmountSalesByYearDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public TotalAmountSalesByYearDataContext() : 
				base(global::DXtraCharts.Properties.Settings.Default.AdventureWorksConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TotalAmountSalesByYearDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TotalAmountSalesByYearDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TotalAmountSalesByYearDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TotalAmountSalesByYearDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TotalAmountSalesByYear> TotalAmountSalesByYears
		{
			get
			{
				return this.GetTable<TotalAmountSalesByYear>();
			}
		}
	}
	
	[Table(Name="dbo.TotalAmountSalesByYear")]
	public partial class TotalAmountSalesByYear
	{
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<decimal> _TotalAmount;
		
		public TotalAmountSalesByYear()
		{
		}
		
		[Column(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this._Year = value;
				}
			}
		}
		
		[Column(Storage="_TotalAmount", DbType="Money")]
		public System.Nullable<decimal> TotalAmount
		{
			get
			{
				return this._TotalAmount;
			}
			set
			{
				if ((this._TotalAmount != value))
				{
					this._TotalAmount = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
