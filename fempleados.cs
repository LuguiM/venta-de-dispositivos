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
    public partial class fempleados : Form
    {
        public string cadena_conexion = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";

        public fempleados()
        {
            InitializeComponent();
        }

        private void fempleados_Load(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtdui.Enabled = false;
            txtnit.Enabled = false;
            txtcorreo.Enabled = false;
            txtpuesto.Enabled = false;
            txtsalario.Enabled = false;

            try
            {
                string consulta = "select*from empleados";
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

        private void btbbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";


                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string mySelectQuery = "SELECT * From empleados Where id_empleado=" + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);

                myConnection.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtnombre.Text = (myReader.GetString(1));
                    txtdui.Text = (myReader.GetString(2));
                    txtnit.Text = (myReader.GetString(3));
                    txtcorreo.Text = (myReader.GetString(4));
                    txtpuesto.Text = (myReader.GetString(5));
                    txtsalario.Text = (myReader.GetString(6));

                }
                else
                {

                    MessageBox.Show("El Empleado Ingresado No Se Encuentra");

                }
                myReader.Close();
                myConnection.Close();
            }
            catch (System.Exception)
            {

                MessageBox.Show("Escribe el nombre");

            }
        }

        private void btbmodificar_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtdui.Enabled = true;
            txtnit.Enabled = true;
            txtcorreo.Enabled = true;
            txtpuesto.Enabled = true;
            txtsalario.Enabled = true;

            txtnombre.Focus();
            btbmodificar.Visible = false;
            btbactualizar.Visible = true;

            


        }
        public string  usuario_modificar ;
        private void btbactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string nom = txtnombre.Text.ToString();
                string cla = txtdui.Text.ToString();
                string niv = txtnit.Text.ToString();
                string corre = txtcorreo.Text.ToString();
                string puest = txtpuesto.Text.ToString();
                string sala = txtsalario.Text.ToString();

                //string myInsertQuery = "UPDATE empleados SET(nombre,dui,nit,correo,puesto,salario) Values(?nombre,?dui,?nit,?correo,?puesto,?salario)";
                string myInsertQuery = "UPDATE empleados SET nombre = '" + nom + "',dui = '" + cla + "',nit = '" + niv + "',correo = '" + corre + "',puesto = '" + puest + "',salario = '" + sala + "' WHERE nombre = '" + usuario_modificar +"'";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 45).Value = txtnombre.Text;
               // myCommand.Parameters.Add("?dui", MySqlDbType.Int32, 15).Value = txtdui.Text;
                //myCommand.Parameters.Add("?nit", MySqlDbType.Int32, 25).Value = txtnit.Text;
               // myCommand.Parameters.Add("?correo", MySqlDbType.VarChar, 20).Value = txtcorreo.Text;
                //myCommand.Parameters.Add("?puesto", MySqlDbType.VarChar, 20).Value = txtpuesto.Text;
                //myCommand.Parameters.Add("?salario", MySqlDbType.Int32, 50).Value = txtsalario.Text;

                myCommand.Connection = myConnection;

                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario Modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from empleados";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet(); 
                da.Fill(ds, "empleados");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleados";
            }

            catch (MySqlException)
            {
                MessageBox.Show("Error al Modificar Usuarios", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btbmodificar.Visible = true;
            btbactualizar.Visible = false;

            txtnombre.Enabled = false;
            txtdui.Enabled = false;
            txtnit.Enabled = false;
            txtcorreo.Enabled = false;
            txtpuesto.Enabled = false;
            txtsalario.Enabled = false;
            btbmodificar.Focus();

        }

        private void btbeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";
                }
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "DELETE FROM empleados Where id_empleado=" + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();


                MessageBox.Show("Eliminado Con Éxito");

                string cad = "Database=proyecto_de_venta;Data Source=localhost;User Id=admin;Password=admin";
                string query = "select * from empleados";
                MySqlConnection cnn = new MySqlConnection(cad);
                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "empleados");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "empleados";
            }
            catch (System.Exception)
            {

                MessageBox.Show("Hay Campos Vacíos");

            }
        }

        private void btbsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
