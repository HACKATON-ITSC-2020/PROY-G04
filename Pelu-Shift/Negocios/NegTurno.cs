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
        DatosTurno datosTurno = new DatosTurno();

        public int abmTurno(Turno objTurno)
        {
            return datosTurno.AltaTurno(objTurno);
        }

    }
}
