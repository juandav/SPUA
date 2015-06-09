using System.Data;
using MParking.Model.Parking;

namespace MParking.Controller.Parking
{
    public class MBiometricoCOD
    {

        private UsuarioOAD usuarioObject = new UsuarioOAD();
        private VehiculoOAD vehiculoOvject = new VehiculoOAD();

        // Permite entrar al sistema
        public DataTable consultarLogon(string usuario, string pass)
        {
            return usuarioObject.consultarUsuaroParaLogon(usuario, pass);
        }

        public string registrarUsuario() {
            return "";
        }

        public DataTable consultarUsuarios() {
            return usuarioObject.consultarUsuarios();
        }

        public DataTable consultarVehiculosDisponibles(string pegeId) {
            return vehiculoOvject.consultarVehiculosDisponibles(pegeId);
        }
    }
}