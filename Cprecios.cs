using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_POO
{
    public class Cprecios
    {
        Conexion_BaseDatos ConexionBDeleccion = new Conexion_BaseDatos();
        public double p_cafe_amerciano = 0;
        public double p_capuccino = 0;
        public double p_latte_frio = 0;
        public double p_esspreso = 0;
        public double p_macciatto = 0;
        public double p_moka = 0;
        public void establecer_precios()
        {
            ConexionBDeleccion.EstablecerConexion();
            for (int i = 0; i < 6; i++)
            {
                if(i == 0)
                {
                    string consulta = "SELECT precio FROM bebidas WHERE nombre = 'cafe americano';";
                    MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
                    comaCafeAmericano.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = comaCafeAmericano.ExecuteReader();
                    if (reader.Read())
                    {
                        p_cafe_amerciano = reader.GetDouble(0);
                        reader.Close();
                    }
                }
                else if (i == 1)
                {
                    string consulta = "SELECT precio FROM bebidas WHERE nombre = 'capuccino';";
                    MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
                    comaCafeAmericano.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = comaCafeAmericano.ExecuteReader();
                    if (reader.Read())
                    {
                        p_capuccino = reader.GetDouble(0);
                        reader.Close();
                    }
                }
                else if(i == 2)
                {
                    string consulta = "SELECT precio FROM bebidas WHERE nombre = 'esspreso';";
                    MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
                    comaCafeAmericano.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = comaCafeAmericano.ExecuteReader();
                    if (reader.Read())
                    {
                        p_esspreso = reader.GetDouble(0);
                        reader.Close();
                    }
                }
                else if(i==3)
                {
                    string consulta = "SELECT precio FROM bebidas WHERE nombre = 'latte frio';";
                    MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
                    comaCafeAmericano.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = comaCafeAmericano.ExecuteReader();
                    if (reader.Read())
                    {
                        p_latte_frio = reader.GetDouble(0);
                        reader.Close();
                    }
                }
                else if(i == 4)
                {
                    string consulta = "SELECT precio FROM bebidas WHERE nombre = 'macciato';";
                    MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
                    comaCafeAmericano.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = comaCafeAmericano.ExecuteReader();
                    if (reader.Read())
                    {
                        p_macciatto = reader.GetDouble(0);
                        reader.Close();
                    }
                }
                else if (i == 5)
                {
                    string consulta = "SELECT precio FROM bebidas WHERE nombre = 'moka';";
                    MySqlCommand comaCafeAmericano = new MySqlCommand(consulta, ConexionBDeleccion.conexion);
                    comaCafeAmericano.CommandTimeout = 60;
                    MySqlDataReader reader;
                    reader = comaCafeAmericano.ExecuteReader();
                    if (reader.Read())
                    {
                        p_moka = reader.GetDouble(0);
                        reader.Close();
                    }
                }
            }
            ConexionBDeleccion.CerrarConexion();
        }


    }
    }
