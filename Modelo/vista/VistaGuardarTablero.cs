using CC.modelo;
using System;
using System.IO;
using System.Windows.Forms;

namespace CC.vista
{
    public partial class VistaGuardarTablero : Form
    {
        private Tablero t;
        public VistaGuardarTablero(Tablero t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("Tableros");
            String nombre = textBoxNombre.Text;
            String path = @"Tableros\" + nombre;
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                if(File.Exists(path))
                {
                    MessageBox.Show("Ya existe un tablero con ese nombre, intente otra vez.");
                }
                else
                {
                    t.toArchivo(path);
                    t.printTablero();
                    this.Dispose();
                }
            }
            else
                MessageBox.Show("No se ingreso un nombre valido, intente nuevamente.");
        }
    }
}
