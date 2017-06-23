using CC.modelo;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CC.vista
{
    public delegate void finDelJuego(Juego game, EventArgs e);

    public partial class VistaTablero : Form
    {
        public static Form previous;

        public Juego Juego { get; private set; }
        public Button[,] botones { get; set; }
        private bool moverState = false;
        private Coords last;
        private event finDelJuego ganar;
        private event finDelJuego perder;

        public VistaTablero(Juego j)
        {
            InitializeComponent();
            Juego = j;
            generarBotones();
            ganar += mostrarGanar;
            perder += mostrarPerder;
            FormClosing += VistaTablero_FormClosing;
        }

        private void mostrarPerder(Juego game, EventArgs e)
        {
            

            throw new NotImplementedException();
        }

        private void mostrarGanar(Juego game, EventArgs e)
        {
            if (Juego.checkGanar())
            {
                MessageBox.Show("Has ganado "+game.J.Nombre+"!\n"+"Tu puntaje final fue: "+game.getPuntaje());
                this.Dispose();
            }
        }

        private void generarBotones()
        {
            Tablero t = Juego.T;
            botones = new Button[t.N, t.M];
            int i, j;
            this.tableLayoutPanelTablero.RowCount = Juego.T.N;
            this.tableLayoutPanelTablero.ColumnCount = Juego.T.M;
            this.tableLayoutPanelTablero.Width = 40 * Juego.T.M;
            this.tableLayoutPanelTablero.Height = 40 * Juego.T.N;
            for (i=0;i<t.N;i++)
            {
                for(j=0;j<t.M;j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Name = i.ToString() + "," + j.ToString();
                    botones[i, j].Height = 40;
                    botones[i, j].Width = 40;
                    botones[i, j].Margin = new Padding(0, 0, 0, 0);
                    botones[i, j].Click += new EventHandler(btnTablero_Click);
                    botones[i, j].Text = Juego.T.Matriz[i, j].ToString();
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
                bool intento = Juego.tryMover(last, act);
                Thread.Sleep(1000);
                update();
                Console.WriteLine(intento);

                if (intento)
                {
                    Console.WriteLine("Se movio");
                    
                    eliminar();
                }
                ganar(Juego, e);    
                moverState = false;

            }
            else
            {
                Console.WriteLine("else");
                last.Fila = i;
                last.Columna = j;
                update();
                boton.BackColor = Color.Green;
                moverState = true;
            }
            
            String info = "i: " + i + " j: " + j + " text: " + Juego.T.Matriz[i, j].ToString();
            Console.WriteLine(info);
        }

        private void mover(Coords origen,Coords destino)
        {
            Button aux = botones[origen.Fila, origen.Columna];
            //botones[origen.Fila, origen.Columna] = botones[destino.Fila, destino.Columna];
            tableLayoutPanelTablero.Controls.Remove(aux);
            tableLayoutPanelTablero.Controls.Add(botones[origen.Fila, origen.Columna], origen.Columna, origen.Fila);
            //botones[destino.Fila, destino.Columna] = aux;
            tableLayoutPanelTablero.Controls.Add(botones[destino.Fila, destino.Columna], destino.Columna, destino.Fila);
        }

        private void update()
        {
            for(int i=0;i<Juego.T.N;i++)
            {
                for (int j = 0; j < Juego.T.M; j++)
                {
                    botones[i, j].BackColor = Color.Empty;
                    botones[i, j].Text = Juego.T.Matriz[i,j].ToString();
                    //tableLayoutPanelTablero.Controls.
                }
            }
            this.Refresh();
        }

        private void eliminar()
        {
            bool flag = true;
            while (flag)
            {
                flag = Juego.eliminar();
                update();

                Thread.Sleep(1000);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            previous.Show();
        }

        private void VistaTablero_FormClosing(object sender, FormClosingEventArgs e)
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
