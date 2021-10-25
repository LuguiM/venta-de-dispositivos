using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace venta_de_dispositivos
{
    public partial class fconsulta : Form
    {
        public string cadena_conexion = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";
        public fconsulta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fconsulta_Load(object sender, EventArgs e)
        {
            try
            {
                string consulta = "select*from producto_pc";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "proyecto_de_venta");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "proyecto_de_venta";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
