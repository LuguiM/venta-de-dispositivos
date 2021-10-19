
namespace venta_de_dispositivos
{
    partial class fventas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosAccesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosAccesToolStripMenuItem,
            this.usuariosMySqlToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosAccesToolStripMenuItem
            // 
            this.usuariosAccesToolStripMenuItem.Name = "usuariosAccesToolStripMenuItem";
            this.usuariosAccesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.usuariosAccesToolStripMenuItem.Text = "Usuarios Acces";
            this.usuariosAccesToolStripMenuItem.Click += new System.EventHandler(this.usuariosAccesToolStripMenuItem_Click);
            // 
            // usuariosMySqlToolStripMenuItem
            // 
            this.usuariosMySqlToolStripMenuItem.Name = "usuariosMySqlToolStripMenuItem";
            this.usuariosMySqlToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.usuariosMySqlToolStripMenuItem.Text = "Usuarios MySql";
            this.usuariosMySqlToolStripMenuItem.Click += new System.EventHandler(this.usuariosMySqlToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // fventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::venta_de_dispositivos.Properties.Resources.fondoventa;
            this.ClientSize = new System.Drawing.Size(685, 416);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fventas";
            this.Text = "fventas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosAccesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}