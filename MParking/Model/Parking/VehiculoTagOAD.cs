using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class VehiculoTagOAD
    {

        private ConexionOracle conObject = new ConexionOracle();
        public DataTable consultarPlacaporEtiqueta(string etiqID, string etiqTipo)
        {
            string sql = " SELECT"
                                + " V.VEHI_PLACA "
                                + " FROM " + Global.SCHEMA_PARKING + ".VEHICULOTAG A "
                                + " INNER JOIN "
                                + Global.SCHEMA_PARKING + ".ETIQUETA E ON E.ETIQ_ID = A.ETIQ_ID "
                                + " INNER JOIN "
                                + Global.SCHEMA_PARKING + ".VEHICULO V ON A.VEHI_ID = V.VEHI_ID "
                                + " WHERE "
                                + "  E.ETIQ_CODIGO = " + "'" + etiqID + "'"
                                + " AND E.ETIQ_TIPO= " + "'" + etiqTipo + "'" + " AND E.ETIQ_ESTADO='ACTIVO'";
            return conObject.consultarDatos(sql);
        }

    }
}