﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venta_de_dispositivos
{
    public partial class fventas : Form
    {
        public fventas()
        {
            InitializeComponent();
        }

        private void usuariosAccesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fusuario fm = new fusuario();
            fm.Show();
            
        }

        private void usuariosMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BD_MySql fm = new BD_MySql();
            fm.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            faccesorios fm = new faccesorios();
            fm.Show();
        }

        private void btbcel_Click(object sender, EventArgs e)
        {
            fcel fm = new fcel();
            fm.Show();
        }

        private void btbpc_Click(object sender, EventArgs e)
        {
            Fpc fm = new Fpc();
            fm.Show();
        }

        private void btblaptop_Click(object sender, EventArgs e)
        {
            flaptop fm = new flaptop();
            fm.Show();
        }
    }
}
