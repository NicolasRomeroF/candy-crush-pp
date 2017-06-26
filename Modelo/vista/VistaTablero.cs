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
        private CCService.CandyCrushServiceClient ccs = new CCService.CandyCrushServiceClient();

        public VistaTablero(Juego j)
        {
            InitializeComponent();
            Juego = j;
            generarBotones();
            ganar += mostrarGanar;
            perder += mostrarPerder;
            FormClosing += VistaTablero_FormClosing;
            labelUsuarioShow.Text = Juego.getNombre();
            labelPuntajeShow.Text = Juego.getPuntaje()+"";
            labelMovimientosShow.Text = Juego.getMovimientos() + "";
            labelSeleccionar.Text = "Seleccione dulce a mover";
        }

        private void puntajeSuperado(int scoreAnterior)
        {
            MessageBox.Show("Has superado tu puntaje anterior ("+scoreAnterior+")");
        }

        private void mostrarPerder(Juego game, EventArgs e)
        {
            if (Juego.checkPerder())
            {
                MessageBox.Show("Te has quedado sin movimientos, has perdido.");
                this.Dispose();
                previous.Show();
            }
        }

        private void mostrarGanar(Juego game, EventArgs e)
        {
            if (Juego.checkGanar())
            {
                MessageBox.Show("Has ganado "+game.J.Nombre+"!\n"+"Tu puntaje final fue: "+game.getPuntaje());
                this.Dispose();
                previous.Show();
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
                    botones[i, j].Text = Juego.T.Matriz[i, j].Recubrimiento+"";
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
                bool intento = Juego.tryMover(last, act);
                update();
                Console.WriteLine(intento);

                pictureBoxCargando.Visible = true;
                Refresh();
                if (intento)
                {
                    Console.WriteLine("Se movio");
                    
                    eliminar();
                    
                    ccs.setScoreAsync(Juego.getPuntaje(), Juego.getNombre());
                }
                pictureBoxCargando.Visible = false;
                Refresh();
                ganar(Juego, e);
                perder(Juego, e);
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
            
            String info = "i: " + i + " j: " + j + " text: " + Juego.T.Matriz[i, j].ToString();
            Console.WriteLine(info);
        }


        private void update()
        {
            for(int i=0;i<Juego.T.N;i++)
            {
                for (int j = 0; j < Juego.T.M; j++)
                {
                    botones[i, j].Text = Juego.T.Matriz[i, j].Recubrimiento + "";
                    botones[i, j].Image = getImagen(i, j);

                }
            }
            labelMovimientosShow.Text = Juego.getMovimientos() + "";
            labelPuntajeShow.Text = Juego.getPuntaje() + "";
            this.Refresh();
        }

        private void eliminar()
        {
            bool flag = true;
            while (flag)
            {
                Thread.Sleep(1000);
                flag = Juego.eliminar();
                update(); 

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

        private Color getColorRecubrimiento(int i,int j)
        {
            int rec = Juego.T.Matriz[i, j].Recubrimiento;
            switch(rec)
            {
                case 0:
                    return Color.Blue;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Red;
                default:
                    return Color.Blue;
            }
        }

        private Bitmap getImagen(int i, int j)
        {
            int color = Juego.T.Matriz[i, j].Color;
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

        private void buttonPrintTablero_Click(object sender, EventArgs e)
        {
            Juego.T.printTablero();
        }
    }


}
