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

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|login.accdb");

            string consulta = "select password,usuario from login where password = '" + textBox2.Text + "' and usuario = '" + textBox1.Text + "';";
            OleDbCommand comando = new OleDbCommand(consulta, conexion);
            OleDbDataReader leedb;
            leedb = comando.ExecuteReader();
            Boolean existereg = leedb.HasRows;
            if (existereg)
            {
                MessageBox.Show("bienvenido al sistema" + textBox1.Text);
                fventas f2 = new fventas();
                f2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecto trate de nuevo");
                return;
            }
            conexion.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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
                BD_MySql fm = new BD_MySql();
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


