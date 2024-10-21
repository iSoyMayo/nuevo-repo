using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_EquipoFutbol
{
    internal class clsPartido : clsPosicion
    {
        public int MinJugados {  get; set; }
        public string GolesAnotados { get; set; }

        
        public override string ToString()
        {
            return "Num. Jugador: "+NumJugador+"\nNombre del Jugador: "+Nombre+"\nPosicion: "+Posicion+"\nMinutos Jugados: "+MinJugados+"\nGoles Anotados: "+GolesAnotados;
        }

        public clsPartido()
        {
            MinJugados = 0;
            GolesAnotados = "~~~~";
        }

    }

    
}
