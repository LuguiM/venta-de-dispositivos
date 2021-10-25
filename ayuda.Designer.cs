
namespace venta_de_dispositivos
{
    partial class ayuda
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
            this.txtcontenedor = new System.Windows.Forms.TextBox();
            this.bayuda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcontenedor
            // 
            this.txtcontenedor.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontenedor.Location = new System.Drawing.Point(30, 89);
            this.txtcontenedor.Multiline = true;
            this.txtcontenedor.Name = "txtcontenedor";
            this.txtcontenedor.Size = new System.Drawing.Size(358, 267);
            this.txtcontenedor.TabIndex = 0;
            // 
            // bayuda
            // 
            this.bayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bayuda.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayuda.ForeColor = System.Drawing.Color.DarkGreen;
            this.bayuda.Location = new System.Drawing.Point(30, 372);
            this.bayuda.Name = "bayuda";
            this.bayuda.Size = new System.Drawing.Size(154, 57);
            this.bayuda.TabIndex = 1;
            this.bayuda.Text = "Mostrar opciones de ayuda";
            this.bayuda.UseVisualStyleBackColor = false;
            this.bayuda.Click += new System.EventHandler(this.bayuda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "AYUDA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(234, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::venta_de_dispositivos.Properties.Resources.pc_fondo;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bayuda);
            this.Controls.Add(this.txtcontenedor);
            this.Name = "ayuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontenedor;
        private System.Windows.Forms.Button bayuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}