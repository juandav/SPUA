using System;
using System.Data;
using Ext.Net;
using MParking.Controller.Parqueadero;

namespace MParking.View.Private.Parqueadero
{
    public partial class Terminal : System.Web.UI.Page
    {

        private string pegeId = "";

        private ParqueaderoCOD parqueaderoObject = new ParqueaderoCOD();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CargarTerminales();
            }
        }

        [DirectMethod]
        public void CargarTerminales() {
            DataTable terminales = parqueaderoObject.consultarTerminales();
            STERMINAL.DataSource = terminales;
            STERMINAL.DataBind();
        }

        /// <summary>
        ///   Los datos de la terminal cliente se cargan desde el cliente mediante una dll para extraer los datos del dispositivo.
        /// </summary>
        [DirectMethod]
        public void CargarUsuariosDelTerminalEnServidor() {
            DataTable usuarios = null;
        }

    }
}