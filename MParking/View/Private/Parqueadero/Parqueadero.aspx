<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Parqueadero.aspx.cs" Inherits="MParking.View.Private.Parqueadero.Parqueadero" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parqueadero</title>
    <script type="text/javascript" src="../../../Content/js/MParking.js"></script>
    <link rel="stylesheet" href="../../../Content/css/MParking.css" type="text/css" />
</head>
<body>
    <ext:ResourceManager runat="server" />
    <form id="FPARQUEADERO" runat="server">
        <div>

            <ext:Viewport ID="VPPARQUEADERO" runat="server" Layout="border">
                <Items>
                    <ext:MenuPanel ID="MPPARQUEADERO" CtCls="west-panel" Icon="BookOpen" runat="server" Width="160" Region="West" Split="true" Frame="true" Title="Servicios">
                        <Menu ID="MPARQUEADERO" runat="server">
                            <Items>

                                <ext:MenuItem ID="MIETIQUETA" runat="server" Text="Etiquetas" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPPARQUEADERO}, #{TPCONTENEDOR}, 'Etiquetas', 'Etiqueta.aspx','Etiqueta');" />
                                    </Listeners>
                                </ext:MenuItem>

                                <ext:MenuSeparator />

                                <ext:MenuItem ID="MPERMISO" runat="server" Text="Permisos" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPPARQUEADERO}, #{TPCONTENEDOR}, 'Permisos', 'Permiso.aspx','Permiso');" />
                                    </Listeners>
                                </ext:MenuItem>

                                <ext:MenuSeparator />

                                <ext:MenuItem ID="MITERMINAL" runat="server" Text="Terminales" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPPARQUEADERO}, #{TPCONTENEDOR}, 'Terminales', 'Terminal.aspx','Terminal');" />
                                    </Listeners>
                                </ext:MenuItem>

                                <ext:MenuSeparator />

                                <ext:MenuItem ID="MIVALIDACION" runat="server" Text="Vehiculos" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPPARQUEADERO}, #{TPCONTENEDOR}, 'Validaciones', 'Validacion.aspx','Validacion');" />
                                    </Listeners>
                                </ext:MenuItem>

                                <ext:MenuSeparator />

                                <ext:MenuItem ID="MIVEHICULO" runat="server" Text="Vehiculos" Icon="PlayBlue">
                                    <Listeners>
                                        <Click Handler="addTab(#{MPPARQUEADERO}, #{TPCONTENEDOR}, 'Vehiculos', 'Vehiculo.aspx','Vehiculo');" />
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
