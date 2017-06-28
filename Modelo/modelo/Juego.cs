using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.modelo
{
    //Delegado al cual suscribirse
    public delegate void finDelJuego();

    public class Juego
    {
        //Properties
        public Jugador J { get; private set; }
        public Tablero T { get; private set; }
        private int Dificultad{ get; set;}

        //Eventos de ganar o perder el juego.
        private event finDelJuego ganar;
        private event finDelJuego perder;

        //Constructores
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

        /// <summary>
        /// Metodo que sucribe un metodo del tipo finDelJuego al evento ganar
        /// </summary>
        /// <param name="f">Metodo del tipo finDelJuego</param>
        /// <returns>void</returns>
        public void subscribeGanar(finDelJuego f)
        {
            ganar += f;
        }

        /// <summary>
        /// Metodo que sucribe un metodo del tipo finDelJuego al evento perder
        /// </summary>
        /// <param name="f">Metodo del tipo finDelJuego</param>
        /// <returns>void</returns>
        public void subscribePerder(finDelJuego f)
        {
            perder += f;
        }

        /// <summary>
        /// Comprueba si se llego a una condicion de fin de juego, y desencadena el evento correspondiente
        /// </summary>
        /// <returns>void</returns>
        public void checkFinjuego()
        {
            if (checkGanar())
                ganar();
            else if (checkPerder())
                perder();
        }

        /// <summary>
        /// Metodo que intenta mover en el tablero, retornando un booleano que indica si hubo exito
        /// </summary>
        /// <param name="origen">Coordenadas de origen</param>
        /// <param name="destino">Coordenadas de destino</param>
        /// <returns>Booleano indicando si se logro mover o no</returns>
        public bool tryMover(Coords origen,Coords destino)
        {
            if (J.Turnos > 0)
            {
                bool check = T.tryMover(origen, destino);
                if(check)
                    J.Turnos--;
                return check;
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

        /// <summary>
        /// Metodo que eliminara los dulces que deban ser eliminados del tablero en caso de haberlos
        /// </summary>
        /// <returns>Booleano indicando si se elimino no</returns>
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


        private bool checkGanar()
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

        private bool checkPerder()
        {
            if (J.Turnos <= 0)
                return true;
            return false;
        }

        /// <summary>
        /// Devuelve el puntaje actual del jugador
        /// </summary>
        /// <returns>Puntaje del jugador</returns>
        public int getPuntaje()
        {
            return J.Puntaje;
        }

        /// <summary>
        /// Devuelve la cantidad de movimientos actual del jugador
        /// </summary>
        /// <returns>Movimientos del jugador</returns>
        public int getMovimientos()
        {
            return J.Turnos;
        }

        /// <summary>
        /// Devuelve el nombre del jugador
        /// </summary>
        /// <returns>Nombre del jugador</returns>
        public String getNombre()
        {
            return J.Nombre;
        }



    }
}
