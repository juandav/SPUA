using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class VehiculoOAD
    {
        private ConexionOracle conObject = new ConexionOracle();

        public DataTable consultarVehiculosDisponibles(string pegeId) {
            string sql = "SELECT"
                        + "     V.VEHI_PLACA,"
                        + "     V.VEHI_MODELO,"
                        + "     V.VEHI_MARCA,"
                        + "     V.VEHI_TIPO"
                        + " FROM"
                        + "     PARKING.VEHICULO V"
                        + " LEFT JOIN"
                        + "     PARKING.AUTORIZACION A2 ON (V.VEHI_ID=A2.VEHI_ID AND A2.PEGE_ID=" + pegeId + ")"
                        + " WHERE"
                        + "     V.VEHI_ID NOT IN(SELECT A.VEHI_ID FROM PARKING.AUTORIZACION A)";
            return conObject.consultarDatos(sql);
        }

        /// <summary>
        ///    Consulta todos los vehiculos de la Universidad que se registraron
        /// </summary>
        /// <returns>Lista de Tuplas</returns>
        public DataTable consultarVehiculos()
        {
            string sql = "SELECT"
                        + "     V.VEHI_ID,"
                        + "     (V.VEHI_MARCA ||' Modelo '|| V.VEHI_MODELO ||' con Placa: '|| V.VEHI_PLACA) VEHICULO,"
                        + "     ("
                        + "         CASE"
                        + "             WHEN V.VEHI_TIPO='CARROPEQUENIO'"
                        + "             THEN 'Carro Pequeño'"
                        + "             WHEN V.VEHI_TIPO='CARROGRANDE'"
                        + "             THEN 'Carro Grande'"
                        + "             WHEN V.VEHI_TIPO='MOTO'"
                        + "             THEN 'Moto'"
                        + "         END) AS TIPO"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".VEHICULO V";
            return conObject.consultarDatos(sql);
        }
        /// <summary>
        ///    Consulta un vehiculo especificado
        /// </summary>
        /// <param name="vehiId">Codigo del Vehiculo</param>
        /// <returns>Tupla del Vehiculo</returns>
        public DataTable consultarVehiculo(string vehiId)
        {
            string sql = "SELECT"
                        + "     V.VEHI_ID,"
                        + "     (V.VEHI_MARCA ||' Modelo '|| V.VEHI_MODELO ||' con Placa: '|| V.VEHI_PLACA) VEHICULO,"
                        + "     ("
                        + "         CASE"
                        + "             WHEN V.VEHI_TIPO='CARROPEQUENIO'"
                        + "             THEN 'Carro Pequeño'"
                        + "             WHEN V.VEHI_TIPO='CARROGRANDE'"
                        + "             THEN 'Carro Grande'"
                        + "             WHEN V.VEHI_TIPO='MOTO'"
                        + "             THEN 'Moto'"
                        + "         END) AS TIPO"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".VEHICULO V"
                        + "  WHERE"
                        + "        V.VEHI_ID = " + vehiId;
            return conObject.consultarDatos(sql);
        }
        /// <summary>
        ///    Crea un Nuevo Vehiculo
        /// </summary>
        /// <param name="vehiId">Codigo del Vehiculo en CHAIRA</param>
        /// <param name="vehiPlaca">Placa del Vehiculo Ejemplo: FGT768</param>
        /// <param name="vehiModelo">Modelo del Vehiculo; Ejemplo: 2015</param>
        /// <param name="vehiMarca">Marca del Vehiculo; Ejemplo: CHAIRA o MAZDA</param>
        /// <param name="vehiTipo">Tipo del Vehiculo Puden ser;
        ///    VEHI_TIPO: 'CARROPEQUENIO'
        ///    VEHI_TIPO: 'CARROGRANDE'
        ///    VEHI_TIPO: 'MOTO'
        /// </param>
        /// <param name="registradoPor">Funcionario quien registra la Informacion</param>
        /// <returns>Devulve 'SI' o 'NO'</returns>
        public string crearVehiculo(string vehiId, string vehiPlaca, string vehiModelo, string vehiMarca, string vehiTipo, string registradoPor)
        {
            string sql = "INSERT"
                        + " INTO"
                        + "     " + Global.SCHEMA_PARKING + ".VEHICULO"
                        + "     ("
                        + "         VEHI_ID,"
                        + "         VEHI_PLACA,"
                        + "         VEHI_MODELO,"
                        + "         VEHI_MARCA,"
                        + "         VEHI_TIPO,"
                        + "         VEHI_REGISTRADOPOR"
                        + "     )"
                        + "     VALUES"
                        + "     ("
                        + "         " + vehiId + ","
                        + "         '" + vehiPlaca + "',"
                        + "         '" + vehiModelo + "',"
                        + "         '" + vehiMarca + "',"
                        + "         '" + vehiTipo + "',"
                        + "         '" + registradoPor + "'"
                        + "     )";
            return conObject.datosRAE(sql);
        }
        /// <summary>
        ///   Actualiza un Vehiculo
        /// </summary>
        /// <param name="vehiId"></param>
        /// <param name="dato"></param>
        /// <param name="campo"></param>
        /// <param name="registradoPor"></param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string actualizarVehiculo(string vehiId, string dato, string campo, string registradoPor)
        {
            string sql = "UPDATE"
                        + "     " + Global.SCHEMA_PARKING + ".VEHICULO"
                        + " SET"
                        + "     " + campo + " = " + dato + ","
                        + "     VEHI_REGISTRADOPOR = '" + registradoPor + "',"
                        + "     VEHI_FECHACAMBIO = SYSDATE"
                        + " WHERE"
                        + "     VEHI_ID = " + vehiId;
            return conObject.datosRAE(sql);
        }
        /// <summary>
        ///    Elimina un Vehiculo.
        /// </summary>
        /// <param name="vehiId"></param>
        /// <returns>Devuelve 'SI' o 'NO'</returns>
        public string eliminarVehiculo(string vehiId)
        {
            string sql = "DELETE"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".VEHICULO"
                        + " WHERE"
                        + "     VEHI_ID = " + vehiId;
            return conObject.datosRAE(sql);
        }
    }
}