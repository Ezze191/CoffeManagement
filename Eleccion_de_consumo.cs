using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
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

        string description = "";
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
            if (datanombre == null || dataapellido == null)
            {
                
            }
            else
            {

                subir_user_base_de_datos subir_datos = new subir_user_base_de_datos();

                double porcentaje = (15 * dinero_a_pagar) / 100;

                subir_datos.consultar(datanombre, dataapellido, porcentaje, 1);

                subir_datos.subir_cash(datanombre, dataapellido);
                subir_datos.subir_veces(datanombre, dataapellido);

                ticket ver_ticket = new ticket();
                ver_ticket.data_description = description;
                ver_ticket.Show();
                

                
            }
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            F_HOME home = new F_HOME();
            home.Show();
            this.Hide();

        }

        private void btmas1_Click(object sender, EventArgs e)
        {
            sumatorio_capu.sumar_uno_cafe();
            label5.Text = sumatorio_capu.suma_cafe.ToString();

            sr_capuccino = precios.p_capuccino * sumatorio_capu.suma_cafe;

            description = description + Environment.NewLine + "1x  ---------------------- Capuccino ------------ " + precios.p_capuccino.ToString();

            totalizar();
        }

        private void btmas0_Click(object sender, EventArgs e)
        {
            sumatorio_americano.sumar_uno_cafe();

            label3.Text = sumatorio_americano.suma_cafe.ToString();

            sr_americano = precios.p_cafe_amerciano * sumatorio_americano.suma_cafe;

            description = description + Environment.NewLine + "1x  ---------------------- Cafe americano ------------ " + precios.p_cafe_amerciano.ToString();

            totalizar();
            
            

        }

        private void btmenos0_Click(object sender, EventArgs e)
        {

            sumatorio_americano.restar_uno_cafe();
            label3.Text = sumatorio_americano.suma_cafe.ToString();

            sr_americano = precios.p_cafe_amerciano * sumatorio_americano.suma_cafe;

            
            totalizar();
        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btmenos1_Click(object sender, EventArgs e)
        {
            sumatorio_capu.restar_uno_cafe();
            label5.Text = sumatorio_capu.suma_cafe.ToString();

            sr_capuccino = precios.p_capuccino * sumatorio_capu.suma_cafe;

          
            totalizar();
        }

        private void btmenos2_Click(object sender, EventArgs e)
        {
            sumatorio_latte.restar_uno_cafe();
            label6.Text = sumatorio_latte.suma_cafe.ToString();

            sr_latte = precios.p_latte_frio * sumatorio_latte.suma_cafe;

           
            totalizar();
        }

        private void btmas2_Click(object sender, EventArgs e)
        {
            sumatorio_latte.sumar_uno_cafe();
            label6.Text = sumatorio_latte.suma_cafe.ToString();

            sr_latte = precios.p_latte_frio * sumatorio_latte.suma_cafe;

          

            totalizar();
        }

        private void btmenos3_Click(object sender, EventArgs e)
        {
            sumatorio_esspreso.restar_uno_cafe();
            label7.Text = sumatorio_esspreso.suma_cafe.ToString();

            sr_esspreso = precios.p_esspreso * sumatorio_esspreso.suma_cafe;

            
            totalizar();
        }

        private void btmas3_Click(object sender, EventArgs e)
        {
            sumatorio_esspreso.sumar_uno_cafe();
            label7.Text = sumatorio_esspreso.suma_cafe.ToString();

            sr_esspreso = precios.p_esspreso * sumatorio_esspreso.suma_cafe;

           

            totalizar();
        }

        private void btmenos4_Click(object sender, EventArgs e)
        {
            sumatorio_macciatto.restar_uno_cafe();
            label8.Text = sumatorio_macciatto.suma_cafe.ToString();

            sr_macciatto = precios.p_macciatto * sumatorio_macciatto.suma_cafe;

           

            totalizar();
        }

        private void btmas4_Click(object sender, EventArgs e)
        {
            sumatorio_macciatto.sumar_uno_cafe();
            label8.Text = sumatorio_macciatto.suma_cafe.ToString();

            sr_macciatto = precios.p_macciatto * sumatorio_macciatto.suma_cafe;

            

            totalizar();
        }

        private void btmenos5_Click(object sender, EventArgs e)
        {
            sumatorio_moka.restar_uno_cafe();
            label99.Text = sumatorio_moka.suma_cafe.ToString();

            sr_macciatto = precios.p_moka * sumatorio_moka.suma_cafe;

           
            totalizar();
        }

        private void btmas5_Click(object sender, EventArgs e)
        {
            sumatorio_moka.sumar_uno_cafe();
            label99.Text = sumatorio_moka.suma_cafe.ToString();

            sr_macciatto = precios.p_moka * sumatorio_moka.suma_cafe;

            
            totalizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(dataCashBack >= dinero_a_pagar)
            {
                subir_user_base_de_datos subir = new subir_user_base_de_datos();

                double resatante = dataCashBack - dinero_a_pagar;
                subir.consultar(datanombre, dataapellido , 0 , 1);
                subir.subir_veces(datanombre , dataapellido);
                subir.subir_restante_cash_back(datanombre, dataapellido, resatante);

                MessageBox.Show("pago con exito");


            }
            else
            {
                MessageBox.Show("no cuentas con el suficiente dinero de cashback");
            }
        }
    }
    }

