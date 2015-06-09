using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class AutorizacionOAD
    {

        /// <summary>
        ///   Objeto Coneccion
        /// </summary>
        private ConexionOracle connObject = new ConexionOracle();

        /// <summary>
        ///   Consulta Las autorizaciones que tiente una persona de sacar un vehiculo.
        /// </summary>
        /// <param name="autoTipo">autoTipo: 'DUENIO'; este es el dueño del vehiculo
        ///                        autoTipo: 'ASISTENTE'; este se le permite sacar el vehiculo pero no es el Dueño.
        /// </param>
        /// <returns>Lista de Personas asociadas a un vehiculo</returns>
        public DataTable consultarAutorizaciones(string autoTipo)
        {
            string sql = "SELECT"
                        + "     A.PEGE_ID,"
                        + "     A.VEHI_ID,"
                        + "     U.USUA_DOCUMENTO,"
                        + "     U.USUA_CODIGOUDLA,"
                        + "     U.USUA_NOMBRE,"
                        + "     U.USUA_PROGRAMA,"
                        + "     U.USUA_DOCUMENTO,"
                        + "     V.VEHI_MARCA||' '||V.VEHI_MODELO"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".AUTORIZACION A"
                        + " INNER JOIN " + Global.SCHEMA_PARKING + ".USUARIO U  ON ( A.PEGE_ID = U.PEGE_ID )"
                        + " INNER JOIN " + Global.SCHEMA_PARKING + ".VEHICULO V ON (A.VEHI_ID = V.VEHI_ID)"
                        + " WHERE"
                        + "     A.AUTO_TIPO = '" + autoTipo + "'";
            return connObject.consultarDatos(sql);
        }
        /// <summary>
        ///   Consulta La autorizacion de un Vehiculo por el codigo de usuario en CHAIRA y el tipo de autorizacion que tiene una persona en un vehiculo.
        /// </summary>
        /// <param name="pegeId">Codigo de la Persona en CHAIRA</param>
        /// <param name="autoTipo">
        ///     autoTipo: 'DUENIO'; este es el dueño del vehiculo
        ///     autoTipo: 'ASISTENTE'; este se le permite sacar el vehiculo pero no es el Dueño.
        /// </param>
        /// <returns>Tupla de la Autorizacion hecha a una persona de entrar o salir con un vehiculo </returns>
        public DataTable consultarAutorizacion(string pegeId, string autoTipo)
        {
            string sql = "SELECT"
                        + "     A.PEGE_ID,"
                        + "     A.VEHI_ID,"
                        + "     U.USUA_DOCUMENTO,"
                        + "     U.USUA_CODIGOUDLA,"
                        + "     U.USUA_NOMBRE,"
                        + "     U.USUA_PROGRAMA,"
                        + "     U.USUA_DOCUMENTO,"
                        + "     V.VEHI_MARCA||' '||V.VEHI_MODELO"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".AUTORIZACION A"
                        + " INNER JOIN " + Global.SCHEMA_PARKING + ".USUARIO U  ON ( A.PEGE_ID = U.PEGE_ID )"
                        + " INNER JOIN " + Global.SCHEMA_PARKING + ".VEHICULO V ON (A.VEHI_ID = V.VEHI_ID)"
                        + " WHERE"
                        + "     A.AUTO_TIPO = '" + autoTipo + "'"
                        + " AND A.PEGE_ID = '" + pegeId + "'";
            return connObject.consultarDatos(sql);
        }

        /// <summary>
        ///   Asigna una autorizacion a una persona de que puede ingresar o salir con un vehiculo de la institucion
        /// </summary>
        /// <param name="pegeId">Codigo de la Persona en CHAIRA</param>
        /// <param name="vehiId">Codigo del vehiculo en CHAIRA</param>
        /// <param name="registradoPor">Funcionario quien registra</param>
        /// <param name="autoTipo">
        ///     autoTipo: 'PROPIETARIO'; Dueño del vehiculo
        ///     autoTipo: 'FAMILIAR'; Familiar del Duelo
        ///     autoTipo: 'PARTICULAR'; Persona alterna que no tiene vinculo sanguineo con el Dueño
        /// </param>
        /// <returns></returns>
        public string crearAutorizacion(string pegeId, string vehiId, string registradoPor, string autoTipo)
        {
            string sql = "INSERT"
                        + " INTO"
                        + "     " + Global.SCHEMA_PARKING + ".AUTORIZACION"
                        + "     ("
                        + "         PEGE_ID,"
                        + "         VEHI_ID,"
                        + "         AUTO_REGISTRADOPOR,"
                        + "         AUTO_TIPO"
                        + "     )"
                        + "     VALUES"
                        + "     ("
                        + "         " + pegeId + ","
                        + "         " + vehiId + ","
                        + "         '" + registradoPor + "',"
                        + "         '" + autoTipo + "'"
                        + "     )";
            return connObject.datosRAE(sql);
        }

        /// <summary>
        ///   Actualiza una Autorizacion de ingreso o salida de un vehiculo asignado a una persona
        /// </summary>
        /// <param name="dato"> Dato que se va actualizar en Base de Datos </param>
        /// <param name="campo"> Nombre del Campo en base de datos </param>
        /// <param name="pegeId"> Codigo de la persona que se va a autorizar en CHAIRA</param>
        /// <param name="vehiId"> Codigo del vehiculo en CHAIRA</param>
        /// <param name="registradoPor"> Funcionario quien actualiza</param>
        /// <returns>Decuelve 'SI' o 'NO'</returns>
        public string actualizarAutorizacionSimple(string dato, string campo, string pegeId, string vehiId, string registradoPor)
        {
            string sql = "UPDATE"
                        + "     " + Global.SCHEMA_PARKING + ".AUTORIZACION"
                        + " SET"
                        + "     " + campo + " = " + dato + ","
                        + "     AUTO_REGISTRADOPOR = '" + registradoPor + "',"
                        + "     AUTO_FECHACAMBIO = SYSDATE"
                        + " WHERE"
                        + "     PEGE_ID = " + pegeId
                        + " AND VEHI_ID = " + vehiId;
            return connObject.datosRAE(sql);
        }

        /// <summary>
        ///    Elimina una autorizacion de entrada y salida de un vehiculo asociado a una persona
        /// </summary>
        /// <param name="pegeId"> Codigo de la Persona en CHAIRA</param>
        /// <param name="vehiId"> Codigo del Vehiculo en CHAIRA</param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string eliminarAutorizacion(string pegeId, string vehiId)
        {
            string sql = "DELETE"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".AUTORIZACION"
                        + " WHERE"
                        + "     PEGE_ID = " + pegeId
                        + " AND VEHI_ID = " + vehiId;
            return connObject.datosRAE(sql);
        }


    }
}