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
            this.panelTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTablero
            // 
            this.panelTablero.AutoScroll = true;
            this.panelTablero.Controls.Add(this.tableLayoutPanelTablero);
            this.panelTablero.Location = new System.Drawing.Point(162, 12);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(767, 590);
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
            // VistaTablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 614);
            this.Controls.Add(this.panelTablero);
            this.Name = "VistaTablero";
            this.Text = "VistaTablero";
            this.panelTablero.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTablero;
    }
}