using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MParking.Model.Parking;

namespace MParking.Controller.Parking
{
    public class MBiometricoCOD
    {

        private UsuarioOAD usuarioObject = new UsuarioOAD();
        private VehiculoOAD vehiculoOvject = new VehiculoOAD();

        public DataTable consultarUsuarios() {
            return usuarioObject.consultarUsuarios();
        }

        public DataTable consultarVehiculosDisponibles(string pegeId) {
            return vehiculoOvject.consultarVehiculosDisponibles(pegeId);
        }
    }
}