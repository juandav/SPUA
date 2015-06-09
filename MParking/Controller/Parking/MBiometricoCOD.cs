using System.Data;
using MParking.Model.Parking;

namespace MParking.Controller.Parking
{
    public class MBiometricoCOD
    {

        private UsuarioOAD usuarioObject = new UsuarioOAD();
        private VehiculoOAD vehiculoOvject = new VehiculoOAD();
        private HuellaOAD huellaObject = new HuellaOAD();
        private EtiquetaOAD etiquetaObject = new EtiquetaOAD();

        //////// VISTA LOGON///////
        public DataTable consultarLogon(string usuario, string pass)
        {
            return usuarioObject.consultarUsuaroParaLogon(usuario, pass);
        }

        ///////////////////////////

        ///////////////VISTA DE REGISTRO///////////////////


        //////////MODULO REGISTROS///////////

        public DataTable consultarUsuarios()
        {
            return usuarioObject.consultarUsuarios();
        }

        public DataTable consultarHuellas(string pegeId)
        {
            return huellaObject.consultarHuellasDeUnPege(pegeId);
        }

        public DataTable consultarTarjetas(string pegeId) {
            return etiquetaObject.consultarTarjetas(pegeId);
        }

        public string registrarUsuario() {
            return "";
        }

 






        //OTRO MODULO
        public DataTable consultarVehiculosDisponibles(string pegeId) {
            return vehiculoOvject.consultarVehiculosDisponibles(pegeId);
        }
    }
}