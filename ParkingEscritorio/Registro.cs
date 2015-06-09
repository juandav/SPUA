using System;
using MetroFramework.Forms;
using MParking.Controller.Parking;

namespace ParkingEscritorio
{
    public partial class Registro : MetroForm
    {

        private MBiometricoCOD biometricoObject = new MBiometricoCOD();

        public Registro()
        {
            InitializeComponent();
        }


        public void registrarUsuario(object sender, EventArgs e) {

        }
    }
}
