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

    }
}