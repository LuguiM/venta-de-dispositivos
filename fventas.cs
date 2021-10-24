using System;
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

        }
    }
}
