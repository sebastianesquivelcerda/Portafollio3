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
    
    public partial class USUARIO
    {
        public USUARIO()
        {
            this.ASESORIA = new HashSet<ASESORIA>();
            this.CAPACITACION = new HashSet<CAPACITACION>();
            this.VISITA = new HashSet<VISITA>();
        }
    
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public decimal EDAD { get; set; }
        public string SEXO { get; set; }
        public string DIRECCION { get; set; }
        public string EMAIL { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string ESTADO { get; set; }
        public Nullable<System.DateTime> FECHA_REGISTRO { get; set; }
        public string EMPRESA_RUT { get; set; }
        public decimal TIPO_USUARIO_ID_TIPO_USUARIO { get; set; }
    
        public virtual ICollection<ASESORIA> ASESORIA { get; set; }
        public virtual ICollection<CAPACITACION> CAPACITACION { get; set; }
        public virtual TIPO_USUARIO TIPO_USUARIO { get; set; }
        public virtual ICollection<VISITA> VISITA { get; set; }
    }
}