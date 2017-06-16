using CC.modelo;
using CC.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            /*
            Tablero t = new Tablero(10, 10, 1);
            t.printTablero();
            Console.ReadLine();
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MenuInicio mi = new MenuInicio();
            Application.Run(mi);
        }
    }
}
