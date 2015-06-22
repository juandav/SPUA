﻿using System;
using System.Collections.Generic;
using Quantux.JSON;
using System.Runtime.InteropServices;
using System.Windows.Forms;
//using Axzkemkeeper;
using zkemkeeper;

namespace BioActiveX
{
    /// <summary>
    ///   by @juanqtx
    /// </summary>
    [ComVisibleAttribute(true)]
    [Guid("50285274-B47E-457B-A781-176F87229087")]
    [ProgId("BioActiveX.Control")]
    public class Control
    {
        #region
        ////////***********VARIABLES*************//////////
        public int tarjeta { get; set; }
        public int huella { get; set; }
        public int usuario { get; set; }
        public bool conexion { get; set; }
        #endregion


        /// <summary>
        ///    Objeto que instancia al dispositivo biometrico
        /// </summary>
        private CZKEM lectorObject = new CZKEM();

        /// <summary>
        ///     Función de prueba para verificar la conexión del control ActiveX
        /// </summary>
        /// <param name="texto">Texto JavaScript</param>
        /// <returns>Texto del dll concatenado con el de JavaScript</returns>
        public string TextoPrueba(string texto)
        {
            return "El Texto Prueba concatenado con: " + texto + " de JavaScript";
        }

        /// <summary>
        ///    Permite conectar con una terminal:
        ///      1. Lector Biometrico
        ///      2. Lector RFID
        ///      3. Camara 
        /// </summary>
        /// <param name="ip">
        ///     La ip de la terminal a conectar
        /// </param>
        /// <param name="puerto">
        ///     Puerto por donde transmite la información
        /// </param>
        /// <param name="tipo">
        ///     tipo de terminal ya sea:
        ///      1. (Biometrico)
        ///      2. (RFID)
        ///      3. (Camara)
        /// </param>
        public void ConectarConTerminal(string ip, string puerto, string tipo)
        {

            if (tipo == "Biometrico")
            {
                #region
                /// <summary>
                ///     Connect_Net: Permite conectar con el dispositivo a través de la dirección IP y configurar una conexión de red con el dispositivo.
                /// </summary>
                /// <param name="IPAdd">
                ///      Ip del dispositivo
                /// </param>
                /// <param name="Port">
                ///      Puerto usado para conectar con el dispositivo. El puerto por defecto es el 4370.
                /// </param>
                /// <returns>
                ///      Deevuelve True o False. Verificando si el dispositivo pudo conectarse o no.
                /// </returns>
                #endregion
                bool existeConexionBiometrico = lectorObject.Connect_Net(ip, Convert.ToInt32(puerto));

                if (existeConexionBiometrico == true)
                {
                    conexion = true;

                    /// <summary>
                    ///     RegEvent: Permite registrar los eventos en tiempo real.
                    /// </summary>
                    /// <param name="dwMachineNumber">Número de dispositivos</param>
                    /// <param name="EventMask">Código de un evento. Los valores son los siguientes:
                    ///     1. (1):     OnAttTransaction, OnAttTransactionEx  (Este evento se desencadena después de la verificación tiene éxito.)
                    ///     2. (2):     OnFinger (Este evento se activa cuando una huella dactilar se coloca sobre el sensor de huellas digitales del dispositivo. No se devuelve ningún valor.)
                    ///     3. (4):     OnNewUser (Este evento se activa cuando un nuevo usuario se inscribió con éxito.)
                    ///     4. (8):     OnEnrollFinger (Este evento se activa Cuando Se ha Registrado Una Huella digital.)
                    ///     5. (16):    OnKeyPress (No existe documentación para la función)
                    ///     6. (256):   OnVerify (Este evento se activa cuando se verifica un usuario)
                    ///     7. (512):   OnFingerFeature (Este evento se activa cuando un usuario coloca un dedo y el dispositivo registra la huella dactilar.)
                    ///     8. (1024):  OnDoor (Este evento se activa cuando el dispositivo se abre la puerta.), 
                    ///                 OnAlarm (Este evento se activa cuando el dispositivo informa de una alarma.) 
                    ///     9. (2048):  OnHIDNum (Este evento se activa cuando se pasa una tarjeta.) 
                    ///     10.(4096):  OnWriteCard (Este evento se activa cuando el dispositivo registra una carta.)
                    ///     11.(8192):  OnEmptyCard (Este evento se activa cuando una tarjera esta vacia o sin codigo asignado.)
                    ///     12.(16384): OnDeleteTemplate (No existe documentación para la función.)
                    ///     13.(65535): Para registrar todos los eventos.
                    /// </param>
                    /// <returns>
                    ///    Devuelve True o False: Dependiendo si tiene exito en registrar los eventos u ocurre errores.
                    /// </returns>
                    bool existenEventos = lectorObject.RegEvent(1, 65535);

                    if (existenEventos == true)
                    {
                        lectorObject.OnVerify += new _IZKEMEvents_OnVerifyEventHandler(ObtenerUsuarioEvent);
                        lectorObject.OnHIDNum += new _IZKEMEvents_OnHIDNumEventHandler(ObtenerTarjetaEvent);
                        lectorObject.OnFinger += new _IZKEMEvents_OnFingerEventHandler(ObtenerHuellaEvent);
                    }
                    else
                    {
                        //Muestre un mensaje que no se puede registrar los eventos.
                    }
                }
                else
                {
                    //Muestre un Mensaje de que no se puede conectar con el dispositivo.
                }
            }
        }

