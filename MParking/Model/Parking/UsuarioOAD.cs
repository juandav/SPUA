using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class UsuarioOAD
    {

        private ConexionOracle conObject = new ConexionOracle();

        public DataTable consultarUsuaroParaLogon(string usuario, string pass) {
             string sql = "SELECT"
                        + "     U.*"
                        + " FROM"
                        + "     PARKING.USUARIO U"
                        + " WHERE"
                        + "     USUA_USUARIO = '" + usuario + "'"
                        + " AND"
                        + "     USUA_PASS='" + pass + "'";
            return conObject.consultarDatos(sql);
        }

        public DataTable consultarUsuarios() {
            string sql = "SELECT"
                        + "     U.PEGE_ID,"
                        + "     U.USUA_CODIGOUDLA AS CODIGOUDLA,"
                        + "     U.USUA_DOCUMENTO  AS DOCUMENTO,"
                        + "     U.USUA_NOMBRE     AS PERSONA"
                        + " FROM"
                        + "     PARKING.USUARIO U"
                        + " WHERE"
                        + "     U.USUA_TIPO IN ('DOCENTE','FUNCIONARIO')";
            return conObject.consultarDatos(sql);
        }

        public DataTable consultarUsuariosQueTenganHuellaYOTarjeta()
        {
            string sql = "SELECT"
                        + "     U.PEGE_ID,"
                        + "     U.USUA_DOCUMENTO AS DOCUMENTO,"
                        + "     U.USUA_CODIGOUDLA AS CARNET,"
                        + "     U.USUA_NOMBRE AS PERSONA,"
                        + "     U.USUA_PROGRAMA AS PROGRAMA,"
                        + "     CASE"
                        + "         WHEN H.HUEL_ID IS NULL"
                        + "         THEN 'Sin Asignar'"
                        + "         ELSE 'Asignada'"
                        + "     END AS HUELLA,"
                        + "     CASE"
                        + "         WHEN UT.ETIQ_ID IS NULL"
                        + "         THEN 'Sin Asignar'"
                        + "         ELSE 'Asignada'"
                        + "     END AS TARJETA"
                        + " FROM"
                        + "     " + Global.SCHEMA_PARKING + ".USUARIO U"
                        + " LEFT JOIN " + Global.SCHEMA_PARKING + ".HUELLA H          ON (U.PEGE_ID=H.PEGE_ID)"
                        + " LEFT JOIN " + Global.SCHEMA_PARKING + ".USUARIOTARJETA UT ON (U.PEGE_ID=UT.PEGE_ID)"
                        + " LEFT JOIN " + Global.SCHEMA_PARKING + ".ETIQUETA E        ON (UT.ETIQ_ID=E.ETIQ_ID"
                        + "     AND E.ETIQ_TIPO='TARJETA'"
                        + "     AND E.ETIQ_ESTADO='ACTIVO')";
            return conObject.consultarDatos(sql);
        }
    }
}