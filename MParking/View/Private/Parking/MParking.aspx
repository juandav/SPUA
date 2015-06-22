<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="MParking.aspx.cs" Inherits="MParking.View.Private.Parking.MParking" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modulo Paqueadero</title>
    <script type="text/javascript" src="../../../Content/js/MParking.js"></script>
    <link rel="stylesheet" href="../../../Content/css/MParking.css" type="text/css" />
</head>
<body>
    <ext:ResourceManager runat="server" />
    <form id="FMPARKING" runat="server">
        <div>
            <object id="BioActiveX" width="640px" height="480px" classid="clsid:FFB91231-64E9-460B-8C4B-C82F470C08ED" viewastext="">
                <p>
                    Este texto se mostrará si se abre la página con un browser no compatible o si el ActiveX no está instalado correctamente.            
                </p>
            </object>


            <ext:Viewport ID="VPGRTADMINISTRADOR" runat="server" Layout="border">
                <Items>
                    <ext:MenuPanel ID="MPSERVICIO" CtCls="west-panel" Icon="BookOpen" runat="server" Width="160" Region="West" Split="true" Frame="true" Title="Servcios">
                        <Menu ID="Menu1" runat="server">
                            <Items>

                                <ext:MenuItem ID="MIBIOMETRICO" runat="server" Text="Biometrico" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPSERVICIO}, #{TPCONTENEDOR}, 'TPBIOMETRICO', 'MBiometrico/MBiometrico.aspx','Biometrico');" />
                                    </Listeners>
                                </ext:MenuItem>

                                <ext:MenuSeparator />

                                <ext:MenuItem ID="MIRFID" runat="server" Text="RFID" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPSERVICIO}, #{TPCONTENEDOR}, 'TPRFID', 'MRFID/MRFID.aspx','RFID');" />
                                    </Listeners>
                                </ext:MenuItem>

                                <ext:MenuSeparator />
                            </Items>
                        </Menu>
                    </ext:MenuPanel>

                    <ext:TabPanel ID="TPCONTENEDOR" runat="server" Region="Center" BodyCssClass="extnet" />

                </Items>
            </ext:Viewport>
        </div>
    </form>
</body>
</html>
