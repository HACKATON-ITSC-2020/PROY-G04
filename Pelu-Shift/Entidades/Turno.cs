using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private string dia;
        private string horario;

        public string Dia { get => dia; set => dia = value; }
        public string Horario { get => horario; set => horario = value; }

        public Turno()
        {

        }
    }
}
