using System;

namespace CC.modelo
{
    public class Dulce
    {
        //Dulces posibles
        public static readonly char[] colores = { 'A', 'B', 'C', 'D', 'E' };
        public static readonly char[] especiales = { 'X', 'Y', 'Z' };

        //Properties
        public char Color { get; set; }
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

        //Constructores
        public Dulce() { }

        public Dulce(char color,int recubrimiento)
        {
            Color = color;
            Recubrimiento = recubrimiento;
        }

        /// <summary>
        /// Entrega un char al azar entre el arreglo de dulces
        /// </summary>
        /// <param name="rnd">Objeto random desde el cual obtener un numero</param>
        /// <param name="cantTipos">Cantidad de tipos posibles del tablero</param>
        /// <returns>char que representa el color del dulce</returns>
        public static char dulceRandom(Random rnd,int cantTipos)
        {
            int indice = rnd.Next(0, cantTipos);
            char dulceNuevo = colores[indice];
            return dulceNuevo;
        }

        /// <summary>
        /// Entrega un char al azar entre el arreglo de dulces especiales
        /// </summary>
        /// <param name="rnd">Objeto random desde el cual obtener un numero</param>
        /// <returns>char que representa el dulce especial</returns>
        public static char especialRandom(Random rnd)
        {
            int indice = rnd.Next(0, 3);
            char especial = especiales[indice];
            return especial;
        }

        /// <summary>
        /// Entrega un int que representa al recubrimiento del dulce
        /// </summary>
        /// <param name="rnd">Objeto random desde el cual obtener un numero</param>
        /// <param name="recubrimientosRestantes">Recubrimientos restantes para poner en el tablero</param>
        /// <returns>int que representa el recubrimiento</returns>
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

        /// <summary>
        /// Comprueba si el color y el recubrimiento entregados son validos para un dulce.
        /// </summary>
        /// <param name="color">char que representa color del dulce</param>
        /// <param name="recubrimiento">int que representa recubrimiento del dulce</param>
        /// <returns>booleano</returns>
        public static bool checkDulce(char color,int recubrimiento)
        {
            if ((color == 'A' || color == 'B' || color == 'C' || color == 'D' || color == 'E' || color == 'X' || color == 'Y' || color == 'Z') && (recubrimiento >= 0 && recubrimiento <= 3))
                return true;
            return false;
        }

    }
}