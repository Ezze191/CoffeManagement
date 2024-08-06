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
    public partial class F_HOME : Form
    {
        public F_HOME()
        {
            InitializeComponent();
        }

        private void F_HOME_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try {
                Conexion_BaseDatos conectar = new Conexion_BaseDatos();
                conectar.EstablecerConexion();
                lb_conexion.ForeColor = Color.Green;
                conectar.CerrarConexion();
            }
            catch{
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
            
        }

        private void BT_BUSCAR_USUARIO_Click(object sender, EventArgs e)
        {

            F_BuscarUsuario V_BuscarUsuario = new F_BuscarUsuario();
            V_BuscarUsuario.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BT_INVITADO_Click(object sender, EventArgs e)
        {
            Eleccion_de_consumo eleccion = new Eleccion_de_consumo();   
            eleccion.Show();    
            this.Hide();    
        }

        private void BT_REGISTRAR_Click(object sender, EventArgs e)
        {
            F_RegistarCliente registrar = new F_RegistarCliente();
            registrar.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
