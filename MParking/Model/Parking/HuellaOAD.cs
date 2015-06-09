using System;  
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class HuellaOAD
    {

        private ConexionOracle conObject = new ConexionOracle();

        public DataTable consultarHuellasDeUnPege(string pegeId) {
            string sql = "SELECT"
                        + "     H.HUEL_ID AS ID,"
                        + "     H.HUEL_CODIGO AS CODIGO,"
                        + "     H.HUELL_HUELLA AS HUELLA"
                        + " FROM"
                        + "     PARKING.HUELLA H"
                        + " WHERE"
                        + "     H.PEGE_ID='" + pegeId + "'";
            return conObject.consultarDatos(sql);
        }

        /// <summary>
        ///   Consulta todas las huellas asociadas a una persona
        /// </summary>
        /// <returns>Devuelve una lista de huellas</returns>
        public DataTable consultarHuellas()
        {
            string sql = "SELECT"
                        + "     H.HUEL_ID,"
                        + "     H.PEGE_ID,"
                        + "     H.HUEL_CODIGO,"
                        + "     H.HUELL_HUELLA,"
                        + "     H.HUEL_CODIGODEDO,"
                        + "     H.HUELL_PLANTILLA,"
                        + "     H.HELL_BANDERA"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".HUELLA H";
            return conObject.consultarDatos(sql);
        }
        /// <summary>
        ///   Consulta la huella de una persona
        /// </summary>
        /// <param name="pegeId">Codigo de la persona en CHAIRA</param>
        /// <returns>Devuelve una tupla de huella</returns>
        public DataTable consultarHuella(string pegeId)
        {
            string sql = "SELECT"
                        + "     H.HUEL_ID,"
                        + "     H.PEGE_ID,"
                        + "     H.HUEL_CODIGO,"
                        + "     H.HUELL_HUELLA,"
                        + "     H.HUEL_CODIGODEDO,"
                        + "     H.HUELL_PLANTILLA,"
                        + "     H.HELL_BANDERA"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".HUELLA H"
                        + " WHERE "
                        + "     H.PEGE_ID=" + pegeId;
            return conObject.consultarDatos(sql);
        }
        /// <summary>
        ///   Crea una nueva Huella
        /// </summary>
        /// <param name="pegeId">Codig de la Persona</param>
        /// <param name="huelCodigo">Codigo de la Huella</param>
        /// <param name="registradoPor">Funcionario quien registra</param>
        /// <param name="huella">La huella de la persona</param>
        /// <param name="codigoDedo">Indica que dedo es el que registra</param>
        /// <param name="plantilla">No definido aun</param>
        /// <param name="bandera">No definido aun</param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string crearHuella(string pegeId, string huelCodigo, string registradoPor, string huella, string codigoDedo, string plantilla, string bandera)
        {
            string huelId = "";
            string sql = "INSERT"
                        + " INTO"
                        + "     " + Global.SCHEMA_PARKING + ".HUELLA"
                        + "     ("
                        + "         HUEL_ID,"
                        + "         PEGE_ID,"
                        + "         HUEL_CODIGO,"
                        + "         HUEL_REGISTRADOPOR,"
                        + "         HUELL_HUELLA,"
                        + "         HUEL_CODIGODEDO,"
                        + "         HUELL_PLANTILLA,"
                        + "         HELL_BANDERA"
                        + "     )"
                        + "     VALUES"
                        + "     ("
                        + "         " + huelId + ","
                        + "         " + pegeId + ","
                        + "         '" + huelCodigo + "',"
                        + "         '" + registradoPor + "',"
                        + "         '" + huella + "',"
                        + "         " + codigoDedo + ","
                        + "         " + plantilla + ","
                        + "         " + bandera + ""
                        + "     )";
            return conObject.datosRAE(sql);
        }
        /// <summary>
        ///    Actualiza una Huella especifica
        /// </summary>
        /// <param name="huelId">Codigo de la huella en CHAIRA</param>
        /// <param name="registradoPor">Funcionario quien registra la Huella</param>
        /// <param name="dato">dato que se va a registrar</param>
        /// <param name="campo">Nombre del Campo en Base de Datos</param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string actualizarHuella(string huelId, string registradoPor, string dato, string campo)
        {
            string sql = "UPDATE"
                        + "     " + Global.SCHEMA_PARKING + ".HUELLA"
                        + " SET"
                        + "     " + campo + " = '" + dato + "',"
                        + "     HUEL_REGISTRADOPOR = '" + registradoPor + "',"
                        + "     HUEL_FECHACAMBIO = SYSDATE"
                        + " WHERE"
                        + "     HUEL_ID = " + huelId;
            return conObject.datosRAE(sql);
        }
        /// <summary>
        ///    Elimina la Huella de una persona
        /// </summary>
        /// <param name="huelId">Codigo de la huella en CHAIRA</param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string eliminarHuella(string huelId)
        {
            string sql = "DELETE"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".HUELLA"
                        + " WHERE"
                        + "     HUEL_ID = " + huelId;
            return conObject.datosRAE(sql);
        }

    }
}