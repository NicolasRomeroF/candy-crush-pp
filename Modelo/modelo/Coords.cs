using System;
using System.Collections.Generic;

namespace CC.modelo
{
    public struct Coords
    {
        public int Fila{get; set;}
        public int Columna { get; set; }
        public int FilCol { get; set; }

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

        public override string ToString()
        {
            return Fila + "," + Columna;
        }

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