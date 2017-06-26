using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.modelo
{
    public class Juego
    {
        public Jugador J { get; private set; }
        public Tablero T { get; private set; }
        private int Dificultad{ get; set;}

        public Juego(Jugador j, Parametros p )
        {
            J = j;
            T = new Tablero(p.N, p.M, p.Dificultad);
            Dificultad = p.Dificultad;
            j.Turnos = determinarTurnos();
            Console.WriteLine(Dificultad);
        }
        public Juego(Jugador j, Tablero t)
        {
            J = j;
            T = t;
            Dificultad = t.dificultad; 
            j.Turnos = determinarTurnos();
        }

        private int determinarTurnos()
        {
            switch (Dificultad)
            {
                case 1:
                    return T.N * T.M / 2;
                case 2:
                    return T.N * T.M / 3;
                case 3:
                    return T.N * T.M / 4;
                default:
                    return T.N * T.M / 2;
            }
        }

        public bool tryMover(Coords origen,Coords destino)
        {
            if (J.Turnos > 0)
            {
                J.Turnos--;
                return T.tryMover(origen, destino);
            }
            return false;
        }

        public void eliminar2()
        {
            bool flag = true;
            while (flag)
            {
                List<Coords> delete = T.checkCandies();
                if (delete != null)
                {
                    T.eliminar(delete);
                    Coords.printLista(delete);
                }
                else
                    flag = false;

            }
        }

        public bool eliminar()
        {
           
            List<Coords> delete = T.checkCandies();
            if (delete != null)
            {
                T.eliminar(delete);
                Coords.printLista(delete);
                J.Puntaje = J.Puntaje + 100 * delete.Count +50 * (delete.Count - 3);
                return true;
            }

            return false;
               
            
        }


        public bool checkGanar()
        {
            int i, j;
            for (i = 0; i < T.N; i++)
            {
                for (j = 0; j < T.M; j++)
                {
                    if (T.Matriz[i,j].Recubrimiento > 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool checkPerder()
        {
            if (J.Turnos <= 0)
                return true;
            return false;
        }

        public int getPuntaje()
        {
            return J.Puntaje;
        }

        public int getMovimientos()
        {
            return J.Turnos;
        }

        public String getNombre()
        {
            return J.Nombre;
        }



    }
}
