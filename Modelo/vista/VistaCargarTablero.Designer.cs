namespace CC.vista
{
    partial class VistaCargarTablero
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
            this.listBoxTableros = new System.Windows.Forms.ListBox();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTableros
            // 
            this.listBoxTableros.FormattingEnabled = true;
            this.listBoxTableros.Location = new System.Drawing.Point(60, 38);
            this.listBoxTableros.Name = "listBoxTableros";
            this.listBoxTableros.Size = new System.Drawing.Size(154, 160);
            this.listBoxTableros.TabIndex = 0;
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(98, 201);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 23);
            this.buttonJugar.TabIndex = 1;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(98, 230);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Location = new System.Drawing.Point(12, 9);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(113, 13);
            this.labelSeleccionar.TabIndex = 3;
            this.labelSeleccionar.Text = "Seleccione un tablero:";
            // 
            // VistaCargarTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.listBoxTableros);
            this.Name = "VistaCargarTablero";
            this.Text = "CC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTableros;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelSeleccionar;
    }
}