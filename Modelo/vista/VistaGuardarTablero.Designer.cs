namespace CC.vista
{
    partial class VistaGuardarTablero
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
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNombreTablero = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(473, 30);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelNombreTablero
            // 
            this.labelNombreTablero.AutoSize = true;
            this.labelNombreTablero.Location = new System.Drawing.Point(35, 13);
            this.labelNombreTablero.Name = "labelNombreTablero";
            this.labelNombreTablero.Size = new System.Drawing.Size(99, 13);
            this.labelNombreTablero.TabIndex = 2;
            this.labelNombreTablero.Text = "Nombre del tablero:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(38, 32);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(429, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // VistaGuardarTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 64);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombreTablero);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "VistaGuardarTablero";
            this.Text = "CC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombreTablero;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}