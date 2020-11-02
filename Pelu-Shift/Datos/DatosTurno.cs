using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosTurno : DatosConexionDB
    {
        public int AltaTurno(Turno turno)
        {
            int resultado = -1;

            try
            {
                cn.Open();
                string query = @" Insert into Turno (Dia, Horario) values ('" + turno.Dia + "','" + turno.Horario + "')";

                SqlCommand command = new SqlCommand(query, cn);

                resultado = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
