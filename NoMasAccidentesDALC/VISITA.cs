//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoMasAccidentesDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class VISITA
    {
        public decimal ID_VISITA { get; set; }
        public string REVISION_DOCUMENTACION { get; set; }
        public string SEGURIDAD_TERRENO { get; set; }
        public System.DateTime FECHA_INGRESO { get; set; }
        public System.DateTime FECHA_VISITA { get; set; }
        public string FECHA_CIERRE { get; set; }
        public string LISTA { get; set; }
        public string PROFESIONAL_RUT { get; set; }
        public string EMPRESA_RUT { get; set; }
    
        public virtual EMPRESA EMPRESA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
