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
    public partial class F_RegistarCliente : Form
    {
        public F_RegistarCliente()
        {
            InitializeComponent();
        }

        private void F_RegistarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_registrarCliente_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text; 



            MessageBox.Show("El cliente se ah registrado Correctamente");
            Eleccion_de_consumo eleccion = new Eleccion_de_consumo();
           eleccion.Show();
           this.Hide();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            
            F_HOME home = new F_HOME(); 
            home.Show();
            this.Hide();

        }
    }
}
