namespace CC.vista
{
    partial class OpcionesJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCantFilas = new System.Windows.Forms.Label();
            this.labelCantColumnas = new System.Windows.Forms.Label();
            this.labelDificultad = new System.Windows.Forms.Label();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.numericUpDownFilas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumnas = new System.Windows.Forms.NumericUpDown();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.buttonCrearTablero = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCargarTablero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCantFilas
            // 
            this.labelCantFilas.AutoSize = true;
            this.labelCantFilas.Location = new System.Drawing.Point(76, 44);
            this.labelCantFilas.Name = "labelCantFilas";
            this.labelCantFilas.Size = new System.Drawing.Size(85, 13);
            this.labelCantFilas.TabIndex = 1;
            this.labelCantFilas.Text = "Cantidad de filas";
            // 
            // labelCantColumnas
            // 
            this.labelCantColumnas.AutoSize = true;
            this.labelCantColumnas.Location = new System.Drawing.Point(76, 83);
            this.labelCantColumnas.Name = "labelCantColumnas";
            this.labelCantColumnas.Size = new System.Drawing.Size(112, 13);
            this.labelCantColumnas.TabIndex = 3;
            this.labelCantColumnas.Text = "Cantidad de columnas";
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Location = new System.Drawing.Point(76, 122);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(51, 13);
            this.labelDificultad.TabIndex = 5;
            this.labelDificultad.Text = "Dificultad";
            // 
            // buttonJugar
            // 
            this.buttonJugar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonJugar.Location = new System.Drawing.Point(93, 165);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(91, 23);
            this.buttonJugar.TabIndex = 6;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(79, 138);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDificultad.TabIndex = 7;
            this.comboBoxDificultad.Text = "Elegir...";
            // 
            // numericUpDownFilas
            // 
            this.numericUpDownFilas.Location = new System.Drawing.Point(79, 60);
            this.numericUpDownFilas.Name = "numericUpDownFilas";
            this.numericUpDownFilas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFilas.TabIndex = 8;
            // 
            // numericUpDownColumnas
            // 
            this.numericUpDownColumnas.Location = new System.Drawing.Point(79, 99);
            this.numericUpDownColumnas.Name = "numericUpDownColumnas";
            this.numericUpDownColumnas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownColumnas.TabIndex = 9;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(13, 13);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(39, 13);
            this.labelUsuario.TabIndex = 10;
            this.labelUsuario.Text = "default";
            // 
            // buttonCrearTablero
            // 
            this.buttonCrearTablero.Location = new System.Drawing.Point(93, 194);
            this.buttonCrearTablero.Name = "buttonCrearTablero";
            this.buttonCrearTablero.Size = new System.Drawing.Size(91, 23);
            this.buttonCrearTablero.TabIndex = 11;
            this.buttonCrearTablero.Text = "Crear tablero";
            this.buttonCrearTablero.UseVisualStyleBackColor = true;
            this.buttonCrearTablero.Click += new System.EventHandler(this.buttonCrearTablero_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar sesion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCargarTablero
            // 
            this.buttonCargarTablero.Location = new System.Drawing.Point(93, 223);
            this.buttonCargarTablero.Name = "buttonCargarTablero";
            this.buttonCargarTablero.Size = new System.Drawing.Size(91, 23);
            this.buttonCargarTablero.TabIndex = 13;
            this.buttonCargarTablero.Text = "Cargar Tablero";
            this.buttonCargarTablero.UseVisualStyleBackColor = true;
            this.buttonCargarTablero.Click += new System.EventHandler(this.buttonCargarTablero_Click);
            // 
            // OpcionesJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.buttonCargarTablero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCrearTablero);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.numericUpDownColumnas);
            this.Controls.Add(this.numericUpDownFilas);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.labelCantColumnas);
            this.Controls.Add(this.labelCantFilas);
            this.Name = "OpcionesJuego";
            this.Text = "CC";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCantFilas;
        private System.Windows.Forms.Label labelCantColumnas;
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.NumericUpDown numericUpDownFilas;
        private System.Windows.Forms.NumericUpDown numericUpDownColumnas;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Button buttonCrearTablero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCargarTablero;
    }
}