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
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            OpcionesJuego oj = new OpcionesJuego();
            this.Hide();
            oj.ShowDialog();
            this.Close();
        }
    }
}
