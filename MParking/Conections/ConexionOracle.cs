using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;

namespace MParking.Conections
{
    public class ConexionOracle
    {
        /// <summary>
        ///    Consulta la cadena de conexion.
        /// </summary>
        /// <returns>Devuelve la cadena de conexion de pruebas.</returns>
        private string consultarCadenaDeConexion()
        {
            return ConfigurationManager.ConnectionStrings["PruebasJ.ECHEVERRY"].ConnectionString;
        }

        /// <summary>
        ///   Permite consultar la base de datos Oracle.
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns>DataTable con lso datos.</returns>
        public DataTable consultarDatos(string sql)
        {
            OracleConnection conexionOracleObject = new OracleConnection(consultarCadenaDeConexion());
            OracleCommand comandoOracleObject = new OracleCommand(sql, conexionOracleObject);
            OracleDataAdapter adaptadorDeDatosObject = new OracleDataAdapter(comandoOracleObject);
            DataSet conjuntoDeDatosObject = new DataSet();
            try
            {
                conexionOracleObject.Open();
                adaptadorDeDatosObject.Fill(conjuntoDeDatosObject);
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conexionOracleObject.Close();
                comandoOracleObject.Dispose();
            }
            return conjuntoDeDatosObject.Tables[0];
        }

        /// <summary>
        /// Funcion que permite las siguientes opciones.
        ///   1. Registrar 
        ///   2. Actualizar
        ///   3. Eliminar
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns>Devuelve "YES" o "NO"</returns>
        public string datosRAE(string sql)
        {
            OracleConnection conexionOracleObject = new OracleConnection(consultarCadenaDeConexion());
            OracleCommand comandoOracleObject = new OracleCommand(sql);
            comandoOracleObject.Connection = conexionOracleObject;

            string respuesta = "NO";

            try
            {
                conexionOracleObject.Open();
                int filasAfectadas = comandoOracleObject.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    respuesta = "YES";
                }
            }
            catch (Exception)
            {
                return "NO";
            }
            finally
            {
                conexionOracleObject.Close();
                comandoOracleObject.Dispose();
            }
            return respuesta;
        }
    }
}