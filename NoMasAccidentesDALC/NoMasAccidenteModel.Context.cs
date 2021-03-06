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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class NoMasAccidentesEntitites : DbContext
    {
        public NoMasAccidentesEntitites()
            : base("name=NoMasAccidentesEntitites")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ASESORIA> ASESORIA { get; set; }
        public DbSet<CAPACITACION> CAPACITACION { get; set; }
        public DbSet<CONTRATO> CONTRATO { get; set; }
        public DbSet<EMPRESA> EMPRESA { get; set; }
        public DbSet<INFORME> INFORME { get; set; }
        public DbSet<LLAMADO> LLAMADO { get; set; }
        public DbSet<PAGOS> PAGOS { get; set; }
        public DbSet<PLAN_PAGO> PLAN_PAGO { get; set; }
        public DbSet<SERVICIO> SERVICIO { get; set; }
        public DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<VISITA> VISITA { get; set; }
    
        public virtual int SP_CREATE_CONTRATO(Nullable<System.DateTime> v_FECHA_CREACION_CONTRATO, string v_EMPRESA_RUT, Nullable<System.DateTime> v_FECHA_TERMINO_CONTRATO, string v_TEXTO_CONTRATO)
        {
            var v_FECHA_CREACION_CONTRATOParameter = v_FECHA_CREACION_CONTRATO.HasValue ?
                new ObjectParameter("V_FECHA_CREACION_CONTRATO", v_FECHA_CREACION_CONTRATO) :
                new ObjectParameter("V_FECHA_CREACION_CONTRATO", typeof(System.DateTime));
    
            var v_EMPRESA_RUTParameter = v_EMPRESA_RUT != null ?
                new ObjectParameter("V_EMPRESA_RUT", v_EMPRESA_RUT) :
                new ObjectParameter("V_EMPRESA_RUT", typeof(string));
    
            var v_FECHA_TERMINO_CONTRATOParameter = v_FECHA_TERMINO_CONTRATO.HasValue ?
                new ObjectParameter("V_FECHA_TERMINO_CONTRATO", v_FECHA_TERMINO_CONTRATO) :
                new ObjectParameter("V_FECHA_TERMINO_CONTRATO", typeof(System.DateTime));
    
            var v_TEXTO_CONTRATOParameter = v_TEXTO_CONTRATO != null ?
                new ObjectParameter("V_TEXTO_CONTRATO", v_TEXTO_CONTRATO) :
                new ObjectParameter("V_TEXTO_CONTRATO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CREATE_CONTRATO", v_FECHA_CREACION_CONTRATOParameter, v_EMPRESA_RUTParameter, v_FECHA_TERMINO_CONTRATOParameter, v_TEXTO_CONTRATOParameter);
        }
    
        public virtual int SP_UPDATE_PRODUCTO(Nullable<decimal> v_ID_CONTRATO, Nullable<System.DateTime> v_FECHA_CREACION_CONTRATO, string v_EMPRESA_RUT, Nullable<System.DateTime> v_FECHA_TERMINO_CONTRATO, string v_TEXTO_CONTRATO)
        {
            var v_ID_CONTRATOParameter = v_ID_CONTRATO.HasValue ?
                new ObjectParameter("V_ID_CONTRATO", v_ID_CONTRATO) :
                new ObjectParameter("V_ID_CONTRATO", typeof(decimal));
    
            var v_FECHA_CREACION_CONTRATOParameter = v_FECHA_CREACION_CONTRATO.HasValue ?
                new ObjectParameter("V_FECHA_CREACION_CONTRATO", v_FECHA_CREACION_CONTRATO) :
                new ObjectParameter("V_FECHA_CREACION_CONTRATO", typeof(System.DateTime));
    
            var v_EMPRESA_RUTParameter = v_EMPRESA_RUT != null ?
                new ObjectParameter("V_EMPRESA_RUT", v_EMPRESA_RUT) :
                new ObjectParameter("V_EMPRESA_RUT", typeof(string));
    
            var v_FECHA_TERMINO_CONTRATOParameter = v_FECHA_TERMINO_CONTRATO.HasValue ?
                new ObjectParameter("V_FECHA_TERMINO_CONTRATO", v_FECHA_TERMINO_CONTRATO) :
                new ObjectParameter("V_FECHA_TERMINO_CONTRATO", typeof(System.DateTime));
    
            var v_TEXTO_CONTRATOParameter = v_TEXTO_CONTRATO != null ?
                new ObjectParameter("V_TEXTO_CONTRATO", v_TEXTO_CONTRATO) :
                new ObjectParameter("V_TEXTO_CONTRATO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_PRODUCTO", v_ID_CONTRATOParameter, v_FECHA_CREACION_CONTRATOParameter, v_EMPRESA_RUTParameter, v_FECHA_TERMINO_CONTRATOParameter, v_TEXTO_CONTRATOParameter);
        }
    
        public virtual int SP_DELETE_CONTRATO(Nullable<decimal> v_ID)
        {
            var v_IDParameter = v_ID.HasValue ?
                new ObjectParameter("V_ID", v_ID) :
                new ObjectParameter("V_ID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DELETE_CONTRATO", v_IDParameter);
        }
    }
}
