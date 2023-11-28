using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using Dominio;

namespace Business_Logic_Layer
{
    public class AlumnoBusiness
    {

        public int AgregarNuevoAlumno (Alumno alumno)
        {
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.setearQuery("Insert into Alumnos values (@Nombre,  @Apellido, @Celular, @Email)");
                dataAccess.setearParametros("@Nombre", alumno.Nombre);
                dataAccess.setearParametros("@Apellido", alumno.Apellido);
                dataAccess.setearParametros("@Celular", alumno.Celular);
                dataAccess.setearParametros("@Email", alumno.Email);

                dataAccess.ejecutarQuery();
                return 1;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
