using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.modelo
{
    public class Jugador
    {
        //Properties
        public String Nombre { get; set; }
        public int Puntaje { get; set; }
        public int Turnos { get; set; }

        //Constructor
        public Jugador(String nombre)
        {
            Nombre = nombre;
            Turnos = 0;
            Puntaje = 0;
        }
    }
}
