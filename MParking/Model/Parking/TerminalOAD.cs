using MParking.Conections;
using System.Data;

namespace MParking.Model.Parking
{
    public class TerminalOAD
    {

        private ConexionOracle connObject = new ConexionOracle();
        /// <summary>
        ///    Consulta todas las Terminales Existentes.
        /// </summary>
        /// <returns>Devuelve la lista de Dispositivos Registrados</returns>
        public DataTable consultarTerminales()
        {
            string sql = "SELECT"
                        + "     T.TERM_ID,"
                        + "     T.TERM_TIPO,"
                        + "     T.TERM_IP ||':'||T.TERM_PUERTO AS TERM_IP_PORT,"
                        + "     T.TERM_DESCRIPCION"
                        + " FROM "
                        + "     " + Global.SCHEMA_PARKING + ".TERMINAL T";
            return connObject.consultarDatos(sql);
        }

        public DataTable consultarTerminalesBiometrico()
        {
            string sql = "SELECT"
                        + "     T.TERM_ID,"
                        + "     T.TERM_IP ||':'||T.TERM_PUERTO AS TERM_IP_PORT,"
                        + "     T.TERM_DESCRIPCION"
                        + " FROM "
                        + "     " + Global.SCHEMA_PARKING + ".TERMINAL T "
                        + " WHERE T.ETIQ_ESTADO = 'ACTIVO' AND T.TERM_TIPO='BIOMETRICO'";
            return connObject.consultarDatos(sql);
        }
        /// <summary>
        ///    Consulta una Terminal Especifica
        /// </summary>
        /// <param name="termId">Codigo de la Terminal</param>
        /// <returns>Tupla de la terminal</returns>
        public DataTable consultarTerminal(string termId)
        {
            string sql = "SELECT"
                        + "     T.TERM_ID,"
                        + "     T.TERM_TIPO,"
                        + "     T.TERM_IP,"
                        + "     T.TERM_PUERTO,"
                        + "     T.TERM_DESCRIPCION"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".TERMINAL T"
                        + " WHERE "
                        + "     T.TERM_ID = " + termId;
            return connObject.consultarDatos(sql);
        }
        /// <summary>
        ///     Crea una Nueva Terminal
        /// </summary>
        /// <param name="termId">Codigo de la Terminal</param>
        /// <param name="termTipo">Tipo de la Terminal puede se de tipo: BIOMETRICO o RFID</param>
        /// <param name="termIp">La direccion Logica del Dispositivo; ejemplo:127.0.0.1</param>
        /// <param name="termPuerto">Puerto en el que la terminal puede escuchar; ejemplo:8080</param>
        /// <param name="termDescripcion">Breve descripcion del dispositivo</param>
        /// <param name="registradoPor">Funcionario quien registra la terminal</param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string crearTerminal(string termId, string termTipo, string termIp, string termPuerto, string termDescripcion, string registradoPor)
        {
            string sql = "INSERT"
                        + " INTO"
                        + "     " + Global.SCHEMA_PARKING + ".TERMINAL"
                        + "     ("
                        + "         TERM_ID,"
                        + "         TERM_TIPO,"
                        + "         TERM_IP,"
                        + "         TERM_PUERTO,"
                        + "         TERM_DESCRIPCION,"
                        + "         TERM_REGISTRADOPOR"
                        + "     )"
                        + "     VALUES"
                        + "     ("
                        + "         " + termId + ","
                        + "         '" + termTipo + "',"
                        + "         '" + termIp + "',"
                        + "         '" + termPuerto + "',"
                        + "         '" + termDescripcion + "',"
                        + "         '" + registradoPor + "'"
                        + "     )";
            return connObject.datosRAE(sql);
        }
        /// <summary>
        ///   Actualiza una Terminal
        /// </summary>
        /// <param name="termId">Codigo del Terminal</param>
        /// <param name="campo">Nombre del Campo en base de datos</param>
        /// <param name="dato">Dato que se desea ingresar</param>
        /// <param name="registradoPor">Funcionario quien actualiza</param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string actualizarTerminalSimple(string termId, string campo, string dato, string registradoPor)
        {
            string sql = "UPDATE"
                        + "     " + Global.SCHEMA_PARKING + ".TERMINAL"
                        + " SET"
                        + "     " + campo + " = '" + dato + "',"
                        + "     TERM_REGISTRADOPOR = '" + registradoPor + "',"
                        + "     TERM_FECHACAMBIO = SYSDATE"
                        + " WHERE"
                        + "     TERM_ID = " + termId;
            return connObject.datosRAE(sql);
        }
        /// <summary>
        ///    Elimina una Terminal
        /// </summary>
        /// <param name="termId">Codigo de la Terminal</param>
        /// <returns>Devuelve 'SI' o 'NO' </returns>
        public string eliminarTerminal(string termId)
        {
            string sql = "DELETE"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".TERMINAL"
                        + " WHERE"
                        + "     TERM_ID = " + termId;
            return connObject.datosRAE(sql);
        }

    }
}