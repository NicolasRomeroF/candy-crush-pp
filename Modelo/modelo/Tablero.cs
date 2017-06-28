using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.modelo

{
    public class Tablero
    {
        
        //Properties
        public Dulce[,] Matriz { get; private set; }
        public int CantTipos { get; private set; }
        private int _N;
        private int _M;
        private Random rnd = new Random();
        public int dificultad;

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

       
        //Constructores
        public Tablero(int N, int M, int dificultad)
        {
            this.N = N;
            this.M = M;
            this.dificultad = dificultad;

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
            Console.WriteLine("Dificultad:" + dificultad);
            Console.WriteLine("CantTipos:" + CantTipos);

            crearTablero();

        }

        public Tablero(string tablero)
        {
            fromArchivo(tablero);
        }


        /// <summary>
        /// Comprueba si el fichero ubicado en la ruta contiene un tablero valido
        /// </summary>
        /// <param name="path">Coordenadas de origen</param>
        /// <returns>Booleano indicando si el tablero es valido</returns>
        public static bool checkBoard(string path)
        {
            StreamReader file = new StreamReader(path);

            String linea = file.ReadLine();
            String[] datos = linea.Split(';');
            int N, M, dif;
            try
            {
                bool Ntry = int.TryParse(datos[0], out N);
                bool Mtry = int.TryParse(datos[1], out M);
                bool diftry = int.TryParse(datos[2], out dif);
                if (!Ntry || !Mtry || !diftry)
                    return false;
                if (N < 6 || M < 6 || dif > 3 || dif < 0)
                    return false;

                String[] dulces;
                char[] dulce;
                bool check = true;

                for (int i = 0; i < N; i++)
                {
                    linea = file.ReadLine();
                    dulces = linea.Split(';');
                    for (int j = 0; j < M; j++)
                    {
                        dulce = dulces[j].ToCharArray();
                        check = Dulce.checkDulce(dulce[0], (int)Char.GetNumericValue(dulce[2]));
                        if (!check)
                            return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void fromArchivo(string path)
        {
            StreamReader file = new StreamReader(path);

            String linea = file.ReadLine();
            String[] datos = linea.Split(';');
            String[] dulces;
            char[] dulce;
            N = int.Parse(datos[0]);
            M = int.Parse(datos[1]);
            dificultad = int.Parse(datos[2]);

            Matriz = new Dulce[N, M];

            for (int i = 0; i < N; i++)
            {
                linea = file.ReadLine();
                dulces = linea.Split(';');
                for (int j=0;j<M;j++)
                {
                    dulce = dulces[j].ToCharArray();
                    Matriz[i, j] = new Dulce(dulce[0], (int)Char.GetNumericValue(dulce[2]));
                    Console.WriteLine(Matriz[i, j]);

                }
            }
            file.Close();

            switch (dificultad)
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

            printTablero();
        }

        /// <summary>
        /// Guarda un tablero en un fichero en la direccion especificada
        /// </summary>
        /// <param name="path">Direccion donde guardar tablero</param>
        /// <returns>void</returns>
        public void toArchivo(string path)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(N + ";" + M + ";" + dificultad);
            String linea="";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    linea = linea + Matriz[i, j] + ";";
                }
                file.WriteLine(linea);
                linea = "";
            }
            file.Close();
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

            ponerEspeciales();

        }

        private void crearMatriz()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    Matriz[i, j] = new Dulce();
        }

        /// <summary>
        /// Metodo que intenta mover en el tablero, retornando un booleano que indica si hubo exito
        /// </summary>
        /// <param name="origen">Coordenadas de origen</param>
        /// <param name="destino">Coordenadas de destino</param>
        /// <returns>Booleano indicando si se logro mover o no</returns>
        public bool tryMover(Coords origen,Coords destino)
        {
            if(checkMover(origen,destino))
            {
                Dulce aux = Matriz[origen.Fila, origen.Columna];
                Matriz[origen.Fila, origen.Columna] = Matriz[destino.Fila, destino.Columna];
                Matriz[destino.Fila, destino.Columna] = aux;
                checkEspeciales(origen,destino);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo que mueve dos dulces en el tablero
        /// </summary>
        /// <param name="origen">Coordenadas de origen</param>
        /// <param name="destino">Coordenadas de destino</param>
        /// <returns>void</returns>
        public void mover(Coords origen, Coords destino)
        {
            Dulce aux = Matriz[origen.Fila, origen.Columna];
            Matriz[origen.Fila, origen.Columna] = Matriz[destino.Fila, destino.Columna];
            Matriz[destino.Fila, destino.Columna] = aux;
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

        /// <summary>
        /// Muestra el tablero por consola
        /// </summary>
        /// <returns>void</returns>
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

        /// <summary>
        /// Devuelve una lista con dulces a eliminar si es que los hubiera
        /// </summary>
        /// <returns>Lista con dulces a eliminar en caso de haberlos</returns>
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
                Coords actual = new Coords(i, j+aux, 1);
                filaDulces.Add(actual);
                aux++;
                if ((j + aux) == M)
                {
                    flag = 0;
                }
            }
            return filaDulces;
        }

        /// <summary>
        /// Elimina los dulces entregados como entrada
        /// </summary>
        /// <param name="eliminar">Coordenadas de dulces a eliminar</param>
        /// <returns>void</returns>
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
                    Console.WriteLine("i = " + i + "; fila = " + eliminar[i].Fila + "; columna = " + eliminar[i].Columna);
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
                    Console.WriteLine("cond 2 (columna) i = " + i + "; fila = " + eliminar[i].Fila + "; columna = " + eliminar[i].Columna);
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

        private void ponerEspeciales()
        {
            int i, j;
            int prob;

            Console.WriteLine("Especiales!!");

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    prob = rnd.Next(0,36);
                    if (prob < 2)
                    {
                        Matriz[i, j].Color = Dulce.especialRandom(rnd);
                        Matriz[i,j].Recubrimiento = 0;
                    }
                }
            }
        }

        private void explotarTablero()
        {
            int i, j;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    Matriz[i,j].Color = Dulce.dulceRandom(rnd,CantTipos);
                    if (Matriz[i,j].Recubrimiento > 0)
                    {
                        Matriz[i,j].Recubrimiento--;
                    }
                }
            }
        }

        private void explotarFila(int i)
        {
            int j;
            for (j = 0; j < M; j++)
            {
                Matriz[i,j].Color = Dulce.dulceRandom(rnd,CantTipos);
                if (Matriz[i,j].Recubrimiento > 0)
                {
                    Matriz[i,j].Recubrimiento--;
                }
            }
        }

        private void explotarCol(int j)
        {
            int i;
            for (i = 0; i < N; i++)
            {
                Matriz[i,j].Color = Dulce.dulceRandom(rnd,CantTipos);
                if (Matriz[i,j].Recubrimiento > 0)
                {
                    Matriz[i,j].Recubrimiento--;
                }
            }
        }

        private void explotarChars(char target)
        {
            int i, j;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    if (Matriz[i,j].Color == target)
                    {
                        Matriz[i,j].Color = Dulce.dulceRandom(rnd,CantTipos);
                        if (Matriz[i,j].Recubrimiento > 0)
                        {
                            Matriz[i,j].Recubrimiento--;
                        }
                    }
                }
            }
        }

        private void checkEspeciales(Coords posInicial, Coords posFinal)
        {
            if (Matriz[posInicial.Fila,posInicial.Columna].Color == 'X' && (Matriz[posFinal.Fila,posFinal.Columna].Color == 'Y' || Matriz[posFinal.Fila,posFinal.Columna].Color == 'Z' || Matriz[posFinal.Fila,posFinal.Columna].Color == 'X'))
            {
                explotarTablero();
                return;
            }
            if (Matriz[posInicial.Fila,posInicial.Columna].Color == 'Y' && (Matriz[posFinal.Fila,posFinal.Columna].Color == 'X' || Matriz[posFinal.Fila,posFinal.Columna].Color == 'Z' || Matriz[posFinal.Fila,posFinal.Columna].Color == 'Y'))
            {
                explotarTablero();
                return;
            }
            if (Matriz[posInicial.Fila,posInicial.Columna].Color == 'Z' && (Matriz[posFinal.Fila,posFinal.Columna].Color == 'X' || Matriz[posFinal.Fila,posFinal.Columna].Color == 'Y' || Matriz[posFinal.Fila,posFinal.Columna].Color == 'Z'))
            {
                explotarTablero();
                return;
            }
            if (Matriz[posInicial.Fila,posInicial.Columna].Color == 'X')
            {
                explotarFila(posInicial.Fila);
                return;
            }
            if (Matriz[posFinal.Fila,posFinal.Columna].Color == 'X')
            {
                explotarFila(posFinal.Fila);
                return;
            }
            if (Matriz[posInicial.Fila,posInicial.Columna].Color == 'Y')
            {
                explotarCol(posInicial.Columna);
                return;
            }
            if (Matriz[posFinal.Fila,posFinal.Columna].Color == 'Y')
            {
                explotarCol(posFinal.Columna);
                return;
            }
            if (Matriz[posInicial.Fila,posInicial.Columna].Color == 'Z')
            {
                explotarChars(Matriz[posFinal.Fila,posFinal.Columna].Color);
                char dulceNuevo = Dulce.dulceRandom(rnd,CantTipos);
                Matriz[posInicial.Fila,posInicial.Columna].Color = dulceNuevo;
                return;
            }
            if (Matriz[posFinal.Fila,posFinal.Columna].Color == 'Z')
            {
                explotarChars( Matriz[posInicial.Fila,posInicial.Columna].Color);
                char dulceNuevo = Dulce.dulceRandom(rnd,CantTipos);
                Matriz[posFinal.Fila,posFinal.Columna].Color = dulceNuevo;
                return;
            }
        }
    }
}
