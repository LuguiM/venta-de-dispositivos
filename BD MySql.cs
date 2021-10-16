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

    public partial class BD_MySql : Form
    {
        public string cadena_conexion = "Database=agenda;Data Source=localhost;User Id=admin;Password=admin";

        public BD_MySql()
        {
            InitializeComponent();
        }

        private void BD_MySql_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            try
            {
                string consulta = "select*from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion); string myInsertQuery = "INSERT INTO contactos(nombre,clave,nivel) Values(?nombre,?clave,?nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 40).Value = txtusuario.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 45).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 4).Value = lstnivel.Text;

                myCommand.Connection = myConnection;

                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from contactos";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta,conexion);
                System.Data.DataSet ds = new System.Data.DataSet(); da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }

            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bnuevo.Focus();

        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = "Database=agenda;Data Source=localhost;User Id=admin;Password=admin";
                    MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                    string myInsertQuery = "UPDATE agenda SET nombre=?nombre, telefono=?telefono Where id=" + txtid.Text + "";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 45).Value = nombre.Text;
                    //myCommand.Parameters.Add("?telefono", MySqlDbType.VarChar, 45).Value = telefono.Text;
                    myCommand.Connection = myConnection;

                    myConnection.Open();

                    myCommand.ExecuteNonQuery();

                    myCommand.Connection.Close();

                  
                   MessageBox.Show ("Actualizado Con Éxito");
                   
                    string cad = "Database=agenda;Data Source=localhost;User Id=admin;Password=admin";
                    string query = "select * from agenda";
                    MySqlConnection cnn = new MySqlConnection(cad);
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "agenda");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "agenda";
                }

            }
            catch (System.Exception)
            {
               
                MessageBox.Show( "Hay Campos Vacíos");
             
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";

                if (myConnectionString == "")
                {
                    myConnectionString = "Database=agenda;Data Source=localhost;User Id=admin;Password=admin";
                }

                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string mySelectQuery = "SELECT * From agenda Where codigo=" + txtid.Text + "";
                MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);

                myConnection.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtusuario.Text = (myReader.GetString(1));
                    lstnivel.Text = (myReader.GetString(2));
                }
                else
                {
                    
                    MessageBox.Show( "El Registro No Existe");
                   
                }
                myReader.Close();
                myConnection.Close();
            }
            catch (System.Exception)
            {
               
                MessageBox.Show( "Escribe el ID");
               
            }
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnectionString = "";
                if (myConnectionString == "")
                {
                    myConnectionString = "Database=agenda;Data Source=localhost;UserId=admin;Password=admin";
                }
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                string myInsertQuery = "DELETE FROM agenda Where id=" + txtid.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                
                MessageBox.Show( "Eliminado Con Éxito");
              
                string cad = "Database=agenda;Data Source=localhost;User Id=admin;Password=admin";
                string query = "select * from agenda";
                MySqlConnection cnn = new MySqlConnection(cad);
                MySqlDataAdapter da = new MySqlDataAdapter(query,cnn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (System.Exception)
            {
                
                MessageBox.Show("Hay Campos Vacíos") ;
                
            }
        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            MySqlConnection first = new MySqlConnection(cadena_conexion);

            string MoveFirst = this.cadena_conexion;
        }
    }
}
