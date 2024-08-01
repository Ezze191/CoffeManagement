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
    public partial class F_BuscarUsuario : Form
    {
        public F_BuscarUsuario()
        {
            InitializeComponent();
        }

        private void bt_regresar_Click(object sender, EventArgs e)
        {
            F_HOME vhome = new F_HOME();
            vhome.Show();
            this.Hide();   
        }

        private void bt_BuscarUsuario_Click(object sender, EventArgs e)
        {
            Eleccion_de_consumo veleccion = new Eleccion_de_consumo();
            veleccion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_HOME home = new F_HOME();
            home.Show();
            this.Hide();    
        }
    }
}
