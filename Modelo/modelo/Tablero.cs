using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.modelo

{
    public class Tablero
    {
        

        public Dulce[,] Matriz { get; private set; }
        public int CantTipos { get; private set; }
        private int _N;
        private int _M;
        private Random rnd = new Random();
        public int N
        {
            get
            {
                return _N;
            }
            private set
            {
                if (value >= 6)
                    _N = value;
                else
                    _N = 6;
            }
        }
        public int M
        {
            get
            {
                return _M;
            }
            private set
            { 
                if (value >= 6)
                    _M = value;
                else
                    _M = 6;
            }
        }

        public Tablero(int N, int M, int dificultad)
        {
            this.N = N;
            this.M = M;

            switch(dificultad)
            {
                case 1:
                    CantTipos = 3;
                    break;
                case 2:
                    CantTipos = 4;
                    break;
                case 3:
                    CantTipos = 5;
                    break;   
            }

            crearTablero();

        }

        private void crearTablero()
        {
            int flag;
            char dulceNuevo;
            Matriz = new Dulce[N, M];
            crearMatriz();
            int recubrimientos = N * M / 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    flag = 0;
                    dulceNuevo = Dulce.dulceRandom(rnd,CantTipos);
                    while (flag == 0)
                    {

                        if (i >= 2 && j >= 2)
                        {
                            if ((Matriz[i - 1,j].Color == Matriz[i - 2,j].Color && Matriz[i - 1,j].Color == dulceNuevo) || (Matriz[i,j - 1].Color == Matriz[i,j - 2].Color && Matriz[i,j - 1].Color == dulceNuevo))
                            {
                                dulceNuevo = Dulce.dulceRandom(rnd,CantTipos);
                            }
                            else
                            {
                                Matriz[i,j].Color = dulceNuevo;
                                Matriz[i,j].Recubrimiento = Dulce.obtenerRecubrimiento(rnd,ref recubrimientos);
                                flag = 1;
                            }
                        }
                        else if (j >= 2)
                        {
                            if (Matriz[i,j - 1].Color == Matriz[i,j - 2].Color && Matriz[i,j - 1].Color == dulceNuevo)
                            {
                                dulceNuevo = Dulce.dulceRandom(rnd,CantTipos);
                            }
                            else
                            {
                                Matriz[i,j].Color = dulceNuevo;
                                Matriz[i,j].Recubrimiento = Dulce.obtenerRecubrimiento(rnd,ref recubrimientos);
                                flag = 1;
                            }
                        }
                        else if (i >= 2)
                        {
                            if (Matriz[i - 1,j].Color == Matriz[i - 2,j].Color && Matriz[i - 1,j].Color == dulceNuevo)
                            {
                                dulceNuevo = Dulce.dulceRandom(rnd,CantTipos);
                            }
                            else
                            {
                                Matriz[i,j].Color = dulceNuevo;
                                Matriz[i,j].Recubrimiento = Dulce.obtenerRecubrimiento(rnd,ref recubrimientos);
                                flag = 1;
                            }
                        }
                        else
                        {
                            Matriz[i,j].Color = dulceNuevo;
                            Matriz[i,j].Recubrimiento = Dulce.obtenerRecubrimiento(rnd,ref recubrimientos);
                            flag = 1;
                        }

                    }
                }
            }

        }

        private void crearMatriz()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    Matriz[i, j] = new Dulce();
        }

        public bool tryMover(Coords origen,Coords destino)
        {
            if(checkMover(origen,destino))
            {
                Dulce aux = Matriz[origen.Fila, origen.Columna];
                Matriz[origen.Fila, origen.Columna] = Matriz[destino.Fila, destino.Columna];
                Matriz[destino.Fila, destino.Columna] = aux;
                return true;
            }
            return false;
        }

        private bool checkMover(Coords origen,Coords destino)
        {
            if (distancia(origen, destino) == 1
                && Matriz[origen.Fila, origen.Columna].Recubrimiento == 0
                && Matriz[destino.Fila, destino.Columna].Recubrimiento == 0)
                return true;
            return false;
        }

        private double distancia(Coords origen, Coords destino)
        {
            int dx = destino.Columna - origen.Columna;
            int dy = destino.Fila - origen.Fila;
            double d = Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2));
            return d;
        }

        public void printTablero()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
