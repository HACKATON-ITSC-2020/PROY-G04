using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCliente : DatosConexionDB
    {
        public void AltaCliente(Cliente cliente)
        {
            try
            {
                cn.Open();
                string query = @"
                               Insert into Cliente (Nombre) values (@Nombre)";

                SqlParameter nombre = new SqlParameter("@Nombre", cliente.Nombre);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
