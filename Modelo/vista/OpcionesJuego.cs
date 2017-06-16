using CC.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC.vista
{
    public partial class OpcionesJuego : Form
    {
        public OpcionesJuego()
        {
            InitializeComponent();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            int N = (int)this.numericUpDownFilas.Value;
            int M = (int)this.numericUpDownColumnas.Value;
            int dificultad = obtenerDificultad();
            Parametros p = new Parametros(N, M, dificultad);
            Jugador j = new Jugador("Admin");

            Juego juego = new Juego(j, p);
            VistaTablero vt = new VistaTablero(juego);
            this.Hide();
            vt.ShowDialog();
            this.Close();

        }

        private int obtenerDificultad()
        {
            String difS = this.comboBoxDificultad.ValueMember; ;
            int difInt= 1;
            switch(difS)
            {
                case "Facil":
                    difInt = 1;
                    break;
                case "Medio":
                    difInt = 2;
                    break;
                case "Dificil":
                    difInt = 3;
                    break;
                default:
                    difInt = 1;
                    break;
            }
            return difInt;
        }
    }
}
