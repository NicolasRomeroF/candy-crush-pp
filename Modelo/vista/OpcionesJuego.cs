using CC.modelo;
using System;
using System.Windows.Forms;

namespace CC.vista
{
    public partial class OpcionesJuego : Form
    {
        public static Form previous;
        private String user;

        public OpcionesJuego()
        {
            InitializeComponent();
            FormClosing+= OpcionesJuego_FormClosing;
            user = "Guest";
            labelUsuario.Text = user;
        }

        public OpcionesJuego(String user)
        {
            InitializeComponent();
            FormClosing += OpcionesJuego_FormClosing;
            this.user = user;
            labelUsuario.Text = user;
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            int N = (int)this.numericUpDownFilas.Value;
            int M = (int)this.numericUpDownColumnas.Value;
            int dificultad = obtenerDificultad();
            Parametros p = new Parametros(N, M, dificultad);
            Console.WriteLine(p.Dificultad);
            Jugador j = new Jugador(user);

            Juego juego = new Juego(j, p);
            VistaTablero vt = new VistaTablero(juego);
            this.Hide();
            vt.Show();
            VistaTablero.previous = this;

        }

        private int obtenerDificultad()
        {
            String difS = (String)this.comboBoxDificultad.SelectedItem; ;
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

        private void OpcionesJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Environment.Exit(0);
                    }
                    catch { }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            previous.Show();
        }

        private void buttonCrearTablero_Click(object sender, EventArgs e)
        {
            int N = (int)this.numericUpDownFilas.Value;
            int M = (int)this.numericUpDownColumnas.Value;
            int dificultad = obtenerDificultad();
            CrearTablero ct = new CrearTablero(N,M,dificultad,user);
            this.Hide();
            ct.Show();
            CrearTablero.previous = this;
        }

        private void buttonCargarTablero_Click(object sender, EventArgs e)
        {
            VistaCargarTablero vct = new VistaCargarTablero(user);
            VistaCargarTablero.previous = this;
            Hide();
            vct.Show();
        }
    }
}
