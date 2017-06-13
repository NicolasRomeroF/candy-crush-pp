using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Tablero
    {
        public const char[] colores = ['A', 'B', 'C', 'D', 'E'];

        public Casilla[,] Matriz { get; private set; }
        public int CantTipos { get; private set; }
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

        private int _N;
        private int _M;

        public Tablero(int N, int M, int dificultad)
        {
            this.N = N;
            this.M = M;
            crearTablero();
        }

        private void crearTablero()
        {
            throw new NotImplementedException();
        }
    }
}
