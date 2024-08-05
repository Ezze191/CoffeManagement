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
            //busca los precios y los actualiza depende a la base de datos
            Cprecios precios = new Cprecios();
            precios.establecer_precios();

            double p_cafe_americano = precios.p_cafe_amerciano;
            double p_capuccino = precios.p_capuccino;
            
            precio0.Text = p_cafe_americano.ToString();
            precio1.Text = p_capuccino.ToString();
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
