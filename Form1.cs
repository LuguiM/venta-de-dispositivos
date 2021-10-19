using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql;
using MySql.Data.MySqlClient;


namespace venta_de_dispositivos
{
    public partial class flogin : Form
    {
        public String conexion_mysql = "Database=agenda;Data Source=localhost;User Id=admin;Password=admin";
        public flogin()
        {
            InitializeComponent();
        }


        private void blogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexion_mysql);
            con.Open();
            MySqlCommand log = new MySqlCommand("Select nombre,clave from contactos where nombre='" + textBox1.Text + "' and clave='"+textBox2.Text + "' ", con);
            MySqlDataReader dtr = log.ExecuteReader();

            if(dtr.HasRows)
            {
                MessageBox.Show("bienvenido al sistema " + textBox1.Text);
                fventas fm = new fventas();
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Ha ocurrido un Error"); 
                return;
            }
        }
    }
}


