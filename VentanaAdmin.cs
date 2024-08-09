using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int opcion = comboBox1.SelectedIndex;
            
            double precio = Convert.ToDouble(textBox1.Text);
            switch (opcion)
            {
              case 0:
                    //programar precio americano
                    actualizarPrecio actualizarPrecio = new actualizarPrecio();
                    actualizarPrecio.actualizarPrecios("cafe americano", precio);
                    break;
                case 1:
                    //pro
                    break;
                case 3:


                    break;
                case 4:

                    break;

                    case 5:

                    break;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
