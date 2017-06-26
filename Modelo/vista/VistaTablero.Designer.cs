namespace CC.vista
{
    partial class VistaTablero
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.labelMovimientos = new System.Windows.Forms.Label();
            this.labelPuntajeShow = new System.Windows.Forms.Label();
            this.labelUsuarioShow = new System.Windows.Forms.Label();
            this.labelMovimientosShow = new System.Windows.Forms.Label();
            this.pictureBoxCargando = new System.Windows.Forms.PictureBox();
            this.labelSeleccionar = new System.Windows.Forms.Label();
            this.buttonPrintTablero = new System.Windows.Forms.Button();
            this.panelTablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTablero
            // 
            this.panelTablero.AutoScroll = true;
            this.panelTablero.Controls.Add(this.tableLayoutPanelTablero);
            this.panelTablero.Location = new System.Drawing.Point(162, 12);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(875, 657);
            this.panelTablero.TabIndex = 0;
            // 
            // tableLayoutPanelTablero
            // 
            this.tableLayoutPanelTablero.ColumnCount = 1;
            this.tableLayoutPanelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTablero.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTablero.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTablero.Name = "tableLayoutPanelTablero";
            this.tableLayoutPanelTablero.RowCount = 1;
            this.tableLayoutPanelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTablero.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelTablero.TabIndex = 0;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 646);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 1;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(1043, 35);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 8;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Location = new System.Drawing.Point(1043, 62);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(46, 13);
            this.labelPuntaje.TabIndex = 9;
            this.labelPuntaje.Text = "Puntaje:";
            // 
            // labelMovimientos
            // 
            this.labelMovimientos.AutoSize = true;
            this.labelMovimientos.Location = new System.Drawing.Point(1043, 88);
            this.labelMovimientos.Name = "labelMovimientos";
            this.labelMovimientos.Size = new System.Drawing.Size(115, 13);
            this.labelMovimientos.TabIndex = 10;
            this.labelMovimientos.Text = "Movimientos restantes:";
            // 
            // labelPuntajeShow
            // 
            this.labelPuntajeShow.AutoSize = true;
            this.labelPuntajeShow.Location = new System.Drawing.Point(1095, 62);
            this.labelPuntajeShow.Name = "labelPuntajeShow";
            this.labelPuntajeShow.Size = new System.Drawing.Size(13, 13);
            this.labelPuntajeShow.TabIndex = 11;
            this.labelPuntajeShow.Text = "0";
            // 
            // labelUsuarioShow
            // 
            this.labelUsuarioShow.AutoSize = true;
            this.labelUsuarioShow.Location = new System.Drawing.Point(1095, 35);
            this.labelUsuarioShow.Name = "labelUsuarioShow";
            this.labelUsuarioShow.Size = new System.Drawing.Size(39, 13);
            this.labelUsuarioShow.TabIndex = 12;
            this.labelUsuarioShow.Text = "default";
            // 
            // labelMovimientosShow
            // 
            this.labelMovimientosShow.AutoSize = true;
            this.labelMovimientosShow.Location = new System.Drawing.Point(1164, 88);
            this.labelMovimientosShow.Name = "labelMovimientosShow";
            this.labelMovimientosShow.Size = new System.Drawing.Size(13, 13);
            this.labelMovimientosShow.TabIndex = 13;
            this.labelMovimientosShow.Text = "0";
            // 
            // pictureBoxCargando
            // 
            this.pictureBoxCargando.Image = global::CC.Properties.Resources.loading;
            this.pictureBoxCargando.Location = new System.Drawing.Point(36, 151);
            this.pictureBoxCargando.Name = "pictureBoxCargando";
            this.pictureBoxCargando.Size = new System.Drawing.Size(84, 77);
            this.pictureBoxCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCargando.TabIndex = 14;
            this.pictureBoxCargando.TabStop = false;
            this.pictureBoxCargando.Visible = false;
            // 
            // labelSeleccionar
            // 
            this.labelSeleccionar.AutoSize = true;
            this.labelSeleccionar.Location = new System.Drawing.Point(7, 35);
            this.labelSeleccionar.Name = "labelSeleccionar";
            this.labelSeleccionar.Size = new System.Drawing.Size(104, 13);
            this.labelSeleccionar.TabIndex = 15;
            this.labelSeleccionar.Text = "Mensaje seleccionar";
            // 
            // buttonPrintTablero
            // 
            this.buttonPrintTablero.Location = new System.Drawing.Point(1058, 633);
            this.buttonPrintTablero.Name = "buttonPrintTablero";
            this.buttonPrintTablero.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintTablero.TabIndex = 16;
            this.buttonPrintTablero.Text = "printTablero";
            this.buttonPrintTablero.UseVisualStyleBackColor = true;
            this.buttonPrintTablero.Click += new System.EventHandler(this.buttonPrintTablero_Click);
            // 
            // VistaTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonPrintTablero);
            this.Controls.Add(this.labelSeleccionar);
            this.Controls.Add(this.pictureBoxCargando);
            this.Controls.Add(this.labelMovimientosShow);
            this.Controls.Add(this.labelUsuarioShow);
            this.Controls.Add(this.labelPuntajeShow);
            this.Controls.Add(this.labelMovimientos);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.panelTablero);
            this.Name = "VistaTablero";
            this.Text = "CC";
            this.panelTablero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTablero;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.Label labelMovimientos;
        private System.Windows.Forms.Label labelPuntajeShow;
        private System.Windows.Forms.Label labelUsuarioShow;
        private System.Windows.Forms.Label labelMovimientosShow;
        private System.Windows.Forms.PictureBox pictureBoxCargando;
        private System.Windows.Forms.Label labelSeleccionar;
        private System.Windows.Forms.Button buttonPrintTablero;
    }
}