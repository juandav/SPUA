using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MParking.Conections;

namespace MParking.Model.Parking
{
    public class UsuarioOAD
    {

        private ConexionOracle conObject = new ConexionOracle();

        public DataTable consultarUsuarios() {
            string sql = "SELECT"
                        + "     U.PEGE_ID,"
                        + "     U.USUA_DOCUMENTO,"
                        + "     U.USUA_CODIGOUDLA,"
                        + "     U.USUA_NOMBRE,"
                        + "     U.USUA_PROGRAMA"
                        + " FROM"
                        + "     PARKING.USUARIO U";
            return conObject.consultarDatos(sql);
        }

        public DataTable consultarUsuario()
        {
            string sql = "";
            return conObject.consultarDatos(sql);
        }
    }
}