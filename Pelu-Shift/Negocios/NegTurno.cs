using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegTurno
    {
        private  DatosTurno datosTurno = new DatosTurno();

        public Turno SaveTurno(Turno turno)
        {
            if (turno.Dia == "")
            {
                datosTurno.AltaTurno(turno);
            }

            return turno;
        }
    }
}
