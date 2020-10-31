using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente  
    {
        public string Nombre { get; set; }
        public int ID_Turno { get; set; }
        public int ID_Peluquero { get; set; }
        public int ID_Servicio { get; set; }
    }
}
