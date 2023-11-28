using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Alumno() { }
        public Alumno(string nombre, string apellido, string celular, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Celular = celular;
            Email = email;
        }
    }
}
