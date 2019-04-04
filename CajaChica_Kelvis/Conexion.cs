using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CajaChica_Kelvis
{
   public class Conexion
    {
        #region "Variables (Clases) de Conexion"
        private SqlConnection ConexionPOS;
        #endregion

        public Conexion()
        {
            ConexionPOS = new SqlConnection(CadenaConexionPOS);


        }

        private string CadenaConexionPOS
        {
            get
            {
                //return ConfigurationManager.ConnectionStrings["Presentacion.Properties.Settings.Local"].ToString();
                return ConfigurationManager.AppSettings["Conexion_POS"].ToString();
            }

        }

        public SqlConnection ObtenerConexionPOS()
        {
            return ConexionPOS;
        }
    }
}
