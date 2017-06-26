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
    public partial class CrearTablero : Form
    {
        private Tablero t;
        private Button[,] botones;
        private bool moverState = false;
        private Coords last;
        public static Form previous;
        private String user;


        public CrearTablero(int N, int M, int dificultad,String user)
        {
            t = new Tablero(N, M, dificultad);
            InitializeComponent();
            generarBotones();
            FormClosing += CrearTablero_FormClosing;
            labelSeleccionar.Text = "Seleccione dulce a mover";
            this.user = user;
        }

        private void generarBotones()
        {
            botones = new Button[t.N, t.M];
            int i, j;
            this.tableLayoutPanelTablero.RowCount = t.N;
            this.tableLayoutPanelTablero.ColumnCount = t.M;
            this.tableLayoutPanelTablero.Width = 40 * t.M;
            this.tableLayoutPanelTablero.Height = 40 * t.N;
            for (i = 0; i < t.N; i++)
            {
                for (j = 0; j < t.M; j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Name = i.ToString() + "," + j.ToString();
                    botones[i, j].Height = 40;
                    botones[i, j].Width = 40;
                    botones[i, j].Margin = new Padding(0, 0, 0, 0);
                    botones[i, j].Click += new EventHandler(btnTablero_Click);
                    botones[i, j].Text = t.Matriz[i, j].Recubrimiento + "";
                    botones[i, j].Image = getImagen(i, j);
                    //botones[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    //botones[i, j].MouseEnter += new EventHandler(btnTablero_MouseEnter);
                    //botones[i, j].MouseLeave += new EventHandler(btnTablero_MouseLeave);
                    tableLayoutPanelTablero.Controls.Add(botones[i, j], j, i);
                }
            }
        }

        private void btnTablero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            String[] coords = boton.Name.Split(',');
            int i = int.Parse(coords[0]);
            int j = int.Parse(coords[1]);
            if (moverState)
            {
                Coords act = new Coords(i, j);
               t.mover(last, act);
                update();
                
                Refresh();
                
                Console.WriteLine("Se movio");            
                
                Refresh();
                labelSeleccionar.Text = "Seleccione dulce a mover";
                moverState = false;

            }
            else
            {
                Console.WriteLine("else");
                last.Fila = i;
                last.Columna = j;
                update();
                boton.BackColor = Color.LightSkyBlue;
                labelSeleccionar.Text = "Seleccione destino";
                moverState = true;
            }

            String info = "i: " + i + " j: " + j + " text: " + t.Matriz[i, j].ToString();
            Console.WriteLine(info);
        }

        private void update()
        {
            for (int i = 0; i < t.N; i++)
            {
                for (int j = 0; j < t.M; j++)
                {
                    botones[i, j].Text = t.Matriz[i, j].Recubrimiento + "";
                    botones[i, j].Image = getImagen(i, j);

                }
            }
            this.Refresh();
        }

        private Bitmap getImagen(int i, int j)
        {
            int color = t.Matriz[i, j].Color;
            switch (color)
            {
                case 'A':
                    return Properties.Resources.A;
                case 'B':
                    return Properties.Resources.B;
                case 'C':
                    return Properties.Resources.C;
                case 'D':
                    return Properties.Resources.D;
                case 'E':
                    return Properties.Resources.E;
                default:
                    return Properties.Resources.A;
            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
            previous.Show();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
           
            Jugador j = new Jugador(user);

            Juego juego = new Juego(j, t);
            VistaTablero vt = new VistaTablero(juego);
            this.Dispose();
            vt.Show();
            VistaTablero.previous = previous;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            VistaGuardarTablero vgt = new VistaGuardarTablero(t);
            vgt.ShowDialog();
            Show();
        }

        private void CrearTablero_FormClosing(object sender, FormClosingEventArgs e)
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
