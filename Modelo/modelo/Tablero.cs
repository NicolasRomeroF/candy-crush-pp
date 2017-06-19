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

        public List<Coords> checkCandies()
        {
            int i, j;
            List<Coords> arreglo;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    if (i < N - 2)
                    {
                        if (Matriz[i,j].Color == Matriz[i + 1,j].Color && Matriz[i,j].Color == Matriz[i + 2,j].Color)
                        {
                            arreglo = agregarColDulces(i, j);
                            return arreglo;
                        }
                    }
                    if (j < M - 2)
                    {
                        if (Matriz[i,j].Color == Matriz[i,j + 1].Color && Matriz[i,j].Color == Matriz[i,j + 2].Color)
                        {
                            arreglo = agregarFilaDulces(i, j);
                            return arreglo;
                        }
                    }
                }
            }
            return null;
        }

        private List<Coords> agregarColDulces(int i, int j)
        {
            char target = Matriz[i,j].Color;
            int aux = 0;
            int flag = 1;
            List<Coords> colDulces = new List<Coords>();
            while (flag == 1 && target == Matriz[i + aux,j].Color)
            {
                Coords actual = new Coords(i + aux, j,2);
                colDulces.Add(actual);
                aux++;
                if ((i + aux) == N)
                {
                    flag = 0;
                }
            }
            return colDulces;
        }

        private List<Coords> agregarFilaDulces(int i, int j)
        {
            char target = Matriz[i, j].Color;
            int aux = 0;
            int flag = 1;
            List<Coords> filaDulces = new List<Coords>();
            while (flag == 1 && target == Matriz[i, j+aux].Color)
            {
                Coords actual = new Coords(i, j+aux, 2);
                filaDulces.Add(actual);
                aux++;
                if ((j + aux) == M)
                {
                    flag = 0;
                }
            }
            return filaDulces;
        }

        public void eliminar(List<Coords> eliminar)
        {
            int size = eliminar.Count;
            int cond = eliminar[0].FilCol;
            int i;
            int cantTipos = CantTipos;
            char dulceNuevo;
            if (cond == 1)
            {
                for (i = 0; i < size; i++)
                {
                    if (i == 0 && eliminar[i].Columna != 0)
                    {
                        if (Matriz[eliminar[i].Fila,eliminar[i].Columna - 1].Recubrimiento != 0)
                        {
                            Matriz[eliminar[i].Fila,eliminar[i].Columna - 1].Recubrimiento--;
                        }
                    }
                    if (i == size - 1 && eliminar[i].Columna != M - 1)
                    {
                        if (Matriz[eliminar[i].Fila,eliminar[i].Columna + 1].Recubrimiento != 0)
                        {
                            Matriz[eliminar[i].Fila,eliminar[i].Columna + 1].Recubrimiento--;
                        }
                    }
                    if (eliminar[i].Fila != 0 && Matriz[eliminar[i].Fila - 1,eliminar[i].Columna].Recubrimiento != 0)
                    {
                        Matriz[eliminar[i].Fila - 1,eliminar[i].Columna].Recubrimiento--;
                    }
                    if (eliminar[i].Fila != N - 1 && Matriz[eliminar[i].Fila + 1,eliminar[i].Columna].Recubrimiento != 0)
                    {
                        Matriz[eliminar[i].Fila + 1,eliminar[i].Columna].Recubrimiento--;
                    }
                    dulceNuevo = Dulce.dulceRandom(rnd,cantTipos);
                    Matriz[eliminar[i].Fila,eliminar[i].Columna].Color = dulceNuevo;
                    if (Matriz[eliminar[i].Fila,eliminar[i].Columna].Recubrimiento > 0)
                    {
                        Matriz[eliminar[i].Fila,eliminar[i].Columna].Recubrimiento--;
                    }
                }
            }
            if (cond == 2)
            {
                for (i = 0; i < size; i++)
                {
                    if (i == 0 && eliminar[i].Fila != 0)
                    {
                        if (Matriz[eliminar[i].Fila - 1,eliminar[i].Columna].Recubrimiento != 0)
                        {
                            Matriz[eliminar[i].Fila - 1,eliminar[i].Columna].Recubrimiento--;
                        }
                    }
                    if (i == size - 1 && eliminar[i].Fila != N - 1)
                    {
                        if (Matriz[eliminar[i].Fila + 1,eliminar[i].Columna].Recubrimiento != 0)
                        {
                            Matriz[eliminar[i].Fila + 1,eliminar[i].Columna].Recubrimiento--;
                        }
                    }
                    if (eliminar[i].Columna != 0 && Matriz[eliminar[i].Fila,eliminar[i].Columna - 1].Recubrimiento != 0)
                    {
                        Matriz[eliminar[i].Fila,eliminar[i].Columna - 1].Recubrimiento--;
                    }
                    if (eliminar[i].Columna != M - 1 && Matriz[eliminar[i].Fila,eliminar[i].Columna + 1].Recubrimiento != 0)
                    {
                        Matriz[eliminar[i].Fila,eliminar[i].Columna + 1].Recubrimiento--;
                    }
                    dulceNuevo = Dulce.dulceRandom(rnd,cantTipos);
                    Matriz[eliminar[i].Fila,eliminar[i].Columna].Color = dulceNuevo;
                    if (Matriz[eliminar[i].Fila,eliminar[i].Columna].Recubrimiento > 0)
                    {
                        Matriz[eliminar[i].Fila,eliminar[i].Columna].Recubrimiento--;
                    }
                }
            }
        }


    }
}
