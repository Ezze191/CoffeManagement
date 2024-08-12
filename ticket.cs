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
    public partial class ticket : Form
    {
        public string[] ticket_results = new string[6];
        public string data_total {  get; set; }
        
        public string data_name { get; set; }

        public string data_apellido { get; set; }

        public string metodo_de_pago = "Dinero del cliente";

        DateTime fecha_now =  DateTime.Now;


        public ticket()
        {
            InitializeComponent();
        }

        private void ticket_Load(object sender, EventArgs e)
        {
            ticket_label_fecha.Text = fecha_now.ToString("dd/MM/yyyy HH:mm:ss");
            ticket_ventatotal.Text = "$ " + data_total.ToString();
            if (data_name == null || data_apellido == null)
            {
                lb_ticket_name.Text = "**********";
                ticket_label_lastname.Text = "**********";
            }
            else
            {
                lb_ticket_name.Text = data_name;
                ticket_label_lastname.Text = data_apellido;
                
            }
            string[] codigo = new string[14];
            llenar_codigo();
            void llenar_codigo()
            {
                string[] opciones = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                Random ra = new Random();
                
                for(int i = 0; i < 14; i++)
                {
                    codigo[i] = opciones[ra.Next(0, opciones.Length)];
                    
                }
            }

            lb_codigo_barras.Text = codigo[0] + " " + codigo[1] + " " + codigo[2] + " " + codigo[3] + " " + codigo[4] + " " +
            codigo[5] + " " + codigo[6] + " " + codigo[7] + " " + codigo[8] + " " + codigo[9] + " " + codigo[10] + " " + codigo[11] + " " + codigo[12] + " " + codigo[13];

            lb_metododepago.Text = metodo_de_pago;

            //fitrar el array para ver cual esta vacio y filtrarlo para que solamte se agregen los que estan llenos
            var Filter_names = ticket_results.Where(n => n != null).ToArray();
            listBox1.Items.AddRange(Filter_names);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ticket_label_lastname_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lb_ticket_name_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("COMPRA REALIZADA CON EXITO");
        }
    }
}
