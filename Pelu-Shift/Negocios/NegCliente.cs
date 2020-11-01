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
        private DatosCliente datosCliente = new DatosCliente();

        public Cliente SaveCliente(Cliente cliente)
        {
            if (cliente.Nombre == "")
            {
                datosCliente.AltaCliente(cliente);
            }

            return cliente;
        }
    }
}
