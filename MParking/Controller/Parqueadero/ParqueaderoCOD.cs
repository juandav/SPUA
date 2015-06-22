using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MParking.Model.Parking;

namespace MParking.Controller.Parqueadero
{
    public class ParqueaderoCOD
    {

        #region Objetos
        private TerminalOAD terminalObject = new TerminalOAD();
        #endregion

        #region Terminales

        public DataTable consultarTerminales() {
            return terminalObject.consultarTerminales();
        }

        
        #endregion

    }
}