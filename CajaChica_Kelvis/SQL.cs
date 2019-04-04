using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CajaChica_Kelvis
{
    public class SQL
    {

        #region "Variables (Clases) de conexión"
        private SqlCommand ComandoSQL;
        private SqlDataAdapter AdaptadorSQL;
        private DataTable Dt;
        private SqlDataReader Dr;
        //private DataSet ds;
        DataSet ds = new DataSet();
        #endregion

        //Clase de Acceso a los datos
        private Conexion AccesoDatos;

        // Constructor
        public SQL()
        {
            AccesoDatos = new Conexion();
        }

       /* public DataSet BuscarDoc()
        {
            try
            {
                AccesoDatos.ObtenerConexionPOS().Open();

                SqlCommand Command = new SqlCommand();
                //Command.Connection = con;
                Command.Connection = AccesoDatos.ObtenerConexionPOS();

                Command.CommandText = "";
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter Adapter = new SqlDataAdapter(Command);

                SqlDataAdapter adap = new SqlDataAdapter(Command);
                adap.Fill(ds, "");

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }*/

        public DataSet BuscarDoc(Variables V)
        {
            AccesoDatos.ObtenerConexionPOS().Open();

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@Articulo", V.NumeroDoc);

                    using (AdaptadorSQL = new SqlDataAdapter())
                    {
                        AdaptadorSQL.SelectCommand = ComandoSQL;
                       // Dt = new DataTable();
                        AdaptadorSQL.Fill(ds, "NDocu");
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    AccesoDatos.ObtenerConexionPOS().Close();
                }
                return ds;
            }
        }

        public DataTable BuscarCajaChica()
        {
            AccesoDatos.ObtenerConexionPOS().Open();

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "SP_GET_REPORTECAJACHICA";
                try
                {
                   // ComandoSQL.Parameters.AddWithValue("@NumeroDocum", V.NumeroDoc);

                    using (AdaptadorSQL = new SqlDataAdapter())
                    {
                        AdaptadorSQL.SelectCommand = ComandoSQL;
                        Dt = new DataTable();
                        AdaptadorSQL.Fill(Dt);
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                finally
                {
                    AccesoDatos.ObtenerConexionPOS().Close();
                }
                return Dt;
            }
        }

        /* public void BuscarDoc(Variables V)
         {

             AccesoDatos.ObtenerConexionPOS().Open();

             using (ComandoSQL = new SqlCommand())
             {
                 ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                 ComandoSQL.CommandType = CommandType.StoredProcedure;
                 ComandoSQL.CommandText = "";
                 try
                 {

                     ComandoSQL.Parameters.AddWithValue("", V.NumeroDoc);


                     //Ejecutar Comando
                     ComandoSQL.ExecuteNonQuery();
                 }
                 catch (Exception)
                 {
                     throw;

                 }
                 finally
                 {
                     AccesoDatos.ObtenerConexionPOS().Close();
                 }
             }


         }*/
        public void InsertarCH(Variables V)
        {
            AccesoDatos.ObtenerConexionPOS().Open();

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "SP_INSERT_CAJACHICA";
                try
                {

                    ComandoSQL.Parameters.AddWithValue("@NDocu", V.NumeroDoc);
                    ComandoSQL.Parameters.AddWithValue("@Nota", V.Nota);
                    ComandoSQL.Parameters.AddWithValue("@FechaRegistro", V.FechaIngreso);
                    ComandoSQL.Parameters.AddWithValue("@FechaSistema", V.FechaSistema);
                    ComandoSQL.Parameters.AddWithValue("@Monto", V.Monto);
                    ComandoSQL.Parameters.AddWithValue("@NombrePC", V.NombrePC);



                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexionPOS().Close();
                }
            }

        }

        public void AtualizarCH(Variables V)
        {
            AccesoDatos.ObtenerConexionPOS().Open();

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "";
                try
                {

                    ComandoSQL.Parameters.AddWithValue("@NDocu", V.NumeroDoc);
                    ComandoSQL.Parameters.AddWithValue("@Nota", V.Nota);
                    ComandoSQL.Parameters.AddWithValue("@FechaRegistro", V.FechaIngreso);
                    ComandoSQL.Parameters.AddWithValue("@FechaSistema", V.FechaSistema);
                    ComandoSQL.Parameters.AddWithValue("@Monto", V.Monto);


                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexionPOS().Close();
                }
            }

        }

        public void AnularCH(Variables V)
        {
            AccesoDatos.ObtenerConexionPOS().Open();

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "";
                try
                {
                    ComandoSQL.Parameters.AddWithValue("@NDocu", V.NumeroDoc);
                    ComandoSQL.Parameters.AddWithValue("", V.Estado);


                    //Ejecutar Comando
                    ComandoSQL.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;

                }
                finally
                {
                    AccesoDatos.ObtenerConexionPOS().Close();
                }
            }

        }

        public DataSet UltimoNFactura()
        {
            try
            {
                AccesoDatos.ObtenerConexionPOS().Open();

                SqlCommand Command = new SqlCommand();
                //Command.Connection = con;
                Command.Connection = AccesoDatos.ObtenerConexionPOS();

                Command.CommandText = "[SP_GET_ULTIMONFACTURA]";
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter Adapter = new SqlDataAdapter(Command);

                SqlDataAdapter adap = new SqlDataAdapter(Command);
                adap.Fill(ds, "UltimoNFactura");

                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataSet BuscarTotalCaja(Variables N)
        {
            AccesoDatos.ObtenerConexionPOS().Open();

            using (ComandoSQL = new SqlCommand())
            {
                ComandoSQL.Connection = AccesoDatos.ObtenerConexionPOS();
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.CommandText = "SP_GET_TOTALCAJA";

                try
                {

                    ComandoSQL.Parameters.AddWithValue("@NombrePC",N.NombrePC);

                    using (AdaptadorSQL = new SqlDataAdapter())
                    {
                        AdaptadorSQL.SelectCommand = ComandoSQL;

                        AdaptadorSQL.Fill(ds, "TOTALCAJA");
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {
                    AccesoDatos.ObtenerConexionPOS().Close();
                }

                return ds;
            }
        }

    }
}
