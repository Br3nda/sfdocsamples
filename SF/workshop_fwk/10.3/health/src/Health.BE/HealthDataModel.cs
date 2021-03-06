﻿//TextTemplatingFileGenerator
//Use TextTemplatingFileGenerator on Custom tool tt file propertie

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Fwk 10.0 Code Generator.
//     Runtime Version: 1.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// Author: moviedo 
// Date:   miércoles, 13 de marzo de 2013
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Health.Back.BE;

namespace Health.BE
{
    #region Entities
    
    
    
    
    
    [XmlRoot("CEI10_TempList"), SerializableAttribute]
    public partial class CEI10_TempList : Fwk.Bases.Entities< CEI10_TempBE >{
    
       
    
    }
    
       [XmlInclude(typeof(CEI10_TempBE)), Serializable]
    public partial class CEI10_TempBE : Fwk.Bases.Entity
    {
        #region Primitive Properties
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            { _Id = value;
    		}
    	}
    	
    	    private global::System.Int32 _Id;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Code
        {
            get
            {
                return _Code;
            }
            set
            { _Code = value;
    		}
    	}
    	
    	    private global::System.String _Code;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            { _Description = value;
    		}
    	}
    	
    	    private global::System.String _Description;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String ParentCode
        {
            get
            {
                return _ParentCode;
            }
            set
            { _ParentCode = value;
    		}
    	}
    	
    	    private global::System.String _ParentCode;
       
       

        #endregion
            
            
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public CEI10_TempBE(){}
            
            /// <summary>
            /// Constructor from Model Entity
            /// Framework BE --> Edm Entity Model 
            /// </summary>
            /// <param name="pCEI10_Temp">Edm Model BE</param>
            public CEI10_TempBE(CEI10_Temp pCEI10_Temp)
            {
            	_Id =	pCEI10_Temp.Id ;
            		_Code =	pCEI10_Temp.Code ;
            		_Description =	pCEI10_Temp.Description ;
            		_ParentCode =	pCEI10_Temp.ParentCode ;
            	}
            
            
            /// <summary>
            /// Overload equal operator
            /// Framework BE = Edm Entity Model 
            /// </summary>
            /// <param name="pCEI10_Temp">Edm Model BE</param>
            public static explicit operator CEI10_TempBE(CEI10_Temp pCEI10_Temp)
             {
              return  new  CEI10_TempBE(pCEI10_Temp);
            }
            }
    
    
    
    
    
    [XmlRoot("ConsultaList"), SerializableAttribute]
    public partial class ConsultaList : Fwk.Bases.Entities< ConsultaBE >{}
    
       [XmlInclude(typeof(ConsultaBE)), Serializable]
    public partial class ConsultaBE : Fwk.Bases.Entity
    {
        #region Primitive Properties
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 IdConsulta
        {
            get
            {
                return _IdConsulta;
            }
            set
            { _IdConsulta = value;
    		}
    	}
    	
    	    private global::System.Int32 _IdConsulta;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdTipoConsulta
        {
            get
            {
                return _IdTipoConsulta;
            }
            set
            { _IdTipoConsulta = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdTipoConsulta;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdProfecional
        {
            get
            {
                return _IdProfecional;
            }
            set
            { _IdProfecional = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdProfecional;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdMutual
        {
            get
            {
                return _IdMutual;
            }
            set
            { _IdMutual = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdMutual;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String NroAfiliadoMutual
        {
            get
            {
                return _NroAfiliadoMutual;
            }
            set
            { _NroAfiliadoMutual = value;
    		}
    	}
    	
    	    private global::System.String _NroAfiliadoMutual;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            { _Fecha = value;
    		}
    	}
    	
    	    private global::System.DateTime _Fecha;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            { _Descripcion = value;
    		}
    	}
    	
    	    private global::System.String _Descripcion;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String NombreCliente
        {
            get
            {
                return _NombreCliente;
            }
            set
            { _NombreCliente = value;
    		}
    	}
    	
    	    private global::System.String _NombreCliente;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Boolean> PresentaOrden
        {
            get
            {
                return _PresentaOrden;
            }
            set
            { _PresentaOrden = value;
    		}
    	}
    	
    	    private Nullable<global::System.Boolean> _PresentaOrden;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String TelefonoCliente
        {
            get
            {
                return _TelefonoCliente;
            }
            set
            { _TelefonoCliente = value;
    		}
    	}
    	
    	    private global::System.String _TelefonoCliente;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Decimal> Coseguro
        {
            get
            {
                return _Coseguro;
            }
            set
            { _Coseguro = value;
    		}
    	}
    	
    	    private Nullable<global::System.Decimal> _Coseguro;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Boolean> ExigeCoseguro
        {
            get
            {
                return _ExigeCoseguro;
            }
            set
            { _ExigeCoseguro = value;
    		}
    	}
    	
    	    private Nullable<global::System.Boolean> _ExigeCoseguro;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Decimal> ArancelMutual
        {
            get
            {
                return _ArancelMutual;
            }
            set
            { _ArancelMutual = value;
    		}
    	}
    	
    	    private Nullable<global::System.Decimal> _ArancelMutual;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            { _UserName = value;
    		}
    	}
    	
    	    private global::System.String _UserName;
       
       

        #endregion
            
            
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public ConsultaBE(){}
            
            /// <summary>
            /// Constructor from Model Entity
            /// Framework BE --> Edm Entity Model 
            /// </summary>
            /// <param name="pConsulta">Edm Model BE</param>
            public ConsultaBE(Consulta pConsulta)
            {
            	_IdConsulta =	pConsulta.IdConsulta ;
            		_IdTipoConsulta =	pConsulta.IdTipoConsulta ;
            		_IdProfecional =	pConsulta.IdProfecional ;
            		_IdMutual =	pConsulta.IdMutual ;
            		_NroAfiliadoMutual =	pConsulta.NroAfiliadoMutual ;
            		_Fecha =	pConsulta.Fecha ;
            		_Descripcion =	pConsulta.Descripcion ;
            		_NombreCliente =	pConsulta.NombreCliente ;
            		_PresentaOrden =	pConsulta.PresentaOrden ;
            		_TelefonoCliente =	pConsulta.TelefonoCliente ;
            		_Coseguro =	pConsulta.Coseguro ;
            		_ExigeCoseguro =	pConsulta.ExigeCoseguro ;
            		_ArancelMutual =	pConsulta.ArancelMutual ;
            		_UserName =	pConsulta.UserName ;
            	}
            
            
            /// <summary>
            /// Overload equal operator
            /// Framework BE = Edm Entity Model 
            /// </summary>
            /// <param name="pConsulta">Edm Model BE</param>
            public static explicit operator ConsultaBE(Consulta pConsulta)
             {
              return  new  ConsultaBE(pConsulta);
            }
            }
    
    
    
    
    
    [XmlRoot("ParametroList"), SerializableAttribute]
    public partial class ParametroList : Fwk.Bases.Entities< ParametroBE >{}
    
       [XmlInclude(typeof(ParametroBE)), Serializable]
    public partial class ParametroBE : Fwk.Bases.Entity
    {
        #region Primitive Properties
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 IdParametro
        {
            get
            {
                return _IdParametro;
            }
            set
            { _IdParametro = value;
    		}
    	}
    	
    	    private global::System.Int32 _IdParametro;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            { _Nombre = value;
    		}
    	}
    	
    	    private global::System.String _Nombre;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdTipoParametro
        {
            get
            {
                return _IdTipoParametro;
            }
            set
            { _IdTipoParametro = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdTipoParametro;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdParametroRef
        {
            get
            {
                return _IdParametroRef;
            }
            set
            { _IdParametroRef = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdParametroRef;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            { _Descripcion = value;
    		}
    	}
    	
    	    private global::System.String _Descripcion;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Boolean Vigente
        {
            get
            {
                return _Vigente;
            }
            set
            { _Vigente = value;
    		}
    	}
    	
    	    private global::System.Boolean _Vigente;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Guid> UserId
        {
            get
            {
                return _UserId;
            }
            set
            { _UserId = value;
    		}
    	}
    	
    	    private Nullable<global::System.Guid> _UserId;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            { _CompanyId = value;
    		}
    	}
    	
    	    private global::System.String _CompanyId;
       
       

        #endregion
            
            
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public ParametroBE(){}
            
            /// <summary>
            /// Constructor from Model Entity
            /// Framework BE --> Edm Entity Model 
            /// </summary>
            /// <param name="pParametro">Edm Model BE</param>
            public ParametroBE(Parametro pParametro)
            {
            	_IdParametro =	pParametro.IdParametro ;
            		_Nombre =	pParametro.Nombre ;
            		_IdTipoParametro =	pParametro.IdTipoParametro ;
            		_IdParametroRef =	pParametro.IdParametroRef ;
            		_Descripcion =	pParametro.Descripcion ;
            		_Vigente =	pParametro.Vigente ;
            		_UserId =	pParametro.UserId ;
            		_CompanyId =	pParametro.CompanyId ;
            	}
            
            
            /// <summary>
            /// Overload equal operator
            /// Framework BE = Edm Entity Model 
            /// </summary>
            /// <param name="pParametro">Edm Model BE</param>
            public static explicit operator ParametroBE(Parametro pParametro)
             {
              return  new  ParametroBE(pParametro);
            }
            }
    
    
    
    
    
    [XmlRoot("PatientList"), SerializableAttribute]
    public partial class PatientList : Fwk.Bases.Entities< PatientBE >{}
    
       [XmlInclude(typeof(PatientBE)), Serializable]
    public partial class PatientBE : Fwk.Bases.Entity
    {
        #region Primitive Properties
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 PatientId
        {
            get
            {
                return _PatientId;
            }
            set
            { _PatientId = value;
    		}
    	}
    	
    	    private global::System.Int32 _PatientId;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 IdPersona
        {
            get
            {
                return _IdPersona;
            }
            set
            { _IdPersona = value;
    		}
    	}
    	
    	    private global::System.Int32 _IdPersona;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime FechaAlta
        {
            get
            {
                return _FechaAlta;
            }
            set
            { _FechaAlta = value;
    		}
    	}
    	
    	    private global::System.DateTime _FechaAlta;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.DateTime> LastAccessTime
        {
            get
            {
                return _LastAccessTime;
            }
            set
            { _LastAccessTime = value;
    		}
    	}
    	
    	    private Nullable<global::System.DateTime> _LastAccessTime;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Guid> LastAccessUserId
        {
            get
            {
                return _LastAccessUserId;
            }
            set
            { _LastAccessUserId = value;
    		}
    	}
    	
    	    private Nullable<global::System.Guid> _LastAccessUserId;
       
       

        #endregion
            
            
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public PatientBE(){}
            
            /// <summary>
            /// Constructor from Model Entity
            /// Framework BE --> Edm Entity Model 
            /// </summary>
            /// <param name="pPatient">Edm Model BE</param>
            public PatientBE(Patient pPatient)
            {
            	_PatientId =	pPatient.PatientId ;
            		_IdPersona =	pPatient.IdPersona ;
            		_FechaAlta =	pPatient.FechaAlta ;
            		_LastAccessTime =	pPatient.LastAccessTime ;
            		_LastAccessUserId =	pPatient.LastAccessUserId ;
            	}
            
            
            /// <summary>
            /// Overload equal operator
            /// Framework BE = Edm Entity Model 
            /// </summary>
            /// <param name="pPatient">Edm Model BE</param>
            public static explicit operator PatientBE(Patient pPatient)
             {
              return  new  PatientBE(pPatient);
            }
            }
    
    
    
    
    
    [XmlRoot("PersonaList"), SerializableAttribute]
    public partial class PersonaList : Fwk.Bases.Entities< PersonaBE >{}
    
       [XmlInclude(typeof(PersonaBE)), Serializable]
    public partial class PersonaBE : Fwk.Bases.Entity
    {
        #region Primitive Properties
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 IdPersona
        {
            get
            {
                return _IdPersona;
            }
            set
            { _IdPersona = value;
    		}
    	}
    	
    	    private global::System.Int32 _IdPersona;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Guid> UserId
        {
            get
            {
                return _UserId;
            }
            set
            { _UserId = value;
    		}
    	}
    	
    	    private Nullable<global::System.Guid> _UserId;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String TipoDocumento
        {
            get
            {
                return _TipoDocumento;
            }
            set
            { _TipoDocumento = value;
    		}
    	}
    	
    	    private global::System.String _TipoDocumento;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String NroDocumento
        {
            get
            {
                return _NroDocumento;
            }
            set
            { _NroDocumento = value;
    		}
    	}
    	
    	    private global::System.String _NroDocumento;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Apellido
        {
            get
            {
                return _Apellido;
            }
            set
            { _Apellido = value;
    		}
    	}
    	
    	    private global::System.String _Apellido;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            { _Nombre = value;
    		}
    	}
    	
    	    private global::System.String _Nombre;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int16 Sexo
        {
            get
            {
                return _Sexo;
            }
            set
            { _Sexo = value;
    		}
    	}
    	
    	    private global::System.Int16 _Sexo;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdEstadocivil
        {
            get
            {
                return _IdEstadocivil;
            }
            set
            { _IdEstadocivil = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdEstadocivil;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime FechaNacimiento
        {
            get
            {
                return _FechaNacimiento;
            }
            set
            { _FechaNacimiento = value;
    		}
    	}
    	
    	    private global::System.DateTime _FechaNacimiento;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime LastAccessTime
        {
            get
            {
                return _LastAccessTime;
            }
            set
            { _LastAccessTime = value;
    		}
    	}
    	
    	    private global::System.DateTime _LastAccessTime;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid LastAccessUserId
        {
            get
            {
                return _LastAccessUserId;
            }
            set
            { _LastAccessUserId = value;
    		}
    	}
    	
    	    private global::System.Guid _LastAccessUserId;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime FechaAlta
        {
            get
            {
                return _FechaAlta;
            }
            set
            { _FechaAlta = value;
    		}
    	}
    	
    	    private global::System.DateTime _FechaAlta;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Calle
        {
            get
            {
                return _Calle;
            }
            set
            { _Calle = value;
    		}
    	}
    	
    	    private global::System.String _Calle;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int16> CalleNumero
        {
            get
            {
                return _CalleNumero;
            }
            set
            { _CalleNumero = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int16> _CalleNumero;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Piso
        {
            get
            {
                return _Piso;
            }
            set
            { _Piso = value;
    		}
    	}
    	
    	    private global::System.String _Piso;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdPais
        {
            get
            {
                return _IdPais;
            }
            set
            { _IdPais = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdPais;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdProvincia
        {
            get
            {
                return _IdProvincia;
            }
            set
            { _IdProvincia = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdProvincia;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdLocalidad
        {
            get
            {
                return _IdLocalidad;
            }
            set
            { _IdLocalidad = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdLocalidad;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Barrio
        {
            get
            {
                return _Barrio;
            }
            set
            { _Barrio = value;
    		}
    	}
    	
    	    private global::System.String _Barrio;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String mail
        {
            get
            {
                return _mail;
            }
            set
            { _mail = value;
    		}
    	}
    	
    	    private global::System.String _mail;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Telefono1
        {
            get
            {
                return _Telefono1;
            }
            set
            { _Telefono1 = value;
    		}
    	}
    	
    	    private global::System.String _Telefono1;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Telefono2
        {
            get
            {
                return _Telefono2;
            }
            set
            { _Telefono2 = value;
    		}
    	}
    	
    	    private global::System.String _Telefono2;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Byte[] Foto
        {
            get
            {
                return _Foto;//StructuralObject.GetValidValue(obj_there);
            }
            set
            { _Foto = value;
    		}
    	}
    	
    	    private global::System.Byte[] _Foto;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Boolean> IsNaturalPerson
        {
            get
            {
                return _IsNaturalPerson;
            }
            set
            { _IsNaturalPerson = value;
    		}
    	}
    	
    	    private Nullable<global::System.Boolean> _IsNaturalPerson;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String RazonSocial
        {
            get
            {
                return _RazonSocial;
            }
            set
            { _RazonSocial = value;
    		}
    	}
    	
    	    private global::System.String _RazonSocial;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Boolean IsUserActive
        {
            get
            {
                return _IsUserActive;
            }
            set
            { _IsUserActive = value;
    		}
    	}
    	
    	    private global::System.Boolean _IsUserActive;
       
       

        #endregion
            
            
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public PersonaBE(){}
            
            /// <summary>
            /// Constructor from Model Entity
            /// Framework BE --> Edm Entity Model 
            /// </summary>
            /// <param name="pPersona">Edm Model BE</param>
            public PersonaBE(Persona pPersona)
            {
            	_IdPersona =	pPersona.IdPersona ;
            		_UserId =	pPersona.UserId ;
            		_TipoDocumento =	pPersona.TipoDocumento ;
            		_NroDocumento =	pPersona.NroDocumento ;
            		_Apellido =	pPersona.Apellido ;
            		_Nombre =	pPersona.Nombre ;
            		_Sexo =	pPersona.Sexo ;
            		_IdEstadocivil =	pPersona.IdEstadocivil ;
            		_FechaNacimiento =	pPersona.FechaNacimiento ;
            		_LastAccessTime =	pPersona.LastAccessTime ;
            		_LastAccessUserId =	pPersona.LastAccessUserId ;
            		_FechaAlta =	pPersona.FechaAlta ;
            		_Calle =	pPersona.Calle ;
            		_CalleNumero =	pPersona.CalleNumero ;
            		_Piso =	pPersona.Piso ;
            		_IdPais =	pPersona.IdPais ;
            		_IdProvincia =	pPersona.IdProvincia ;
            		_IdLocalidad =	pPersona.IdLocalidad ;
            		_Barrio =	pPersona.Barrio ;
            		_mail =	pPersona.mail ;
            		_Telefono1 =	pPersona.Telefono1 ;
            		_Telefono2 =	pPersona.Telefono2 ;
            		_Foto =	pPersona.Foto ;
            		_IsNaturalPerson =	pPersona.IsNaturalPerson ;
            		_RazonSocial =	pPersona.RazonSocial ;
            		_IsUserActive =	pPersona.IsUserActive ;
            	}
            
            
            /// <summary>
            /// Overload equal operator
            /// Framework BE = Edm Entity Model 
            /// </summary>
            /// <param name="pPersona">Edm Model BE</param>
            public static explicit operator PersonaBE(Persona pPersona)
             {
              return  new  PersonaBE(pPersona);
            }
            }
    
    
    
    
    
    [XmlRoot("TipoParametroList"), SerializableAttribute]
    public partial class TipoParametroList : Fwk.Bases.Entities< TipoParametroBE >{}
    
       [XmlInclude(typeof(TipoParametroBE)), Serializable]
    public partial class TipoParametroBE : Fwk.Bases.Entity
    {
        #region Primitive Properties
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.Int32 IdTipoParametro
        {
            get
            {
                return _IdTipoParametro;
            }
            set
            { _IdTipoParametro = value;
    		}
    	}
    	
    	    private global::System.Int32 _IdTipoParametro;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            { _Nombre = value;
    		}
    	}
    	
    	    private global::System.String _Nombre;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public Nullable<global::System.Int32> IdTipoParametroRelacion
        {
            get
            {
                return _IdTipoParametroRelacion;
            }
            set
            { _IdTipoParametroRelacion = value;
    		}
    	}
    	
    	    private Nullable<global::System.Int32> _IdTipoParametroRelacion;
       
       
    
        /// <summary>
        /// 
        /// </summary>
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            { _Descripcion = value;
    		}
    	}
    	
    	    private global::System.String _Descripcion;
       
       

        #endregion
            
            
            /// <summary>
            /// Empty Constructor
            /// </summary>
            public TipoParametroBE(){}
            
            /// <summary>
            /// Constructor from Model Entity
            /// Framework BE --> Edm Entity Model 
            /// </summary>
            /// <param name="pTipoParametro">Edm Model BE</param>
            public TipoParametroBE(TipoParametro pTipoParametro)
            {
            	_IdTipoParametro =	pTipoParametro.IdTipoParametro ;
            		_Nombre =	pTipoParametro.Nombre ;
            		_IdTipoParametroRelacion =	pTipoParametro.IdTipoParametroRelacion ;
            		_Descripcion =	pTipoParametro.Descripcion ;
            	}
            
            
            /// <summary>
            /// Overload equal operator
            /// Framework BE = Edm Entity Model 
            /// </summary>
            /// <param name="pTipoParametro">Edm Model BE</param>
            public static explicit operator TipoParametroBE(TipoParametro pTipoParametro)
             {
              return  new  TipoParametroBE(pTipoParametro);
            }
            }

    #endregion
    
}
