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

    }
}