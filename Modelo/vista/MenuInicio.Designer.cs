namespace CC.vista
{
    partial class MenuInicio
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
            this.buttonJugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(100, 189);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 23);
            this.buttonJugar.TabIndex = 0;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonJugar);
            this.Name = "MenuInicio";
            this.Text = "MenuInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonJugar;
    }
}