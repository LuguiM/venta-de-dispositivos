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
    public partial class fcel : Form
    {
        public string cadena_conexion = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";

        public fcel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fcel_Load(object sender, EventArgs e)
        {
            
        }

        private void btbbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";


                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string mySelectQuery = "SELECT * From producto_telefono Where id_producto=" + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);

                myConnection.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtproducto.Text = (myReader.GetString(1));
                    txtcaracteristicas.Text = (myReader.GetString(2));
                    txtprecio.Text = (myReader.GetString(3));


                }
                else
                {

                    MessageBox.Show("El Producto Ingresado No Esta Disponible");

                }
                myReader.Close();
                myConnection.Close();
            }
            catch (System.Exception)
            {

                MessageBox.Show("Escribe el Producto");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Esta Seguro de Comprar este Producto?", "COMPRA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MessageBox.Show("La Compra del Producto: " + txtproducto.Text + " se Realizo Correctamente", "COMPRA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
