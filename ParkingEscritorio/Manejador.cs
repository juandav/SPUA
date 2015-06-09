using System.Windows.Forms;

namespace ParkingEscritorio
{
    public partial class Manejador : Form
    {
        public Manejador()
        {
            //InitializeComponent();t
            Enabled = false;
            Visible = false;
            Logon logonObject = new Logon();
            logonObject.Show();
        }
    }
}
