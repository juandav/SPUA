using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class EtiquetaOAD
    {

        private ConexionOracle conObject = new ConexionOracle();

        public DataTable consultarTarjetas(string pegeId) {
            string sql = "SELECT"
                        + "     E.ETIQ_ID AS ID,"
                        + "     E.ETIQ_CODIGO AS CODIGO,"
                        + "     E.ETIQ_ESTADO AS ESTADO"
                        + " FROM"
                        + "     PARKING.USUARIOTARJETA UT"
                        + " INNER JOIN"
                        + "     PARKING.ETIQUETA E ON (UT.ETIQ_ID=E.ETIQ_ID"
                        + "     AND"
                        + "         UT.PEGE_ID='" + pegeId + "')"
                        + " WHERE "
                        + "     E.ETIQ_TIPO='TARJETA'";
            return conObject.consultarDatos(sql);
        }

    }
}