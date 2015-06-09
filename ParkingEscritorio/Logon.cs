using System;
using System.Data;
using System.Windows.Forms;
using MParking.Controller.Parking;
using MetroFramework.Forms;

namespace ParkingEscritorio
{
    public partial class Logon : MetroForm
    {

        private MBiometricoCOD biometricoObject = new MBiometricoCOD();

        public Logon()
        {
            InitializeComponent();
        }

        public void inciarParking(object sender, EventArgs e)
        {
            string usuario = MTBUSUARIO.Text;
            string pass = MTBPASS.Text;
            DataTable usuarioLogon = biometricoObject.consultarLogon(usuario, pass);
            if (usuario != "" && pass != "")
            {
                if (usuarioLogon.Rows.Count > 0)
                {
                    if (usuarioLogon.Rows[0]["USUA_TIPO"].ToString() == "ADMINISTRADOR")
                    {
                        this.Close();
                        Escritorio escritorioObject = new Escritorio();
                        escritorioObject.Show();
                    }
                    else
                    {
                        MessageBox.Show("el usuario no tiene permisos suficientes para ingresar al sistema.", "Notificación");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña no coinciden", "Notificación");
                }
            }
            else {
                MessageBox.Show("Existen campos vacios.", "Notificación");
            }
            

        }

        public void destruirParking(object sender, EventArgs e)
        {

        }

        public void registroParking(object sender, EventArgs e)
        {

        }
    }
}
