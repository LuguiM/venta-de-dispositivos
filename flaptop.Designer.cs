﻿
namespace venta_de_dispositivos
{
    partial class flaptop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcaracteristicas = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btbcomprar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btbcancelar = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btbbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispositivos:Laptop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto seleccionado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caracteristicas ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 294);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(9, 128);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(149, 20);
            this.txtproducto.TabIndex = 5;
            // 
            // txtcaracteristicas
            // 
            this.txtcaracteristicas.Location = new System.Drawing.Point(12, 186);
            this.txtcaracteristicas.Multiline = true;
            this.txtcaracteristicas.Name = "txtcaracteristicas";
            this.txtcaracteristicas.Size = new System.Drawing.Size(146, 113);
            this.txtcaracteristicas.TabIndex = 6;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(12, 341);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 7;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(474, 410);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(143, 20);
            this.txtbuscar.TabIndex = 8;
            // 
            // btbcomprar
            // 
            this.btbcomprar.BackColor = System.Drawing.Color.White;
            this.btbcomprar.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcomprar.ForeColor = System.Drawing.Color.Crimson;
            this.btbcomprar.Location = new System.Drawing.Point(227, 440);
            this.btbcomprar.Name = "btbcomprar";
            this.btbcomprar.Size = new System.Drawing.Size(87, 30);
            this.btbcomprar.TabIndex = 9;
            this.btbcomprar.Text = "Comprar";
            this.btbcomprar.UseVisualStyleBackColor = false;
            this.btbcomprar.Click += new System.EventHandler(this.btbcomprar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox1.Location = new System.Drawing.Point(29, 457);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "si";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btbcancelar
            // 
            this.btbcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btbcancelar.Font = new System.Drawing.Font("Matura MT Script Capitals", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbcancelar.ForeColor = System.Drawing.Color.Crimson;
            this.btbcancelar.Location = new System.Drawing.Point(320, 440);
            this.btbcancelar.Name = "btbcancelar";
            this.btbcancelar.Size = new System.Drawing.Size(75, 30);
            this.btbcancelar.TabIndex = 11;
            this.btbcancelar.Text = "Cancelar ";
            this.btbcancelar.UseVisualStyleBackColor = false;
            this.btbcancelar.Click += new System.EventHandler(this.btbcancelar_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox2.Location = new System.Drawing.Point(77, 457);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 29);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "no";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // btbbuscar
            // 
            this.btbbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btbbuscar.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbbuscar.ForeColor = System.Drawing.Color.Crimson;
            this.btbbuscar.Location = new System.Drawing.Point(623, 400);
            this.btbbuscar.Name = "btbbuscar";
            this.btbbuscar.Size = new System.Drawing.Size(141, 40);
            this.btbbuscar.TabIndex = 13;
            this.btbbuscar.Text = "Buscar producto ";
            this.btbbuscar.UseVisualStyleBackColor = false;
            this.btbbuscar.Click += new System.EventHandler(this.btbbuscar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(13, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 59);
            this.label5.TabIndex = 14;
            this.label5.Text = "¿Desea servicio adomicilio? ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(556, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Disponibles";
            // 
            // flaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::venta_de_dispositivos.Properties.Resources.MicrosoftTeams_image__9_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btbbuscar);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btbcancelar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btbcomprar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcaracteristicas);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "flaptop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flaptop";
            this.Load += new System.EventHandler(this.flaptop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcaracteristicas;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btbcomprar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btbcancelar;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btbbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}