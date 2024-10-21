using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_EquipoFutbol
{
    internal class clsPosicion:clsJugador
    {
        public string Posicion {  get; set; }

        public clsPosicion() 
        {
            Posicion = "~~~~";
        }
    }
}
