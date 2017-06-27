namespace CC.vista
{
    partial class CrearTablero
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
            this.panelTablero = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTablero = new System.Windows.Forms.TableLayoutPanel();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.buttonJugar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTablero
            // 
            this.panelTablero.Controls.Add(this.tableLayoutPanelTablero);
            this.panelTablero.Location = new System.Drawing.Point(93, 26);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(767, 590);
            this.panelTablero.TabIndex = 0;
            // 
            // tableLayoutPanelTablero
            // 
            this.tableLayoutPanelTablero.ColumnCount = 1;
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTablero.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTablero.Name = "tableLayoutPanelTablero";
            this.tableLayoutPanelTablero.RowCount = 1;
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTablero.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelTablero.TabIndex = 0;
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Location = new System.Drawing.Point(12, 9);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(104, 13);
            this.labelSeleccionar.TabIndex = 16;
            this.labelSeleccionar.Text = "Mensaje seleccionar";
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(885, 556);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 23);
            this.buttonJugar.TabIndex = 17;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 592);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 18;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(885, 585);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // CrearTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(972, 627);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.panelTablero);
            this.Name = "CrearTablero";
            this.Text = "CC";
            this.panelTablero.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTablero;
        private System.Windows.Forms.Label labelSeleccionar;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonGuardar;
    }
}