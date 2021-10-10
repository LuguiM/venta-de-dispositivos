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

namespace venta_de_dispositivos
{
    public partial class fusuario : Form
    {
        public OleDbConnection mi conexion;

            public string usuario_modificar;
        private OleDbConnection myCon;

        public fusuario()
        {
            myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\sistema.accdb "); 
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            Istniel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand guardar = newOleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;
                guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave],[nivel]) Values('" + txtusuario.Text.ToString() + "','" + txtclave.Text.ToString() + "','" + lstnivel.Text.ToString() + "')";


                guardar.ExecuteNonQuery();
                miconexion.Close();

                bnuevo.Visible = true;
                bguardar.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();
                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
                this.tusuarioBindingSource.MoveLast();
            }
            catch (Exception err)


                MessageBox.Show(err.Message);
            }

            }

        private void button7_Click(object sender, EventArgs e)
        {

            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true; 
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;
            usuario_modificar = txtusuario.Text.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;

                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                actualizar.CommandText = "UPDATE tusuario SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";


                actualizar.ExecuteNonQuery();
                miconexion.Close();

                bmodificar.Visible = true;
                bactualizar.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;

                MessageBox.Show("Usuario actualizado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            { 
                MessageBox.Show(err.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open(); 
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text; 

                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" + txtusuario.Text.ToString() + "'";
                
                eliminar.ExecuteNonQuery();
                this.tusuarioBindingSource.MoveNext(); 
                miconexion.Close();
            }
    }
