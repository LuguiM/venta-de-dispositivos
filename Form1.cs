﻿using System;
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


namespace venta_de_dispositivos
{
    public partial class Form1 : Form
    {
        public Form1()
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
            string cadena = "data source = ServidorSQL; initial catalog = BaseDatos; user id = Usuario; password = Contraseña";

     public SqlConnection Conectarbd = new SqlConnection();

        public conexionbd()
        {
            Conectarbd.Con nectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Message("error al abrir BD ");
            }
        }
        public void cerrar()
        {
            Conectarbd.Close();
        }
        conexionbd conexion = new conexionbd();
        conexion.abrir();
private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


