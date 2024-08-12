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
    
    public partial class dinero_cambio : Form
    {
        public double dinero_a_pagar {  get; set; } 

        bool pagado = false;
        public dinero_cambio()
        {
            InitializeComponent();
        }

        private void dinero_cambio_Load(object sender, EventArgs e)
        {
            dinero_lb.Text = "$" + dinero_a_pagar.ToString(); 

        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("TIENES QUE INGRESAR UN VALOR");
            }
            else { 
            string texboxtex = textBox1.Text;
            double cantidad_ingresada = double.Parse(texboxtex);
            
            if(cantidad_ingresada < dinero_a_pagar)
                {
                    MessageBox.Show("EL CLIENTE NO COMPLETA");
                }
                else
                {
                    double cambio = cantidad_ingresada - dinero_a_pagar;

                    lb_cambio.Text = "$" + cambio.ToString();
                    pagado = true;
                    
                    
                    
                    
                }
             
           
            }
        }

        private void dinero_cambio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(pagado == false) { 
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Cancelar el cierre del formulario
                e.Cancel = true;

               
              
            }
            }

        }
    }
}
