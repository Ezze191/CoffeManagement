using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Proyecto_POO
{
    public class Conexion_BaseDatos
    {
        public MySqlConnection conexion = new MySqlConnection();
        static string servidor = "btjsv0n65xyccpn0hvfy-mysql.services.clever-cloud.com";
        static string bd = "btjsv0n65xyccpn0hvfy";
        static string usuario = "uxzkcfhsdhoy0kb8";
        static string password = "6h9uTwE0kkryU2DnEbyG";
        static string puerto = "3306";

        string CodigoConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection EstablecerConexion()
        {
            conexion.ConnectionString = CodigoConexion;
            conexion.Open();    
            return conexion;

        }
    }
}
