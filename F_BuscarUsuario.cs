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
            this.Close();   
        }

        private void bt_BuscarUsuario_Click(object sender, EventArgs e)
        {
            Eleccion_de_consumo eleccion = new Eleccion_de_consumo();
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
                try
                {
                    Conexion_BaseDatos conectarBDbuscar = new Conexion_BaseDatos();
                    conectarBDbuscar.EstablecerConexion();

                    string comparacion = "SELECT VecesVisitadas FROM cliente Where nombre =  " + "'" + nombre + "'" + " and apellido =" + "'" + apellido + "'" + ";";

                    MySqlCommand ccomparcion = new MySqlCommand(comparacion, conectarBDbuscar.conexion);
                    ccomparcion.CommandTimeout = 60;
                    MySqlDataReader readerbuscar;
                    readerbuscar = ccomparcion.ExecuteReader();
                    if (readerbuscar.Read())
                    {
                        eleccion.dataVecesVicitadas = readerbuscar.GetInt32(0);
                        readerbuscar.Close();
                        eleccion.datanombre = nombre;
                        eleccion.dataapellido = apellido;
                        segundacomparacion();

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("EL CLIENTE NO ESTA REGISTRADO ¿DESEAS REGISTRARLO?", "CLIENTE NO ENCONTRADO", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            F_RegistarCliente registar = new F_RegistarCliente();
                            registar.data_name = tb_nombre.Text;
                            registar.data_apellido = tb_apellido.Text;
                            registar.Show();
                            this.Close();
                        }
                    }

                    void segundacomparacion()
                    {
                        string comparacion2 = "SELECT cashback FROM cliente Where nombre =  " + "'" + nombre + "'" + " and apellido =" + "'" + apellido + "'" + ";";
                        MySqlCommand comand2 = new MySqlCommand(comparacion2, conectarBDbuscar.conexion);
                        comand2.CommandTimeout = 60;
                        MySqlDataReader reader2 = comand2.ExecuteReader();
                        if (reader2.Read())
                        {
                            if (tb_nombre.Text == "admin" && tb_apellido.Text == "admin")
                            {
                                eleccion.dataCashBack = reader2.GetDouble(0);
                                reader2.Close();
                                conectarBDbuscar.CerrarConexion();
                                VentanaAdmin admin = new VentanaAdmin();
                                admin.Show();

                                this.Close();
                                 
                                
                           
                            } 
                            else
                            {
                                eleccion.dataCashBack = reader2.GetDouble(0);
                                reader2.Close();
                                conectarBDbuscar.CerrarConexion();
                                eleccion.Show();
                                this.Close();
                            }
                        }
                    }
                } 
                catch {
                    MessageBox.Show("OCURRIO UN PROBLEMA EN LA BASE DE DATOS");

                }

            }
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_HOME home = new F_HOME();
            home.Show();
            this.Close();    
        }

        private void F_BuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void L_Nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
