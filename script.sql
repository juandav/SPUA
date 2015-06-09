DROP TABLE AUTORIZACION;
CREATE TABLE AUTORIZACION (PEGE_ID NUMBER(30) NOT NULL, VEHI_ID NUMBER(30) NOT NULL, AUTO_REGISTRADOPOR VARCHAR2(30) NOT NULL, AUTO_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, AUTO_TIPO VARCHAR2(30), CONSTRAINT PK_AUTORIZACION PRIMARY KEY (PEGE_ID, VEHI_ID));
COMMENT ON TABLE AUTORIZACION IS 'Es la autorizacion que se le hace a una persona frente a un vehiculo para el ingreso y salida a la Uniamazonia';
COMMENT ON COLUMN AUTORIZACION.PEGE_ID IS 'Codigo de la persona; este lo representa en CHAIRA';
COMMENT ON COLUMN AUTORIZACION.VEHI_ID IS 'Vehiculo asociado a la persona';
COMMENT ON COLUMN AUTORIZACION.AUTO_REGISTRADOPOR IS 'Campo de auditoria';
COMMENT ON COLUMN AUTORIZACION.AUTO_FECHACAMBIO IS 'Campo de auditoria';
COMMENT ON COLUMN AUTORIZACION.AUTO_TIPO IS 'Campo que identifica si es una autorizacion como PROPIETARIO, FAMILIAR o como  OTRO';
INSERT INTO AUTORIZACION (PEGE_ID, VEHI_ID, AUTO_REGISTRADOPOR, AUTO_FECHACAMBIO, AUTO_TIPO) VALUES (53322, 1, 'SYS', TIMESTAMP '2015-03-20 10:47:29', 'PROPIETARIO');
INSERT INTO AUTORIZACION (PEGE_ID, VEHI_ID, AUTO_REGISTRADOPOR, AUTO_FECHACAMBIO, AUTO_TIPO) VALUES (45899, 2, 'SYS', TIMESTAMP '2015-03-20 10:51:42', 'PROPIETARIO');
INSERT INTO AUTORIZACION (PEGE_ID, VEHI_ID, AUTO_REGISTRADOPOR, AUTO_FECHACAMBIO, AUTO_TIPO) VALUES (45899, 1, 'SYS', TIMESTAMP '2015-03-20 10:51:56', 'PARTICULAR');
DROP TABLE ETIQUETA;
CREATE TABLE ETIQUETA (ETIQ_ID NUMBER(30) NOT NULL, ETIQ_TIPO VARCHAR2(30) NOT NULL, ETIQ_CODIGO VARCHAR2(30) NOT NULL, ETIQ_ESTADO VARCHAR2(30) NOT NULL, ETIQ_REGISTRADOPOR VARCHAR2(30) NOT NULL, ETIQ_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_ETIQUETA PRIMARY KEY (ETIQ_ID), CONSTRAINT UC_ETIQUETA UNIQUE (ETIQ_TIPO, ETIQ_CODIGO));
COMMENT ON TABLE ETIQUETA IS 'La equeta es la representacion logica de un tag o una tarjeta de proximidad.';
COMMENT ON COLUMN ETIQUETA.ETIQ_ID IS 'LLave Primaria';
COMMENT ON COLUMN ETIQUETA.ETIQ_TIPO IS 'Determina si la Etiqueta es un Tag para RFID de ultra alta frecuenccia o si es una Tarjeta de proximidad para RFID de baja frecuencia';
COMMENT ON COLUMN ETIQUETA.ETIQ_CODIGO IS 'Codigo unico del elemento etiqueta asignado por la terminal o dispositivo que registre la tupla';
COMMENT ON COLUMN ETIQUETA.ETIQ_ESTADO IS 'La etiqueta puede presentar dos estados 1. Activo. o 2. Inactivo.';
COMMENT ON COLUMN ETIQUETA.ETIQ_REGISTRADOPOR IS 'Campo Auditoria';
COMMENT ON COLUMN ETIQUETA.ETIQ_FECHACAMBIO IS 'Campo Auditoria';
INSERT INTO ETIQUETA (ETIQ_ID, ETIQ_TIPO, ETIQ_CODIGO, ETIQ_ESTADO, ETIQ_REGISTRADOPOR, ETIQ_FECHACAMBIO) VALUES (1, 'TARJETA', '21231', 'ACTIVO', '123123', TIMESTAMP '2015-06-09 00:25:52');
DROP TABLE HUELLA;
CREATE TABLE HUELLA (HUEL_ID NUMBER(30) NOT NULL, PEGE_ID NUMBER(30) NOT NULL, HUEL_CODIGO VARCHAR2(30), HUEL_REGISTRADOPOR VARCHAR2(30), HUEL_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, HUELL_HUELLA CLOB, HUEL_CODIGODEDO NUMBER(30), HUELL_PLANTILLA NUMBER(30), HELL_BANDERA NUMBER(30), CONSTRAINT PK_HUELLA PRIMARY KEY (HUEL_ID), CONSTRAINT UC_HUELLA UNIQUE (HUEL_CODIGO));
INSERT INTO HUELLA (HUEL_ID, PEGE_ID, HUEL_CODIGO, HUEL_REGISTRADOPOR, HUEL_FECHACAMBIO, HUELL_HUELLA, HUEL_CODIGODEDO, HUELL_PLANTILLA, HELL_BANDERA) VALUES (1, 45899, '123', '53233', TIMESTAMP '2015-06-09 00:13:28', 'WEAWEAWEAEAWEAW', 234234, 324234, 24344);
DROP TABLE MOVIMIENTOVEHICULO;
CREATE TABLE MOVIMIENTOVEHICULO (MOVE_ID NUMBER(30) NOT NULL, PEGE_ID NUMBER(30) NOT NULL, VEHI_ID NUMBER(30) NOT NULL, MOVE_TIPO VARCHAR2(30) NOT NULL, MOVE_FECHA DATE NOT NULL, MOVE_REGISTRADOPOR VARCHAR2(30) NOT NULL, MOVE_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_MOVIMIENTOVEHICULO PRIMARY KEY (MOVE_ID));
DROP TABLE TERMINAL;
CREATE TABLE TERMINAL (TERM_ID NUMBER(30) NOT NULL, TERM_TIPO VARCHAR2(30) NOT NULL, TERM_IP VARCHAR2(15) NOT NULL, TERM_PUERTO VARCHAR2(4) NOT NULL, TERM_REGISTRADOPOR VARCHAR2(30) NOT NULL, TERM_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, TERM_DESCRIPCION CLOB, TERM_ESTADO VARCHAR2(30) DEFAULT 'ACTIVO'   NOT NULL, CONSTRAINT PK_TERMINAL PRIMARY KEY (TERM_ID), CONSTRAINT UC_TERM_IP UNIQUE (TERM_IP));
COMMENT ON TABLE TERMINAL IS 'Terminales; estas determinan la ubicacion de cada uno de los dispositivos';
COMMENT ON COLUMN TERMINAL.TERM_ID IS 'Codigo del Dispositivo';
COMMENT ON COLUMN TERMINAL.TERM_TIPO IS 'Determina que dispositivo es; ejemplo: si es un biometrico o un RFID';
COMMENT ON COLUMN TERMINAL.TERM_IP IS 'Direccion Logica del Dispositivo';
COMMENT ON COLUMN TERMINAL.TERM_PUERTO IS 'Puerto destinado a cada uno de los dispositivos';
COMMENT ON COLUMN TERMINAL.TERM_REGISTRADOPOR IS 'Campo de Auditoria';
COMMENT ON COLUMN TERMINAL.TERM_FECHACAMBIO IS 'Campo de Auditoria';
COMMENT ON COLUMN TERMINAL.TERM_DESCRIPCION IS 'Breve descripcion del dispositivo';
INSERT INTO TERMINAL (TERM_ID, TERM_TIPO, TERM_IP, TERM_PUERTO, TERM_REGISTRADOPOR, TERM_FECHACAMBIO, TERM_DESCRIPCION, TERM_ESTADO) VALUES (1, 'BIOMETRICO', '192.168.1.20', '8080', '1234', TIMESTAMP '2015-03-21 12:17:01', 'DISPOSITIVO DE DESARROLLO', 'ACTIVO');
DROP TABLE TERMINALETIQUETA;
CREATE TABLE TERMINALETIQUETA (TERM_ID NUMBER(30) NOT NULL, ETIQ_ID NUMBER(30) NOT NULL, TEET_REGISTRADOPOR VARCHAR2(30) NOT NULL, TEET_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_TERMINALETIQUETA PRIMARY KEY (TERM_ID, ETIQ_ID));
DROP TABLE TERMINALHUELLA;
CREATE TABLE TERMINALHUELLA (TERM_ID NUMBER(30) NOT NULL, HUEL_ID NUMBER(30) NOT NULL, TEHU_REGISTRADOPOR VARCHAR2(30) NOT NULL, TEHU_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_TERMINALHUELLA PRIMARY KEY (TERM_ID, HUEL_ID));
DROP TABLE USUARIO;
CREATE TABLE USUARIO (PEGE_ID NUMBER(30) NOT NULL, USUA_NOMBRE VARCHAR2(50) NOT NULL, USUA_PROGRAMA VARCHAR2(50) NOT NULL, USUA_SITUACION VARCHAR2(30) NOT NULL, USUA_DOCUMENTO VARCHAR2(30) NOT NULL, USUA_CODIGOUDLA VARCHAR2(30) NOT NULL, USUA_PASS VARCHAR2(30), USUA_USUARIO VARCHAR2(30), USUA_TIPO VARCHAR2(30), CONSTRAINT PK_USUARIO PRIMARY KEY (PEGE_ID));
INSERT INTO USUARIO (PEGE_ID, USUA_NOMBRE, USUA_PROGRAMA, USUA_SITUACION, USUA_DOCUMENTO, USUA_CODIGOUDLA, USUA_PASS, USUA_USUARIO, USUA_TIPO) VALUES (53322, 'Juan David Echeverry Rivera', 'Ingenieria de Sistemas', 'ACTIVO', '1094905443', '172005314', '1234', 'JUAN', 'ADMINISTRADOR');
INSERT INTO USUARIO (PEGE_ID, USUA_NOMBRE, USUA_PROGRAMA, USUA_SITUACION, USUA_DOCUMENTO, USUA_CODIGOUDLA, USUA_PASS, USUA_USUARIO, USUA_TIPO) VALUES (45899, 'PEPITO PEREZ', 'Ingenieria de Sistemas', 'ACTIVO', '1117513159', '172005313', '4321', 'OSWALDO', 'DOCENTE');
INSERT INTO USUARIO (PEGE_ID, USUA_NOMBRE, USUA_PROGRAMA, USUA_SITUACION, USUA_DOCUMENTO, USUA_CODIGOUDLA, USUA_PASS, USUA_USUARIO, USUA_TIPO) VALUES (35637, 'PRUEBA', 'PRUEBA', 'ACTIVO', '1243242423', '312434324', '1234', 'PRUEBA', 'FUNCIONARIO');
DROP TABLE USUARIOTARJETA;
CREATE TABLE USUARIOTARJETA (PEGE_ID NUMBER(30) NOT NULL, ETIQ_ID NUMBER(30) NOT NULL, USTA_REGISTRADOPOR VARCHAR2(30) NOT NULL, USTA_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_USUARIOTARJETA PRIMARY KEY (PEGE_ID, ETIQ_ID));
INSERT INTO USUARIOTARJETA (PEGE_ID, ETIQ_ID, USTA_REGISTRADOPOR, USTA_FECHACAMBIO) VALUES (45899, 1, '2312', TIMESTAMP '2015-06-09 00:26:22');
DROP TABLE VEHICULO;
CREATE TABLE VEHICULO (VEHI_ID NUMBER(30) NOT NULL, VEHI_PLACA VARCHAR2(30) NOT NULL, VEHI_MODELO VARCHAR2(30) NOT NULL, VEHI_MARCA VARCHAR2(30) NOT NULL, VEHI_TIPO VARCHAR2(30) NOT NULL, VEHI_REGISTRADOPOR VARCHAR2(30) NOT NULL, VEHI_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_VEHICULO PRIMARY KEY (VEHI_ID));
COMMENT ON TABLE VEHICULO IS 'Vehiculos que se encuentran en la Uniamazonia';
COMMENT ON COLUMN VEHICULO.VEHI_ID IS 'Codigo del Vehiculo';
COMMENT ON COLUMN VEHICULO.VEHI_PLACA IS 'Placa del Vehiculo';
COMMENT ON COLUMN VEHICULO.VEHI_MODELO IS 'Modelo del vehiculo ejemplo: Modelo 2014, Modelo 2015';
COMMENT ON COLUMN VEHICULO.VEHI_MARCA IS 'Marca del Vehiculo. Ejemplo: MAZDA, CHEVROLET, CHAIRA';
COMMENT ON COLUMN VEHICULO.VEHI_TIPO IS 'Determina el Tipo de vehiculo si es un carro peque�o o Grande o si es una Moto etc.';
COMMENT ON COLUMN VEHICULO.VEHI_REGISTRADOPOR IS 'Campo de Auditoria';
COMMENT ON COLUMN VEHICULO.VEHI_FECHACAMBIO IS 'Campo de Auditoria';
INSERT INTO VEHICULO (VEHI_ID, VEHI_PLACA, VEHI_MODELO, VEHI_MARCA, VEHI_TIPO, VEHI_REGISTRADOPOR, VEHI_FECHACAMBIO) VALUES (1, 'FGT567', '2015', 'MAZDA', 'CARROPEQUENIO', 'SYS', TIMESTAMP '2015-03-20 10:45:56');
INSERT INTO VEHICULO (VEHI_ID, VEHI_PLACA, VEHI_MODELO, VEHI_MARCA, VEHI_TIPO, VEHI_REGISTRADOPOR, VEHI_FECHACAMBIO) VALUES (2, 'FKI987', '2015', 'CHEVROLET', 'CARROPEQUENIO', 'SYS', TIMESTAMP '2015-03-20 10:46:32');
DROP TABLE VEHICULOTAG;
CREATE TABLE VEHICULOTAG (ETIQ_ID NUMBER(30) NOT NULL, VEHI_ID NUMBER(30) NOT NULL, VETA_REGISTRADOPOR VARCHAR2(30) NOT NULL, VETA_FECHACAMBIO DATE DEFAULT SYSDATE  NOT NULL, CONSTRAINT PK_VEHICULOTAG PRIMARY KEY (ETIQ_ID, VEHI_ID));
ALTER TABLE AUTORIZACION ADD CONSTRAINT FK_PER_AUTO FOREIGN KEY (PEGE_ID) REFERENCES USUARIO (PEGE_ID);
ALTER TABLE AUTORIZACION ADD CONSTRAINT FK_VEHI_AUTO FOREIGN KEY (VEHI_ID) REFERENCES VEHICULO (VEHI_ID);
ALTER TABLE AUTORIZACION ADD CONSTRAINT CK_AUTO_TIPO CHECK (AUTO_TIPO IN ('PROPIETARIO', 'FAMILIAR', 'PARTICULAR'));
ALTER TABLE ETIQUETA ADD CONSTRAINT CC_ETIQ_TIPO CHECK (ETIQ_TIPO IN ('TAG', 'TARJETA'));
ALTER TABLE ETIQUETA ADD CONSTRAINT CC_ETIQ_ESTADO CHECK (ETIQ_ESTADO IN ('ACTIVO', 'INACTIVO'));
ALTER TABLE HUELLA ADD CONSTRAINT FK_HUEL_PERS FOREIGN KEY (PEGE_ID) REFERENCES USUARIO (PEGE_ID);
ALTER TABLE MOVIMIENTOVEHICULO ADD CONSTRAINT FK_MOVE_PERS_VEHI FOREIGN KEY (PEGE_ID, VEHI_ID) REFERENCES AUTORIZACION (PEGE_ID, VEHI_ID);
ALTER TABLE TERMINAL ADD CONSTRAINT CC_TERM_ESTADO CHECK (TERM_ESTADO IN ('ACTIVO','INACTIVO'));
ALTER TABLE TERMINAL ADD CONSTRAINT CC_TERM_TIPO CHECK (TERM_TIPO IN ('BIOMETRICO','RFID'));
ALTER TABLE TERMINALETIQUETA ADD CONSTRAINT FK_TEET_ETIQ FOREIGN KEY (ETIQ_ID) REFERENCES ETIQUETA (ETIQ_ID);
ALTER TABLE TERMINALETIQUETA ADD CONSTRAINT FK_TEET_TERM FOREIGN KEY (TERM_ID) REFERENCES TERMINAL (TERM_ID);
ALTER TABLE TERMINALHUELLA ADD CONSTRAINT FK_TEHU_HUEL FOREIGN KEY (HUEL_ID) REFERENCES HUELLA (HUEL_ID);
ALTER TABLE TERMINALHUELLA ADD CONSTRAINT FK_TEHU_TERM FOREIGN KEY (TERM_ID) REFERENCES TERMINAL (TERM_ID);
ALTER TABLE USUARIO ADD CONSTRAINT CC_USUATIPO CHECK (USUA_TIPO IN ('ADMINISTRADOR','DOCENTE', 'ESTUDIANTE', 'FUNCIONARIO'));
ALTER TABLE USUARIOTARJETA ADD CONSTRAINT FK_USTA_ETIQ FOREIGN KEY (ETIQ_ID) REFERENCES ETIQUETA (ETIQ_ID);
ALTER TABLE USUARIOTARJETA ADD CONSTRAINT FK_USTA_PERS FOREIGN KEY (PEGE_ID) REFERENCES USUARIO (PEGE_ID);
ALTER TABLE VEHICULO ADD CONSTRAINT CC_VEHI CHECK (VEHI_TIPO IN ('MOTO', 'CARROPEQUENIO', 'CARROGRANDE'));
ALTER TABLE VEHICULOTAG ADD CONSTRAINT FK_VETA_ETIQ FOREIGN KEY (ETIQ_ID) REFERENCES ETIQUETA (ETIQ_ID);
ALTER TABLE VEHICULOTAG ADD CONSTRAINT FK_VETA_VEHI FOREIGN KEY (VEHI_ID) REFERENCES VEHICULO (VEHI_ID);