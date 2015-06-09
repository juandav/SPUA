using System.Drawing;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Data;
using MParking.Controller.Parking;
using System;
using zkemkeeper;

namespace ParkingEscritorio
{
    public partial class Escritorio : MetroForm
    {

        private MBiometricoCOD biometricoObject = new MBiometricoCOD();
        private CZKEM lectorBiometricoObject = new CZKEM();

        // OBTENIDOS DEL EVENTO
        private int tarjeta = 0;
        private int usuaTarjeta = 0;

        public Escritorio()
        {
            InitializeComponent();
        }

        private void Escritorio_Load(object sender, System.EventArgs e)
        {
            cargarUsuarios();
        }

        public void cargarUsuarios() {
            DataTable usuarios = biometricoObject.consultarUsuarios();
            MGUSUARIO.DataSource = usuarios;
            MGUSUARIO.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            MGUSUARIO.AllowUserToAddRows = false;
        }

        private void cargarHuellaTarjeta(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = MGUSUARIO.Rows[e.RowIndex];
            string pegeId = Convert.ToString(fila.Cells["PEGE_ID"].Value);

            DataTable datosHuella = biometricoObject.consultarHuellas(pegeId);
            MGHUELLA.DataSource = datosHuella;
            MGHUELLA.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            MGHUELLA.AllowUserToAddRows = false;

            DataTable datosTarjeta = biometricoObject.consultarTarjetas(pegeId);
            MGTARJETA.DataSource = datosTarjeta;
            MGTARJETA.Font = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel);
            MGTARJETA.AllowUserToAddRows = false;
        }

        private void conectarTerminal(object sender, EventArgs e) {
            MessageBox.Show("Prueba en conexión", "Prueba");
        }

        //REGISTRAR HUELLA
        private void MBHUELLA_Click(object sender, EventArgs e) {

            if (conectar())
            {
                this.lectorBiometricoObject.OnVerify += new _IZKEMEvents_OnVerifyEventHandler(validarTarjeta);
                this.lectorBiometricoObject.OnHIDNum += new _IZKEMEvents_OnHIDNumEventHandler(consultarNumeroTarjeta);
            }
            else
            {
                MessageBox.Show("No se ha podido establecer conexion.", "Error");
            }
        }
        
        //REGISTRAR TARJETA
        private void MBTARJETA_Click(object sender, EventArgs e)
        {
            if (conectar())
            {
                this.lectorBiometricoObject.OnVerify += new _IZKEMEvents_OnVerifyEventHandler(validarTarjeta);
                this.lectorBiometricoObject.OnHIDNum += new _IZKEMEvents_OnHIDNumEventHandler(consultarNumeroTarjeta);
            }
            else {
                MessageBox.Show("No se ha podido establecer conexion.", "Error");
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


        public bool conectar()
        {
            var conexionLectorBiometrico = lectorBiometricoObject.Connect_Net("192.168.1.201", Convert.ToInt32("4370"));
            bool existeRegistroEvento = lectorBiometricoObject.RegEvent(1, 65535);

            if (existeRegistroEvento)
            {
                return true;
                //this.lectorBiometricoObject.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(validarTarjeta);
                //this.lectorBiometricoObject.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(consultarNumeroTarjeta);
                //MessageBox.Show("Dispositivo Conectado.", "Exito");
            }
            else
            {
                return false;
                //MessageBox.Show("Ha ocurrido un error interno al intentar conectar con el dispositivo biometrico.", "Error: 1");
            }
        }

        //EXCLUIDOS TEMPORALMENTE
        private void registrarHuella(object sender, MouseEventArgs e){}
        private void registrarTarjeta(object sender, MouseEventArgs e){}

        ////////////// METODOS BASURA ///////////////
        public void selecciono(object sender, System.EventArgs e){}
        private void MGUSUARIO_SizeChanged(object sender, System.EventArgs e){}
        private void selecciono(object sender, DataGridViewRowStateChangedEventArgs e){}
        private void ENTRO(object sender, DataGridViewCellEventArgs e){}

       
    }
}
