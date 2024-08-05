using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Eleccion_de_consumo : Form
    {
        public Eleccion_de_consumo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Eleccion_de_consumo_Load(object sender, EventArgs e)
        {
            Conexion_BaseDatos ConexionBDeleccion = new Conexion_BaseDatos();
            double preciooo = 0;

            ConexionBDeleccion.EstablecerConexion();
            string consulta = "SELECT precio FROM bebidas WHERE nombre = 'cafe americano';";
            MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
            comaCafeAmericano.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = comaCafeAmericano.ExecuteReader();
            if (reader.Read())
            {
                preciooo = reader.GetDouble(0);
                precio1.Text = preciooo.ToString();

            }
            reader.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            F_HOME home = new F_HOME(); 
            home.Show();
            this.Close();   

        }
    }
}
