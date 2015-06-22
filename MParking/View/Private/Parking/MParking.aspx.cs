using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using MParking.Controller.Parking;
using zkemkeeper;
using Biometrico;
//using Axzkemkeeper;
using System.Windows.Forms;

namespace MParking.View.Private.Parking
{
    public partial class MParking : System.Web.UI.Page
    {

        private MBiometricoCOD biometricoObject = new MBiometricoCOD();
        private CZKEM lectorBiometricoObject = new CZKEM();

        int usuaTarjeta = 0;
        int tarjeta = 0;

        //string cIPFrom = "192.168.1.201";
        //int cPortFrom = 4370;
        //int gbMachineNumberFrom = 10;
        //string gbEnrollNumberFrom = "12345";
        //int gbFingerIndexFrom = 0;

        //string cIPTo = "192.168.1.201";
        //int cPortTo = 4370;
        //int gbMachineNumberTo = 10;
        //string gbEnrollNumberTo = "12345";
        //int gbFingerIndexTo = 0;
        //string gbTmpData = "";
        //string strCommand = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(conectar));
            t1.Start();
            t1.Join();

            
            //System.Threading.ThreadStart mtThreadStart = new System.Threading.ThreadStart(CallMeThread);
            ////System.Action myAction = new Action(CallMeThread);
            //System.Threading.Thread myThred = new System.Threading.Thread(mtThreadStart);
            ////System.Threading.Thread(myAction);
            ////myThred.RunSynchronously();   
            //myThred.SetApartmentState(System.Threading.ApartmentState.STA);
            ////myThred.Join();
            //myThred.Start();
        }

        //private void CallMeThread()
        //{

        //    AxCZKEM activeXagent = new AxCZKEM();
        //    Form myForm = new Form();
        //    //myForm.Controls.SkinAllThreads();
        //    myForm.Controls.Add(activeXagent);
        //    myForm.CreateControl();
        //    Connect(activeXagent, "Connect", cIPFrom, cPortFrom);
                   
        //}


        //private void Connect(AxCZKEM activeXagent, string strConnect, string cIP, int cPort)
        //{
        //    //var boolResult = activeXagent.Connect_Net(cIP, cPort);
        //    var conexionLectorBiometrico = activeXagent.Connect_Net("192.168.1.201", Convert.ToInt32("4370"));
        //    bool existeRegistroEvento = lectorBiometricoObject.RegEvent(1, 65535);

        //    if (existeRegistroEvento)
        //    {

        //        this.lectorBiometricoObject.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(validarTarjeta);
        //        this.lectorBiometricoObject.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(consultarNumeroTarjeta);
        //    }
        //    else
        //    {

        //        //MessageBox.Show("Ha ocurrido un error interno al intentar conectar con el dispositivo biometrico.", "Error: 1");
        //    }
        //}



        private void conectar()
        {
            var conexionLectorBiometrico = lectorBiometricoObject.Connect_Net("192.168.1.201", Convert.ToInt32("4370"));
            bool existeRegistroEvento = lectorBiometricoObject.RegEvent(1, 65535);

            if (existeRegistroEvento)
            {

                this.lectorBiometricoObject.OnVerify += new _IZKEMEvents_OnVerifyEventHandler(validarTarjeta);
                this.lectorBiometricoObject.OnHIDNum += new _IZKEMEvents_OnHIDNumEventHandler(consultarNumeroTarjeta);
            }
            else
            {

                //MessageBox.Show("Ha ocurrido un error interno al intentar conectar con el dispositivo biometrico.", "Error: 1");
            }
        }


        public void validarTarjeta(int usuarioId)
        {
            usuaTarjeta = usuarioId;
        }

        public void consultarNumeroTarjeta(int numeroTarjeta)
        {
            tarjeta = numeroTarjeta;
        }

    }
       
}