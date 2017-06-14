using System;

namespace Modelo
{
    public class Casilla
    {
        public static readonly char[] colores = { 'A', 'B', 'C', 'D', 'E' };

        public char Color { get; set; }
        public char color;
        public int Recubrimiento {
            get
            {
                return _Recubrimiento;
            }
            set
            {
                if (value < 0)
                    _Recubrimiento = 0;
                else
                    _Recubrimiento = value;
            }
        }

        private int _Recubrimiento; 

        public static char dulceRandom(Random rnd,int cantTipos)
        {
            int indice = rnd.Next(0, cantTipos);
            char dulceNuevo = colores[indice];
            return dulceNuevo;
        }

        public static int obtenerRecubrimiento(Random rnd,ref int recubrimientosRestantes)
        {
            int prob = rnd.Next(0, 4);
            int recubrimiento;
            if (recubrimientosRestantes > 0)
            {
                if (prob == 3)
                {
                    recubrimiento = rnd.Next(0, 4);
                }
                else if (prob == 2)
                {
                    recubrimiento = rnd.Next(0, 2);
                }
                else
                {
                    recubrimiento = rnd.Next(0, 1);
                }

                recubrimientosRestantes = recubrimientosRestantes - recubrimiento;
                return recubrimiento;
            }
            return 0;
        }

        public override string ToString()
        {
            String casilla = Color + "." + Recubrimiento;
            return casilla;
        }

    }
}