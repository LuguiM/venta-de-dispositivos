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
    public partial class ayuda: Form
    {
        public ayuda()
        {
            InitializeComponent();
        }

       

        private void bayuda_Click(object sender, EventArgs e)
        {
            
            txtcontenedor.Text = System.IO.File.ReadAllText("C:\\sistema\\sistema.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
