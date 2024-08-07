using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Eleccion_de_consumo : Form
    {
        public string datanombre { get; set; }
        public string dataapellido { get; set; }    
        public int dataVecesVicitadas { get; set; }

        public double dataCashBack { get; set; }

        public double dinero_a_pagar = 0;
        public double sr_americano = 0;
        public double sr_capuccino = 0;
        public double sr_latte = 0;
        public double sr_esspreso = 0;
        public double sr_macciatto = 0;
        public double sr_moka = 0;

        

        Cprecios precios = new Cprecios();

        Sumatorio sumatorio = new Sumatorio();

        Sumatorio sumatorio_americano = new Sumatorio();
        Sumatorio sumatorio_capu = new Sumatorio();
        Sumatorio sumatorio_latte = new Sumatorio();
        Sumatorio sumatorio_esspreso = new Sumatorio();
        Sumatorio sumatorio_macciatto = new Sumatorio();
        Sumatorio sumatorio_moka = new Sumatorio();

        public void totalizar()
        {
            dinero_a_pagar = sr_americano + sr_capuccino + sr_latte + sr_esspreso + sr_macciatto + sr_moka;
            label14.Text = dinero_a_pagar.ToString();
        }




        public Eleccion_de_consumo()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Eleccion_de_consumo_Load(object sender, EventArgs e)
        {
            string name = datanombre;
            string lastname = dataapellido;
            int Veces = dataVecesVicitadas;
            double CB = dataCashBack;

            if (datanombre != null || dataapellido != null)
            {

                lbnombrecompleto.Text = name + " " + lastname;
                lb_veces.Text = Veces.ToString();
                lb_cashback.Text = CB.ToString();
            }

            //busca los precios y los actualiza depende a la base de datos
            precios.establecer_precios();
            precio0.Text = precios.p_cafe_amerciano.ToString();
            precio1.Text = precios.p_capuccino.ToString();
            precio2.Text = precios.p_latte_frio.ToString();
            precio3.Text = precios.p_esspreso.ToString();
            precio4.Text = precios.p_macciatto.ToString();
            precio5.Text = precios.p_moka.ToString();




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
          
        }

        private void btmas1_Click(object sender, EventArgs e)
        {
           
        }

        private void btmas0_Click(object sender, EventArgs e)
        {
          
        }

        private void btmenos0_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
