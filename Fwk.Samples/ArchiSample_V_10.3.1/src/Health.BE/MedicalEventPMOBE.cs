﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a allus Code Generator.
//     Runtime Version: 1.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Fwk.Bases;

namespace Health.BE
{

    [XmlRoot("MedicalEventPMO_Diag_List"), SerializableAttribute]
    public class MedicalEventPMO_Diag_List : Entities<MedicalEventPMO_Diag_View>
    { }

    [XmlInclude(typeof(MedicalEventPMO_Diag_View)), Serializable]
    public class MedicalEventPMO_Diag_View : Entity
    {
        #region [Private Members]
        private System.Int32 _MedicalEventId;

        private System.DateTime _CreatedDate;

        private System.Int32 _ProfesionalId;

        private System.String _Code;

        private System.String _Value;

        private System.String _Motivo;

        private System.Boolean _IsDefinitive;

        private System.String _Profesional;

        private System.String _RazonSocial;

        private Guid? _HealthInstitutionId;


        #endregion

        #region [Properties]
        #region [MedicalEventId]
        public System.Int32 MedicalEventId
        {
            get { return _MedicalEventId; }
            set { _MedicalEventId = value; }
        }
        #endregion


        #region [CreatedDate]
        public System.DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        #endregion


        #region [ProfesionalId]
        public System.Int32 ProfesionalId
        {
            get { return _ProfesionalId; }
            set { _ProfesionalId = value; }
        }
        #endregion


        #region [Code]
        public System.String Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        #endregion


        #region [Value]
        public System.String Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        #endregion


        #region [Motivo]
        public System.String Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value; }
        }
        #endregion


        #region [IsDefinitive]
        public System.Boolean IsDefinitive
        {
            get { return _IsDefinitive; }
            set { _IsDefinitive = value; }
        }
        #endregion


        #region [Profesional]
        public System.String Profesional
        {
            get { return _Profesional; }
            set { _Profesional = value; }
        }
        #endregion


        #region [RazonSocial]
        public System.String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
        #endregion


        #region [HealthInstitutionId]
        public Guid? HealthInstitutionId
        {
            get { return _HealthInstitutionId; }
            set { _HealthInstitutionId = value; }
        }
        #endregion



        #endregion

    }


}



