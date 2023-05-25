using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol_PuntoVenta.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        //private string Usuario;
        //private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            Base = "BD_PUNTOVENTA";
            Servidor = "DESKTOP-P2EL1SL\\SQLEXPRESS";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + Servidor + "; Database=" + Base + "; Integrated Security=True";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}