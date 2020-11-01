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
        public void AltaTurno(Turno turno)
        {
            try
            {
                cn.Open();
                string query = @"
                               Insert into Turno (Dia, Horario) values (@Dia, @Horario)";

                SqlParameter dia = new SqlParameter("@Dia", turno.Dia);
                SqlParameter horario = new SqlParameter("@Horario", turno.Horario);

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
