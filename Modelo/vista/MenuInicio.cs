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
            CCService.CandyCrushServiceClient ccs = new CCService.CandyCrushServiceClient();
            String user = textBoxUsuario.Text;
            String pass = textBoxContraseña.Text;
            
            if (!(string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContraseña.Text)))
            {
                bool login = ccs.login(user, pass);
                if (login)
                {
                    OpcionesJuego oj = new OpcionesJuego(user);
                    this.Hide();
                    oj.Show();
                    OpcionesJuego.previous = this;
                }
                else
                    MessageBox.Show("Usuario o contraseña incorrecta!");
            }
            else
                MessageBox.Show("Ingrese un nombre de usuario y contraseña valido.");


        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContraseña.Text)))
            {
                CCService.CandyCrushServiceClient ccs = new CCService.CandyCrushServiceClient();
                String user = textBoxUsuario.Text;
                String pass = textBoxContraseña.Text;
                bool register = ccs.register(user, pass);
                if(register)
                    MessageBox.Show("Usuario registrado correctemente, ahora puede ingresar.");
                else
                    MessageBox.Show("Nombre de usuario ya existente, registro fallido.");
            }
            else
                MessageBox.Show("Ingrese un nombre de usuario y contraseña valido.");
        }
    }
}
