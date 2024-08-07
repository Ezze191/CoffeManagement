using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            
            //datos requeridos para ingresar al sistema
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text;
            double cashback = 0;
            int vecesvisitadas = 0;

            //checa si los texbox estan vacios por que es obligatorio ingresar informacion
            if(nombre == string.Empty || apellido == string.Empty)
            {
                MessageBox.Show("TIENES QUE LLENAR LOS DATOS REQUERIDOS");
            }
            
            else
            {
                //checa en la base de datos si el nombre y el apellido ya existen
                Conexion_BaseDatos conectarBD = new Conexion_BaseDatos();
                conectarBD.EstablecerConexion();
                string comparacion = "select * from cliente where nombre = " + "'" + nombre + "'" + " and apellido =" + "'" + apellido + "'" + ";";
                MySqlCommand ccomparcion = new MySqlCommand(comparacion, conectarBD.conexion);
                ccomparcion.CommandTimeout = 60;
                MySqlDataReader readercompa;
                readercompa = ccomparcion.ExecuteReader();
               
                 if (tb_nombre.Text == "admin" && tb_apellido.Text == "admin")
                {
                    MessageBox.Show("El usuario admin no se puede registrar");
                }
               else if (readercompa.Read())
                {
                    MessageBox.Show("LOS DATOS YA EXISTEN");
                    readercompa.Close();

                }

                else
                {
                    conectarBD.CerrarConexion();
                    ingresardatos();
                }

                
            }
            //metodo para ingrear los datos a la base de datos 
            void ingresardatos() {

             Conexion_BaseDatos conectarBD = new Conexion_BaseDatos();
             conectarBD.EstablecerConexion();
                string consulta = "insert into cliente values (" + "'" + nombre + "'" + "," + "'" + apellido + "'" + "," + cashback + "," + vecesvisitadas + ")" + ";";
            MySqlCommand comando = new MySqlCommand(consulta,conectarBD.conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comando.ExecuteReader();
                reader.Close();
                MessageBox.Show("CLIENTE REGISTRADO CORRECTAMENTE");
                conectarBD.CerrarConexion();
                Eleccion_de_consumo eleccion = new Eleccion_de_consumo();
                eleccion.datanombre = nombre;
                eleccion.dataapellido = apellido;
                eleccion.Show();
                this.Hide();
                
                }
            catch (Exception)
            {
                MessageBox.Show("AH OCURRIDO UN ERROR AL REGISTRAR AL CLIENTE");
                
            }
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            
            F_HOME home = new F_HOME(); 
            home.Show();
            this.Hide();

        }
    }
}
