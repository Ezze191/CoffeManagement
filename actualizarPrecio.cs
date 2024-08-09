using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public class actualizarPrecio
    {
        Conexion_BaseDatos actualizar = new Conexion_BaseDatos();
        public void actualizarPrecios(string nombre,double precio)
        {
            actualizar.EstablecerConexion();
            string consulta = "UPDATE bebidas SET precio = " + precio + "WHERE nombre = " + "'" + nombre + "';";
            MySqlCommand comando = new MySqlCommand(consulta, actualizar.conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Se ha actualizado correctamente el precio"); 
                reader.Close();

            }
            actualizar.CerrarConexion();
            
        }
    }
}
