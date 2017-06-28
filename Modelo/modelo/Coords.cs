using System;
using System.Collections.Generic;

namespace CC.modelo
{
    public struct Coords
    {
        //Properties
        public int Fila{get; set;}
        public int Columna { get; set; }
        public int FilCol { get; set; }

        //Constructores
        public Coords(int fila, int columna,int filCol)
        {
            Fila = fila;
            Columna = columna;
            FilCol = filCol; 
        }

        public Coords(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            FilCol = -1;
        }

        /// <summary>
        /// Representa el objeto como un string
        /// </summary>
        /// <returns>String que representa las coordenadas</returns>
        public override string ToString()
        {
            return Fila + "," + Columna;
        }

        /// <summary>
        /// Muestra por consola una lista de coordenadas.
        /// </summary>
        /// <param name="lista">Lista de coordenadas</param>
        /// <returns>void</returns>
        public static void printLista(List<Coords> lista)
        {
            foreach(Coords elemento in lista)
            {
                Console.Write(elemento);
                Console.Write(" ");
            }
            Console.Write("\n");
        }

    }
}