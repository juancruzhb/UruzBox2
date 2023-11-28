using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        public static string cadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=UruzDB;Data Source=.\\SQLEXPRESS";

        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataReader rdr;

        public DataAccess() 
        {
            conn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
        }

        public SqlDataReader Rdr { get { return rdr; } }

        public SqlCommand Cmd { get { return cmd; } }

        public void ejecutarReader()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarQuery()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Setear las consultas

        public void setearQuery(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }
        //Setear SP

        public void setearSP(string sp)
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = sp;

        }
        public void setearParametros(string parametro, object valor)
        {

            cmd.Parameters.AddWithValue(parametro, valor);
        }

        public void open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void ejecutarConsulta()
        {
            cmd.Connection = conn;
            try
            {
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ejecutarScalar()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                return int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}
