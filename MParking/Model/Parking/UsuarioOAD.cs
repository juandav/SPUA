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

        public DataTable consultarUsuario()
        {
            string sql = "";
            return conObject.consultarDatos(sql);
        }
    }
}