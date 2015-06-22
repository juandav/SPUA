<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Terminal.aspx.cs" Inherits="MParking.View.Private.Parqueadero.Terminal" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestion de Terminales</title>
    <script type="text/javascript">
        /* Creando una instancia de ActiveXObject para poder acceder a nuestra libreria */
        var obj = new ActiveXObject("BioActiveX.Control"); /* Aca hago el llamado al dll */
        alert(obj.TextoPrueba('Texto desde JavaScript')); /* Aca hago llamado a un metodo de prueba*/
        obj.ConectarConTerminal('192.168.1.201', '4370', 'Biometrico'); /* Aca llamo al metodo para conectar con el dispositivo*/
        alert(obj.CargarUsuariosDelTerminalEnCliente()); /* Aca me muestra la lista de usuarios en el dispositivo en JSON*/
    </script>
</head>
<body>
    <ext:ResourceManager runat="server" />
    <form id="FTERMINAL" runat="server">
        <div>
            <ext:Viewport ID="VPTERMINAL" runat="server" Layout="Fit">
                <Items>

                    <ext:Panel ID="PTERMINAL" runat="server" Collapsible="True" Collapsed="false" Split="True" Title="Gestion de Terminales" AnchorVertical="100%" Region="North">
                        <Items>
                            <ext:GridPanel ID="GPTERMINAL" runat="server" AutoHeight="true" AutoExpandColumn="CTERM_DESCRIPCION">

                                <Store>
                                    <ext:Store ID="STERMINAL" runat="server" GroupField="TERM_TIPO">
                                        <Reader>
                                            <ext:JsonReader>
                                                <Fields>
                                                    <ext:RecordField Name="TERM_ID"/>
                                                    <ext:RecordField Name="TERM_TIPO"/>
                                                    <ext:RecordField Name="TERM_IP_PORT"/>
                                                    <ext:RecordField Name="TERM_DESCRIPCION"/>
                                                </Fields>
                                            </ext:JsonReader>
                                        </Reader>
                                    </ext:Store>
                                </Store>

                                <ColumnModel>
                                    <Columns>
                                        <ext:RowNumbererColumn />
                                        <ext:Column ColumnID="CTERM_IP_PORT" DataIndex="TERM_IP_PORT" Header="Dirección Logica" Align="Center"/>
                                        <ext:Column ColumnID="CTERM_DESCRIPCION" DataIndex="TERM_DESCRIPCION" Header="Descripción" Align="Center"/>
                                        <ext:Column ColumnID="CTERM_TIPO" DataIndex="TERM_TIPO" Header="Tipo" Hidden="true"/>
                                    </Columns>
                                </ColumnModel>

                                <View>
                                    <ext:GroupingView ID="GVTERMINAL" runat="server" MarkDirty="false" ShowGroupName="false" EnableNoGroups="true" GroupTextTpl='{text} ({[values.rs.length]} {[values.rs.length > 1 ? " Terminales " : " Terminal " ]})' StartCollapsed="true" />
                                </View>

                                <SelectionModel>
                                    <ext:RowSelectionModel SingleSelect="true">
                                        <Listeners>
                                            <RowSelect Handler="
                                                PTERMINAL.collapse();
                                                PDATOSTERMINAL.expand();
                                            "/>
                                        </Listeners>
                                    </ext:RowSelectionModel>
                                </SelectionModel>

                            </ext:GridPanel>
                        </Items>
                    </ext:Panel>

                    <ext:Panel ID="PDATOSTERMINAL" runat="server" Collapsible="True" Collapsed="true" Split="True" Title="Datos del Terminal" Layout="Column" AnchorHorizontal="100%" AnchorVertical="100%">
                        <Items>
                            <ext:GridPanel ID="GPUSUARIOSCLIENTE" runat="server" AnchorVertical="100%" ColumnWidth="0.5">

                                 <Store>
                                    <ext:Store ID="SUSUARIOSCLIENTE" runat="server">
                                        <Reader>
                                            <ext:JsonReader>
                                                <Fields>
                                                    <ext:RecordField Name=""/>
                                                </Fields>
                                            </ext:JsonReader>
                                        </Reader>
                                    </ext:Store>
                                </Store>

                            </ext:GridPanel>

                             <ext:GridPanel ID="GPUSUARIOSSERVIDOR" runat="server" AnchorVertical="100%" ColumnWidth="0.5">

                                 <Store>
                                    <ext:Store ID="SUSUARIOSSERVIDOR" runat="server">
                                        <Reader>
                                            <ext:JsonReader>
                                                <Fields>
                                                    <ext:RecordField Name=""/>
                                                </Fields>
                                            </ext:JsonReader>
                                        </Reader>
                                    </ext:Store>
                                </Store>

                            </ext:GridPanel>
                        </Items>
                    </ext:Panel>
                </Items>
            </ext:Viewport>
        </div>
    </form>
</body>
</html>
