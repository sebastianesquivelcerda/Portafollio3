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
    
    public partial class PLAN_PAGO
    {
        public decimal ID_PLAN_PAGO { get; set; }
        public string TIPO { get; set; }
        public string FECHA_INICIO { get; set; }
        public string FECHA_TERMINO { get; set; }
        public string MOROSIDAD { get; set; }
        public decimal PAGOS_ID { get; set; }
    
        public virtual PAGOS PAGOS { get; set; }
    }
}
