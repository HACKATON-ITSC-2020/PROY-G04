using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocios
{
    public class NegCliente
    {
        private DatosConexionDB datosConexionDB;
        public NegCliente()
        {
            datosConexionDB = new DatosConexionDB();
        }

        public Cliente SaveCliente (Cliente cliente)
        {
            if (cliente.Nombre == "")
            {
                datosConexionDB.AltaCliente(cliente);
            }

            return cliente;
        }
    }
}
