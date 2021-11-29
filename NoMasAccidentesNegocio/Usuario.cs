using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoMasAccidentesDALC;

namespace NoMasAccidentesNegocio
{
    public class Usuario
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Empresa_Rut { get; set; }
        public int Tipo_Usuario { get; set; }

        NoMasAccidentesEntitites db = new NoMasAccidentesEntitites();

        public bool Autenticar()
        {
            return db.USUARIO
                .Where(u => u.EMAIL == this.Email
                && u.PASSWORD == this.Password).FirstOrDefault() != null;

        }


    }
}
