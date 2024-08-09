using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class subir_user_base_de_datos
    {
        int guardar_cuantas_veces = 0;
        double guardar_cashback = 0;
        Conexion_BaseDatos BD_CONEXION = new Conexion_BaseDatos();

        public void consultar(string name, string apellido , double porcentaje , int veces)
        {
            BD_CONEXION.EstablecerConexion();

            string consulta1 = "SELECT cashback FROM cliente WHERE nombre = " + "'" + name + "'" + "AND apellido = " + "'" + apellido + "'";
            MySqlCommand comando1 = new MySqlCommand(consulta1, BD_CONEXION.conexion);
            comando1.CommandTimeout = 60;
            MySqlDataReader reader_comando1; 
            reader_comando1 = comando1.ExecuteReader();
            if (reader_comando1.Read())
            {
                guardar_cashback = reader_comando1.GetDouble(0);
                reader_comando1.Close();
            }

            string consulta2 = "SELECT VecesVisitadas FROM cliente WHERE nombre = " + "'" + name + "'" + "AND apellido = " + "'" + apellido + "'";
            MySqlCommand comando2 = new MySqlCommand(consulta2, BD_CONEXION.conexion);
            comando2.CommandTimeout = 60;
            MySqlDataReader reader_comando2;
            reader_comando2 = comando2.ExecuteReader();
            if (reader_comando2.Read())
            {
                guardar_cuantas_veces = reader_comando2.GetInt32(0);
                reader_comando2.Close();
            }

            guardar_cashback = guardar_cashback + porcentaje;
            guardar_cuantas_veces = guardar_cuantas_veces + veces;

            BD_CONEXION.CerrarConexion();
        }
        public void subir_cash(string name , string apellido)
        {
            BD_CONEXION.EstablecerConexion();
            string consulta = "UPDATE cliente SET cashback = " + guardar_cashback + " WHERE nombre = " + "'" + name + "'" + "AND apellido = " + "'" + apellido + "'";
            MySqlCommand comando = new MySqlCommand(consulta, BD_CONEXION.conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader_comando;
            reader_comando = comando.ExecuteReader();
            if (reader_comando.Read())
            {
                reader_comando.Close();
            }
            BD_CONEXION.CerrarConexion();

        }

        public void subir_veces(string name, string apellido)
        {
            BD_CONEXION.EstablecerConexion();
            string consulta = "UPDATE cliente SET Vecesvisitadas = " + guardar_cuantas_veces + " WHERE nombre = " + "'" + name + "'" + "AND apellido = " + "'" + apellido + "'";
            MySqlCommand comando = new MySqlCommand(consulta, BD_CONEXION.conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader_comando;
            reader_comando = comando.ExecuteReader();
            if (reader_comando.Read())
            {
                reader_comando.Close();
            }
            BD_CONEXION.CerrarConexion();

            

        }

        public void subir_restante_cash_back(string name, string apellido, double restante)
        {
            BD_CONEXION.EstablecerConexion();
            restante = guardar_cashback - restante;
            string consulta = "UPDATE cliente SET cashback = " + restante + " WHERE nombre = " + "'" + name + "'" + "AND apellido = " + "'" + apellido + "'";
            MySqlCommand comando = new MySqlCommand(consulta, BD_CONEXION.conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader_comando;
            reader_comando = comando.ExecuteReader();
            if (reader_comando.Read())
            {
                reader_comando.Close();
            }

            

            BD_CONEXION.CerrarConexion();
        }
    }
        
    
}
