using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using MParking.Controller.Parking;

namespace MParking.View.Private.Parking.MBiometrico
{
    public partial class MBiometrico : System.Web.UI.Page
    {

        private MBiometricoCOD biometricoObject = new MBiometricoCOD();

        ///  ROL:PROPIETARIO; Puede autorizar los vehiculos que alguien mas puede sacar de la institución.
        ///  ROL:PARTICULAR; Solo puede consultar los vehiculos que tiene asociado. 
        ///  ROL:FAMILIAR; Puede consultar los vehiculos asociados.
        ///  
        ///  ROL: ADMINISTRADORBIOMETRICO; ASIGNA TAGS A LOS VEHICULOS, CREA LOS VEHICULOS, CREA TAGS, REPORTES.
        ///  
        /// 
        private string pegeId = "53233";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){
                cargarUsuarios();
            }
        }

        [DirectMethod]
        public void cargarUsuarios() {
            SUSUARIO.DataSource = biometricoObject.consultarUsuarios();
            SUSUARIO.DataBind();
        }

        [DirectMethod]
        public void cargarVehiculosDisponibles(string pegeId) {
            SVEHICULO.DataSource = biometricoObject.consultarVehiculosDisponibles(pegeId);
            SVEHICULO.DataBind();
        }

        public void cargarVehiculosAutorizados() { }

        protected void recargarUsuarios(object sender, StoreRefreshDataEventArgs e)
        {
            cargarUsuarios();
        }

        protected void recargarVehiculoDisponible(object sender, StoreRefreshDataEventArgs e)
        {
           // cargarVehiculos();
        }

        protected void recargarVehiculoAutorizado(object sender, StoreRefreshDataEventArgs e)
        {
            // cargarVehiculos();
        }
    }
}