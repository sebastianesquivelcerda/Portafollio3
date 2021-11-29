using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoMasAccidentesDALC;
using NoMasAccidentesNegocio;
namespace NoMasAccidentesNegocio
{
   public class Contrato
    {
       
        public int id_Contrato { get; set; }
       
        public DateTime fecha_Creacion_Contrato { get; set; }
     
        public string empresa_Rut { get; set; } [Required]
       

        public DateTime fecha_Termino_Contrato { get; set; }
      
        public string texto_Contrato { get; set; }
   

        NoMasAccidentesEntitites db = new NoMasAccidentesEntitites();

        public List<Contrato> ReadAll()
        {
            return this.db.CONTRATO.Select(p => new Contrato()
            {
                id_Contrato = (int)p.ID_CONTRATO,
                fecha_Creacion_Contrato = (DateTime)p.FECHA_CREACION_CONTRATO,
                empresa_Rut = p.EMPRESA_RUT,
                fecha_Termino_Contrato = (DateTime)p.FECHA_TERMINO_CONTRATO,
                texto_Contrato = p.TEXTO_CONTRATO


            }).ToList();

        }

        public bool Save()
       {
           try
           {



                db.SP_CREATE_CONTRATO(this.fecha_Creacion_Contrato, this.empresa_Rut, this.fecha_Termino_Contrato, this.texto_Contrato);
                return true;


           }
           catch (Exception)
           {

               return false;
           }
       }

    public Contrato find(int id)
        {
            return this.db.CONTRATO.Select(p => new Contrato()
            {
                id_Contrato = (int)p.ID_CONTRATO,
                fecha_Creacion_Contrato = (DateTime)p.FECHA_CREACION_CONTRATO,
                empresa_Rut = p.EMPRESA_RUT,
                fecha_Termino_Contrato = (DateTime)p.FECHA_TERMINO_CONTRATO,
                texto_Contrato = p.TEXTO_CONTRATO


            }).Where(p => p.id_Contrato == id).FirstOrDefault();
        }

        public bool Update()
        {
            try
            {
                db.SP_UPDATE_PRODUCTO(this.id_Contrato, this.fecha_Creacion_Contrato,
                                      this.empresa_Rut, this.fecha_Termino_Contrato,
                                      this.texto_Contrato);

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                db.SP_DELETE_CONTRATO(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        
    }

    
}
