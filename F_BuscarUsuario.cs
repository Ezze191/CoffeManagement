using MySql.Data.MySqlClient;
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
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text;

            if(nombre == string.Empty || apellido == string.Empty)
            {
                MessageBox.Show("TIENES QUE LLENAR LOS DATOS SOLICIDATOS");
            }
            else
            {
                buscarcliente();
            }

            void buscarcliente()
            {
                
                //checa en la base de datos si el nombre y el apellido estan registrados y entrar a la siguiente opcion
                Conexion_BaseDatos conectarBDbuscar = new Conexion_BaseDatos();
                conectarBDbuscar.EstablecerConexion();
                string comparacion = "select * from cliente where nombre = " + "'" + nombre + "'" + " and apellido =" + "'" + apellido + "'" + ";";
                MySqlCommand ccomparcion = new MySqlCommand(comparacion, conectarBDbuscar.conexion);
                ccomparcion.CommandTimeout = 60;
                MySqlDataReader readerbuscar;
                readerbuscar = ccomparcion.ExecuteReader();
                if (readerbuscar.Read())
                {
                    readerbuscar.Close();
                    Eleccion_de_consumo eleccion = new Eleccion_de_consumo();
                    eleccion.Show();
                    this.Close();
                   

                }
                else
                {
                    MessageBox.Show("EL USUSARIO NO EXISTE, POR FAVOR DE REGISTRARLO");
                   
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_HOME home = new F_HOME();
            home.Show();
            this.Hide();    
        }
    }
}
