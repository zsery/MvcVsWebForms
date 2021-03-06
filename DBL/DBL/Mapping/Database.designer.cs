﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBL.Mapping
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DatabaseBL")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEVENT(EVENT instance);
    partial void UpdateEVENT(EVENT instance);
    partial void DeleteEVENT(EVENT instance);
    partial void InsertSTAVPRIPADU(STAVPRIPADU instance);
    partial void UpdateSTAVPRIPADU(STAVPRIPADU instance);
    partial void DeleteSTAVPRIPADU(STAVPRIPADU instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DBL.Properties.Settings.Default.DatabaseBLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<C_EVENT_STATE> C_EVENT_STATEs
		{
			get
			{
				return this.GetTable<C_EVENT_STATE>();
			}
		}
		
		public System.Data.Linq.Table<EVENT> EVENTs
		{
			get
			{
				return this.GetTable<EVENT>();
			}
		}
		
		public System.Data.Linq.Table<PRIPAD> PRIPADs
		{
			get
			{
				return this.GetTable<PRIPAD>();
			}
		}
		
		public System.Data.Linq.Table<STAVPRIPADU> STAVPRIPADUs
		{
			get
			{
				return this.GetTable<STAVPRIPADU>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.C_EVENT_STATE")]
	public partial class C_EVENT_STATE
	{
		
		private int _event_state_id;
		
		private string _name;
		
		private string _code_token;
		
		public C_EVENT_STATE()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_event_state_id", DbType="Int NOT NULL")]
		public int event_state_id
		{
			get
			{
				return this._event_state_id;
			}
			set
			{
				if ((this._event_state_id != value))
				{
					this._event_state_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code_token", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string code_token
		{
			get
			{
				return this._code_token;
			}
			set
			{
				if ((this._code_token != value))
				{
					this._code_token = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EVENT")]
	public partial class EVENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EventId;
		
		private int _IsirId;
		
		private System.Nullable<int> _CaseId;
		
		private string _CaseSign;
		
		private System.DateTime _PublishedAt;
		
		private System.DateTime _LoadedAt;
		
		private System.Nullable<System.DateTime> _SavedAt;
		
		private System.Nullable<System.DateTime> _LegalCaseIniatedAt;
		
		private System.Nullable<System.DateTime> _ResolvedAt;
		
		private string _Resolver;
		
		private int _EventTypeId;
		
		private string _EventTypDescription;
		
		private string _Section;
		
		private System.Nullable<int> _OrderOfSection;
		
		private string _IDUser;
		
		private System.Nullable<System.DateTime> _CanceledAt;
		
		private System.Nullable<int> _RiskCode;
		
		private System.Nullable<int> _EventStateId;
		
		private string _VerifiedBy;
		
		private System.Nullable<System.DateTime> _VerifiedAt;
		
		private System.DateTime _ModifiedAt;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEventIdChanging(int value);
    partial void OnEventIdChanged();
    partial void OnIsirIdChanging(int value);
    partial void OnIsirIdChanged();
    partial void OnCaseIdChanging(System.Nullable<int> value);
    partial void OnCaseIdChanged();
    partial void OnCaseSignChanging(string value);
    partial void OnCaseSignChanged();
    partial void OnPublishedAtChanging(System.DateTime value);
    partial void OnPublishedAtChanged();
    partial void OnLoadedAtChanging(System.DateTime value);
    partial void OnLoadedAtChanged();
    partial void OnSavedAtChanging(System.Nullable<System.DateTime> value);
    partial void OnSavedAtChanged();
    partial void OnLegalCaseIniatedAtChanging(System.Nullable<System.DateTime> value);
    partial void OnLegalCaseIniatedAtChanged();
    partial void OnResolvedAtChanging(System.Nullable<System.DateTime> value);
    partial void OnResolvedAtChanged();
    partial void OnResolverChanging(string value);
    partial void OnResolverChanged();
    partial void OnEventTypeIdChanging(int value);
    partial void OnEventTypeIdChanged();
    partial void OnEventTypDescriptionChanging(string value);
    partial void OnEventTypDescriptionChanged();
    partial void OnSectionChanging(string value);
    partial void OnSectionChanged();
    partial void OnOrderOfSectionChanging(System.Nullable<int> value);
    partial void OnOrderOfSectionChanged();
    partial void OnIDUserChanging(string value);
    partial void OnIDUserChanged();
    partial void OnCanceledAtChanging(System.Nullable<System.DateTime> value);
    partial void OnCanceledAtChanged();
    partial void OnRiskCodeChanging(System.Nullable<int> value);
    partial void OnRiskCodeChanged();
    partial void OnEventStateIdChanging(System.Nullable<int> value);
    partial void OnEventStateIdChanged();
    partial void OnVerifiedByChanging(string value);
    partial void OnVerifiedByChanged();
    partial void OnVerifiedAtChanging(System.Nullable<System.DateTime> value);
    partial void OnVerifiedAtChanged();
    partial void OnModifiedAtChanging(System.DateTime value);
    partial void OnModifiedAtChanged();
    #endregion
		
		public EVENT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int EventId
		{
			get
			{
				return this._EventId;
			}
			set
			{
				if ((this._EventId != value))
				{
					this.OnEventIdChanging(value);
					this.SendPropertyChanging();
					this._EventId = value;
					this.SendPropertyChanged("EventId");
					this.OnEventIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsirId", DbType="Int NOT NULL")]
		public int IsirId
		{
			get
			{
				return this._IsirId;
			}
			set
			{
				if ((this._IsirId != value))
				{
					this.OnIsirIdChanging(value);
					this.SendPropertyChanging();
					this._IsirId = value;
					this.SendPropertyChanged("IsirId");
					this.OnIsirIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CaseId", DbType="Int")]
		public System.Nullable<int> CaseId
		{
			get
			{
				return this._CaseId;
			}
			set
			{
				if ((this._CaseId != value))
				{
					this.OnCaseIdChanging(value);
					this.SendPropertyChanging();
					this._CaseId = value;
					this.SendPropertyChanged("CaseId");
					this.OnCaseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CaseSign", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CaseSign
		{
			get
			{
				return this._CaseSign;
			}
			set
			{
				if ((this._CaseSign != value))
				{
					this.OnCaseSignChanging(value);
					this.SendPropertyChanging();
					this._CaseSign = value;
					this.SendPropertyChanged("CaseSign");
					this.OnCaseSignChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PublishedAt", DbType="Date NOT NULL")]
		public System.DateTime PublishedAt
		{
			get
			{
				return this._PublishedAt;
			}
			set
			{
				if ((this._PublishedAt != value))
				{
					this.OnPublishedAtChanging(value);
					this.SendPropertyChanging();
					this._PublishedAt = value;
					this.SendPropertyChanged("PublishedAt");
					this.OnPublishedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoadedAt", DbType="Date NOT NULL")]
		public System.DateTime LoadedAt
		{
			get
			{
				return this._LoadedAt;
			}
			set
			{
				if ((this._LoadedAt != value))
				{
					this.OnLoadedAtChanging(value);
					this.SendPropertyChanging();
					this._LoadedAt = value;
					this.SendPropertyChanged("LoadedAt");
					this.OnLoadedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SavedAt", DbType="Date")]
		public System.Nullable<System.DateTime> SavedAt
		{
			get
			{
				return this._SavedAt;
			}
			set
			{
				if ((this._SavedAt != value))
				{
					this.OnSavedAtChanging(value);
					this.SendPropertyChanging();
					this._SavedAt = value;
					this.SendPropertyChanged("SavedAt");
					this.OnSavedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LegalCaseIniatedAt", DbType="Date")]
		public System.Nullable<System.DateTime> LegalCaseIniatedAt
		{
			get
			{
				return this._LegalCaseIniatedAt;
			}
			set
			{
				if ((this._LegalCaseIniatedAt != value))
				{
					this.OnLegalCaseIniatedAtChanging(value);
					this.SendPropertyChanging();
					this._LegalCaseIniatedAt = value;
					this.SendPropertyChanged("LegalCaseIniatedAt");
					this.OnLegalCaseIniatedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResolvedAt", DbType="Date")]
		public System.Nullable<System.DateTime> ResolvedAt
		{
			get
			{
				return this._ResolvedAt;
			}
			set
			{
				if ((this._ResolvedAt != value))
				{
					this.OnResolvedAtChanging(value);
					this.SendPropertyChanging();
					this._ResolvedAt = value;
					this.SendPropertyChanged("ResolvedAt");
					this.OnResolvedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resolver", DbType="NVarChar(7)")]
		public string Resolver
		{
			get
			{
				return this._Resolver;
			}
			set
			{
				if ((this._Resolver != value))
				{
					this.OnResolverChanging(value);
					this.SendPropertyChanging();
					this._Resolver = value;
					this.SendPropertyChanged("Resolver");
					this.OnResolverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventTypeId", DbType="Int NOT NULL")]
		public int EventTypeId
		{
			get
			{
				return this._EventTypeId;
			}
			set
			{
				if ((this._EventTypeId != value))
				{
					this.OnEventTypeIdChanging(value);
					this.SendPropertyChanging();
					this._EventTypeId = value;
					this.SendPropertyChanged("EventTypeId");
					this.OnEventTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventTypDescription", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string EventTypDescription
		{
			get
			{
				return this._EventTypDescription;
			}
			set
			{
				if ((this._EventTypDescription != value))
				{
					this.OnEventTypDescriptionChanging(value);
					this.SendPropertyChanging();
					this._EventTypDescription = value;
					this.SendPropertyChanged("EventTypDescription");
					this.OnEventTypDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Section", DbType="NVarChar(50)")]
		public string Section
		{
			get
			{
				return this._Section;
			}
			set
			{
				if ((this._Section != value))
				{
					this.OnSectionChanging(value);
					this.SendPropertyChanging();
					this._Section = value;
					this.SendPropertyChanged("Section");
					this.OnSectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderOfSection", DbType="Int")]
		public System.Nullable<int> OrderOfSection
		{
			get
			{
				return this._OrderOfSection;
			}
			set
			{
				if ((this._OrderOfSection != value))
				{
					this.OnOrderOfSectionChanging(value);
					this.SendPropertyChanging();
					this._OrderOfSection = value;
					this.SendPropertyChanged("OrderOfSection");
					this.OnOrderOfSectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDUser", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string IDUser
		{
			get
			{
				return this._IDUser;
			}
			set
			{
				if ((this._IDUser != value))
				{
					this.OnIDUserChanging(value);
					this.SendPropertyChanging();
					this._IDUser = value;
					this.SendPropertyChanged("IDUser");
					this.OnIDUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanceledAt", DbType="Date")]
		public System.Nullable<System.DateTime> CanceledAt
		{
			get
			{
				return this._CanceledAt;
			}
			set
			{
				if ((this._CanceledAt != value))
				{
					this.OnCanceledAtChanging(value);
					this.SendPropertyChanging();
					this._CanceledAt = value;
					this.SendPropertyChanged("CanceledAt");
					this.OnCanceledAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RiskCode", DbType="Int")]
		public System.Nullable<int> RiskCode
		{
			get
			{
				return this._RiskCode;
			}
			set
			{
				if ((this._RiskCode != value))
				{
					this.OnRiskCodeChanging(value);
					this.SendPropertyChanging();
					this._RiskCode = value;
					this.SendPropertyChanged("RiskCode");
					this.OnRiskCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventStateId", DbType="Int")]
		public System.Nullable<int> EventStateId
		{
			get
			{
				return this._EventStateId;
			}
			set
			{
				if ((this._EventStateId != value))
				{
					this.OnEventStateIdChanging(value);
					this.SendPropertyChanging();
					this._EventStateId = value;
					this.SendPropertyChanged("EventStateId");
					this.OnEventStateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerifiedBy", DbType="NVarChar(7)")]
		public string VerifiedBy
		{
			get
			{
				return this._VerifiedBy;
			}
			set
			{
				if ((this._VerifiedBy != value))
				{
					this.OnVerifiedByChanging(value);
					this.SendPropertyChanging();
					this._VerifiedBy = value;
					this.SendPropertyChanged("VerifiedBy");
					this.OnVerifiedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerifiedAt", DbType="Date")]
		public System.Nullable<System.DateTime> VerifiedAt
		{
			get
			{
				return this._VerifiedAt;
			}
			set
			{
				if ((this._VerifiedAt != value))
				{
					this.OnVerifiedAtChanging(value);
					this.SendPropertyChanging();
					this._VerifiedAt = value;
					this.SendPropertyChanged("VerifiedAt");
					this.OnVerifiedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedAt", DbType="Date NOT NULL")]
		public System.DateTime ModifiedAt
		{
			get
			{
				return this._ModifiedAt;
			}
			set
			{
				if ((this._ModifiedAt != value))
				{
					this.OnModifiedAtChanging(value);
					this.SendPropertyChanging();
					this._ModifiedAt = value;
					this.SendPropertyChanged("ModifiedAt");
					this.OnModifiedAtChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PRIPAD")]
	public partial class PRIPAD
	{
		
		private int _pripadid;
		
		private string _spis_znacka;
		
		private System.Nullable<System.DateTime> _pripad_start;
		
		private System.Nullable<System.DateTime> _pripad_konec;
		
		private int _stavid;
		
		private System.Nullable<System.DateTime> _ulozeno;
		
		private System.Nullable<System.DateTime> _zmeneno_isir;
		
		private System.Nullable<System.DateTime> _zruseno;
		
		public PRIPAD()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pripadid", DbType="Int NOT NULL")]
		public int pripadid
		{
			get
			{
				return this._pripadid;
			}
			set
			{
				if ((this._pripadid != value))
				{
					this._pripadid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_spis_znacka", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string spis_znacka
		{
			get
			{
				return this._spis_znacka;
			}
			set
			{
				if ((this._spis_znacka != value))
				{
					this._spis_znacka = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pripad_start", DbType="Date")]
		public System.Nullable<System.DateTime> pripad_start
		{
			get
			{
				return this._pripad_start;
			}
			set
			{
				if ((this._pripad_start != value))
				{
					this._pripad_start = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pripad_konec", DbType="Date")]
		public System.Nullable<System.DateTime> pripad_konec
		{
			get
			{
				return this._pripad_konec;
			}
			set
			{
				if ((this._pripad_konec != value))
				{
					this._pripad_konec = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stavid", DbType="Int NOT NULL")]
		public int stavid
		{
			get
			{
				return this._stavid;
			}
			set
			{
				if ((this._stavid != value))
				{
					this._stavid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ulozeno", DbType="Date")]
		public System.Nullable<System.DateTime> ulozeno
		{
			get
			{
				return this._ulozeno;
			}
			set
			{
				if ((this._ulozeno != value))
				{
					this._ulozeno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zmeneno_isir", DbType="Date")]
		public System.Nullable<System.DateTime> zmeneno_isir
		{
			get
			{
				return this._zmeneno_isir;
			}
			set
			{
				if ((this._zmeneno_isir != value))
				{
					this._zmeneno_isir = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_zruseno", DbType="Date")]
		public System.Nullable<System.DateTime> zruseno
		{
			get
			{
				return this._zruseno;
			}
			set
			{
				if ((this._zruseno != value))
				{
					this._zruseno = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.STAVPRIPADU")]
	public partial class STAVPRIPADU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _stavid;
		
		private string _stav_nazev;
		
		private string _stav_popis;
		
		private string _popisnawebu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstavidChanging(int value);
    partial void OnstavidChanged();
    partial void Onstav_nazevChanging(string value);
    partial void Onstav_nazevChanged();
    partial void Onstav_popisChanging(string value);
    partial void Onstav_popisChanged();
    partial void OnpopisnawebuChanging(string value);
    partial void OnpopisnawebuChanged();
    #endregion
		
		public STAVPRIPADU()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stavid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int stavid
		{
			get
			{
				return this._stavid;
			}
			set
			{
				if ((this._stavid != value))
				{
					this.OnstavidChanging(value);
					this.SendPropertyChanging();
					this._stavid = value;
					this.SendPropertyChanged("stavid");
					this.OnstavidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stav_nazev", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string stav_nazev
		{
			get
			{
				return this._stav_nazev;
			}
			set
			{
				if ((this._stav_nazev != value))
				{
					this.Onstav_nazevChanging(value);
					this.SendPropertyChanging();
					this._stav_nazev = value;
					this.SendPropertyChanged("stav_nazev");
					this.Onstav_nazevChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stav_popis", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string stav_popis
		{
			get
			{
				return this._stav_popis;
			}
			set
			{
				if ((this._stav_popis != value))
				{
					this.Onstav_popisChanging(value);
					this.SendPropertyChanging();
					this._stav_popis = value;
					this.SendPropertyChanged("stav_popis");
					this.Onstav_popisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_popisnawebu", DbType="NVarChar(100)")]
		public string popisnawebu
		{
			get
			{
				return this._popisnawebu;
			}
			set
			{
				if ((this._popisnawebu != value))
				{
					this.OnpopisnawebuChanging(value);
					this.SendPropertyChanging();
					this._popisnawebu = value;
					this.SendPropertyChanged("popisnawebu");
					this.OnpopisnawebuChanged();
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
