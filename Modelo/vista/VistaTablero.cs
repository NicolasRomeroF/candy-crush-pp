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
    

    public partial class VistaTablero : Form
    {
        public Juego J { get; private set; }
        public Button[,] botones { get; set; }
        private bool moverState = false;
        private Coords last;
        public VistaTablero(Juego j)
        {
            InitializeComponent();
            J = j;
            generarBotones();
        }

        private void generarBotones()
        {
            Tablero t = J.T;
            botones = new Button[t.N, t.M];
            int i, j;
            this.tableLayoutPanelTablero.RowCount = J.T.N;
            this.tableLayoutPanelTablero.ColumnCount = J.T.M;
            this.tableLayoutPanelTablero.Width = 40 * J.T.M;
            this.tableLayoutPanelTablero.Height = 40 * J.T.N;
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
                    botones[i, j].Text = J.T.Matriz[i, j].ToString();
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
                bool intento = J.tryMover(last, act);
                Console.WriteLine(intento);

                if (intento)
                    mover(last,act);

                J.eliminar();
                
                moverState = false;

            }
            else
            {
                last.Fila = i;
                last.Columna = j;
                boton.BackColor = Color.Green;
                moverState = true;
            }
            update();
            String info = "i: " + i + " j: " + j + " text: " + J.T.Matriz[i, j].ToString();
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
            for(int i=0;i<J.T.N;i++)
            {
                for (int j = 0; j < J.T.M; j++)
                {
                    botones[i, j].BackColor = Color.Empty;
                    botones[i, j].Text = J.T.Matriz[i,j].ToString();
                    //tableLayoutPanelTablero.Controls.
                }
            }
        }

    }
}