        #region EVENTOS
        ///////// *********EVENTOS**********/////////

        private void ObtenerUsuarioEvent(int usuario)
        {
            this.usuario = usuario;
            MessageBox.Show("El usuario es: " + usuario, "EXTITO");
        }

        private void ObtenerTarjetaEvent(int tarjeta)
        {
            this.tarjeta = tarjeta;
            MessageBox.Show("Entro en la tarjeta: " + tarjeta, "EXTITO");
        }

        private void ObtenerHuellaEvent()
        {
            MessageBox.Show("Entro en el evento de captura de huella.", "EXTITO");
            /// Puedo validar si la huella en el dispositivo corresponde a la que hay en base de datos.
        }
        #endregion

        #region CONSULTAS AL DISPOSITIVO

        /// <summary>
        ///    Carga los usuarios del dispositivo
        /// </summary>
        /// <param name="dispositivo">
        ///   Numero del dispositivo
        /// </param>
        /// <param name="usuario">
        ///   Codigo del usuario
        /// </param>
        /// <param name="nombre">
        ///   Nombre del usuario
        /// </param>
        /// <param name="pass">  
        ///   Contraseña del usuario
        /// </param>
        /// <param name="permiso">
        ///    permisos del usuario:
        ///    1. (3): Super Administrador
        ///    2. (0): Usuario Comun
        /// </param>
        /// <param name="habilitado"></param>
        /// <returns>
        ///   JSON
        /// </returns> 
        public string CargarUsuariosDelTerminalEnCliente(int dispositivo = 1, string usuario = "", string nombre = "", string pass = "", int permiso = 0, bool habilitado = false)
        {
            if (conexion == true)
            {
                List<Usuario> usuarios = new List<Usuario>();

                while (lectorObject.SSR_GetAllUserInfo(dispositivo, out usuario, out nombre, out pass, out permiso, out habilitado))// Obtiene toda la información de los usuarios en memoria.
                {
                    usuarios.Add(new Usuario
                    {
                        ID = usuario,
                        Nombre = nombre,
                        Pass = pass,
                        Permiso = permiso,
                        Habilitado = habilitado
                    });
                }
                return usuarios.ToJSON();
            }
            return "Mensaje: Error al conectar con dispositivo".ToJSON();
        }

        #endregion
    }


    public class Usuario
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public int Permiso { get; set; }
        public bool Habilitado { get; set; }
    }
}
