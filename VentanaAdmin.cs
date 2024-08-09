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
            // Configurar el texto inicial y el color
            textBox1.Text = "Ejemplo con 4 digitos: 42.01";
            textBox1.ForeColor = Color.Gray;

            // Asignar los eventos Enter y Leave
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
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
                    try
                    { //programar precio americano
                        actualizarPrecio actualizarPrecio = new actualizarPrecio();
                        actualizarPrecio.actualizarPrecios("cafe americano", precio);
                        MessageBox.Show("Se actualizo correctamente el precio del cafe americano");
                    }
                    catch 
                    {
                        MessageBox.Show("Error al actualizar el precio del cafe americano");

                    }
                   
                   
                    break;
                case 1:
                    try
                    { //programar precio americano
                        actualizarPrecio actualizarPrecio = new actualizarPrecio();
                        actualizarPrecio.actualizarPrecios("capuccino", precio);
                        MessageBox.Show("Se actualizo correctamente el precio del capuccino");
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el precio del capuccino");

                    }

                    break;
                case 2:
                    try
                    { //programar precio americano
                        actualizarPrecio actualizarPrecio = new actualizarPrecio();
                        actualizarPrecio.actualizarPrecios("latte frio", precio);
                        MessageBox.Show("Se actualizo correctamente el precio del latte frio");
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el precio del latte frio");

                    }


                    break;
                case 3:
                    try
                    { //programar precio americano
                        actualizarPrecio actualizarPrecio = new actualizarPrecio();
                        actualizarPrecio.actualizarPrecios("macciato", precio);
                        MessageBox.Show("Se actualizo correctamente el precio del Macciato");
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el precio del Macciato");

                    }

                    break;

                    case 4:
                    try
                    { //programar precio americano
                        actualizarPrecio actualizarPrecio = new actualizarPrecio();
                        actualizarPrecio.actualizarPrecios("moka", precio);
                        MessageBox.Show("Se actualizo correctamente el precio del Moka");
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el precio del Moka");

                    }

                    break;
                    case 5:
                    try
                    { //programar precio americano
                        actualizarPrecio actualizarPrecio = new actualizarPrecio();
                        actualizarPrecio.actualizarPrecios("esspreso", precio);
                        MessageBox.Show("Se actualizo correctamente el precio del Espresso");
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar el precio del Espresso");

                    }

                    break;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ejemplo con 4 digitos: 42.01")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Ejemplo con 4 digitos: 42.01";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
