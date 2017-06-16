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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumnas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCantFilas
            // 
            this.labelCantFilas.AutoSize = true;
            this.labelCantFilas.Location = new System.Drawing.Point(29, 27);
            this.labelCantFilas.Name = "labelCantFilas";
            this.labelCantFilas.Size = new System.Drawing.Size(85, 13);
            this.labelCantFilas.TabIndex = 1;
            this.labelCantFilas.Text = "Cantidad de filas";
            // 
            // labelCantColumnas
            // 
            this.labelCantColumnas.AutoSize = true;
            this.labelCantColumnas.Location = new System.Drawing.Point(29, 72);
            this.labelCantColumnas.Name = "labelCantColumnas";
            this.labelCantColumnas.Size = new System.Drawing.Size(112, 13);
            this.labelCantColumnas.TabIndex = 3;
            this.labelCantColumnas.Text = "Cantidad de columnas";
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Location = new System.Drawing.Point(29, 115);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(51, 13);
            this.labelDificultad.TabIndex = 5;
            this.labelDificultad.Text = "Dificultad";
            // 
            // buttonJugar
            // 
            this.buttonJugar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonJugar.Location = new System.Drawing.Point(94, 204);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 23);
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
            this.comboBoxDificultad.Location = new System.Drawing.Point(29, 132);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDificultad.TabIndex = 7;
            this.comboBoxDificultad.Text = "Elegir...";
            // 
            // numericUpDownFilas
            // 
            this.numericUpDownFilas.Location = new System.Drawing.Point(32, 44);
            this.numericUpDownFilas.Name = "numericUpDownFilas";
            this.numericUpDownFilas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFilas.TabIndex = 8;
            // 
            // numericUpDownColumnas
            // 
            this.numericUpDownColumnas.Location = new System.Drawing.Point(32, 92);
            this.numericUpDownColumnas.Name = "numericUpDownColumnas";
            this.numericUpDownColumnas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownColumnas.TabIndex = 9;
            // 
            // OpcionesJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numericUpDownColumnas);
            this.Controls.Add(this.numericUpDownFilas);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.labelCantColumnas);
            this.Controls.Add(this.labelCantFilas);
            this.Name = "OpcionesJuego";
            this.Text = "OpcionesJuego";
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
    }
}