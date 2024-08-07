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
        public string totaltxt { get; set; }

        public double total { get; set; }

        

        Cprecios precios = new Cprecios();

        Sumatorio sumatorio = new Sumatorio();  



        public double dataCashBack { get; set; }

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

            if (datanombre != null || dataapellido != null) {
                
                lbnombrecompleto.Text = name + " " + lastname;
                lb_veces.Text = Veces.ToString();
                lb_cashback.Text = CB.ToString();
            }
                
            


            

            //busca los precios y los actualiza depende a la base de datos
           
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
            this.Hide();   

        }

        private void btmas1_Click(object sender, EventArgs e)
        {
           
        }

        private void btmas0_Click(object sender, EventArgs e)
        {
           sumatorio.sumar_uno_cafe();

            label3.Text = sumatorio.st_suma_cafe;

            double Cashsumar = precios.p_cafe_amerciano * sumatorio.suma_cafe;
           
            label14.Text = Cashsumar.ToString();    
        }

        private void btmenos0_Click(object sender, EventArgs e)
        {
            sumatorio.restar_uno_cafe();
            label3.Text = sumatorio.st_suma_cafe;

            double Cashrestar = precios.p_cafe_amerciano * sumatorio.suma_cafe;

            label14.Text = Cashrestar.ToString();   
            
        }
    }
}
