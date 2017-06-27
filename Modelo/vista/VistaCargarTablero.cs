using CC.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC.vista
{
    public partial class VistaCargarTablero : Form
    {
        public static Form previous;
        private String user;

        public VistaCargarTablero(String user)
        {
            InitializeComponent();
            agregarElementos();
            this.user = user;
            FormClosing += VistaCargarTablero_FormClosing;
        }
        private void agregarElementos()
        {
            String[] tableros = Directory.GetFiles(@"Tableros");
            Console.WriteLine(tableros[0]);
            listBoxTableros.Items.AddRange(tableros);
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            String tablero = (String)listBoxTableros.SelectedItem;
            Jugador j = new Jugador(user);

            bool check = Tablero.checkBoard(tablero);
            if (!check)
                MessageBox.Show("El tablero seleccionado no es valido");
            else
            {
                Tablero t = new Tablero(tablero);
                Console.WriteLine("print tablero");
                t.printTablero();
                Juego juego = new Juego(j, t);
                VistaTablero vt = new VistaTablero(juego);
                vt.Show();
                VistaTablero.previous = previous;
                Dispose();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            previous.Show();
            Dispose();
        }

        private void VistaCargarTablero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
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
    }
}
