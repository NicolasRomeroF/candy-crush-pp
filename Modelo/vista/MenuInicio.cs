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
    public partial class MenuInicio : Form
    {
        

        public MenuInicio()
        {
            InitializeComponent();
            textBoxContraseña.PasswordChar = '*';
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            OpcionesJuego oj = new OpcionesJuego();
            this.Hide();
            oj.Show();
            OpcionesJuego.previous = this;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            String user = textBoxUsuario.Text;
            String pass = textBoxContraseña.Text;
            bool login = Login.login(user,pass);
            if (login)
                buttonJugar_Click(null,null);
            else
                MessageBox.Show("Usuario o contraseña incorrecta!");
        }
    }
}
