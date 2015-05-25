<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MBiometrico.aspx.cs" Inherits="MParking.View.Private.Parking.MBiometrico.MBiometrico" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modlulo Biometrico</title>
</head>
<body>
    <ext:ResourceManager runat="server" />
    <form id="FBIOMETRICO" runat="server">
        <div>
            <ext:Viewport ID="VPBIOMETRICO" runat="server" Layout="border">
                <Items>
                    <ext:FormPanel ID="FPBIOMETRICO" runat="server" ButtonAlign="Right" Region="Center" Layout="Fit" AutoDoLayout="true">
                        <Items>
                            <ext:Panel runat="server" Title="Usuarios" Icon="User" Collapsible="true" Collapsed="false" ID="PUSUARIO" Layout="fit" Padding="5" AnchorVertical="100%">
                                <Items>
                                    <ext:GridPanel ID="GUSUARIO" runat="server" AutoExpandColumn="USUA_NOMBRE">
                                        <Store>
                                            <ext:Store ID="SUSUARIO" runat="server" OnRefreshData="recargarUsuarios" GroupField="USUA_PROGRAMA">
                                                <Reader>
                                                    <ext:JsonReader>
                                                        <Fields>
                                                            <ext:RecordField Name="PEGE_ID" />
                                                            <ext:RecordField Name="USUA_DOCUMENTO" />
                                                            <ext:RecordField Name="USUA_CODIGOUDLA" />
                                                            <ext:RecordField Name="USUA_NOMBRE" />
                                                            <ext:RecordField Name="USUA_PROGRAMA" />
                                                        </Fields>
                                                    </ext:JsonReader>
                                                </Reader>
                                            </ext:Store>
                                        </Store>
                                        <ColumnModel>
                                            <Columns>
                                                <ext:RowNumbererColumn />
                                                <ext:Column ColumnID="CUSUA_DOCUMENTO" DataIndex="USUA_DOCUMENTO" Header="Documento" Align="Center" Width="200" />
                                                <ext:Column ColumnID="CUSUA_CODIGOUDLA" DataIndex="USUA_CODIGOUDLA" Header="Codigo Uniamazonia" Align="Center" Width="200" />
                                                <ext:Column ColumnID="CUSUA_NOMBRE" DataIndex="USUA_NOMBRE" Header="Nombres y Apellidos" Align="Center" />
                                                <ext:Column ColumnID="CUSUA_PROGRAMA" DataIndex="USUA_PROGRAMA" Header="Programa" Align="Center" Width="200" />
                                            </Columns>
                                        </ColumnModel>

                                        <View>
                                            <ext:GroupingView ID="GVUSUARIO" runat="server" MarkDirty="false" ShowGroupName="false" EnableNoGroups="true" GroupTextTpl='{text} ({[values.rs.length]} {[values.rs.length > 1 ? " Usuarios " : " Elemento " ]})' StartCollapsed="true" />
                                        </View>

                                        <SelectionModel>
                                            <ext:RowSelectionModel>
                                                <Listeners>
                                                    <RowSelect Handler="
                                                        var filaSeleccionada = #{GUSUARIO}.selModel.selections.items[0].data;
                                                        Ext.net.DirectMethods.cargarVehiculosDisponibles(filaSeleccionada.PEGE_ID);
                                                        PUSUARIO.collapse();" />
                                                </Listeners>
                                            </ext:RowSelectionModel>
                                        </SelectionModel>

                                        <Listeners>
                                            <Expand Handler="PVEHICULOS.collapse();" />
                                        </Listeners>
                                    </ext:GridPanel>
                                </Items>
                            </ext:Panel>
                            <ext:Panel ID="PVEHICULOS" Title="Vehiculos Disponibles" runat="server" Collapsible="true" Collapsed="false" Layout="Column" Padding="5" Icon="CarStart" AnchorVertical="100%">

                                <Items>
                                    <ext:GridPanel ID="GPVEHICULOS" runat="server" AutoExpandColumn="VEHI_MARCA" ColumnWidth="0.50" AnchorVertical="100%">
                                        <Store>
                                            <ext:Store ID="SVEHICULO" runat="server" OnRefreshData="recargarVehiculoDisponible" GroupField="VEHI_TIPO">
                                                <Reader>
                                                    <ext:JsonReader>
                                                        <Fields>
                                                            <ext:RecordField Name="VEHI_ID" />
                                                            <ext:RecordField Name="VEHI_PLACA" />
                                                            <ext:RecordField Name="VEHI_MODELO" />
                                                            <ext:RecordField Name="VEHI_MARCA" />
                                                            <ext:RecordField Name="VEHI_TIPO" />
                                                        </Fields>
                                                    </ext:JsonReader>
                                                </Reader>
                                            </ext:Store>
                                        </Store>
                                        <ColumnModel>
                                            <Columns>
                                                <ext:RowNumbererColumn />
                                                <ext:Column ColumnID="CVEHI_PLACA" DataIndex="VEHI_PLACA" Header="Placa" Align="Center" Width="200" />
                                                <ext:Column ColumnID="CVEHI_MODELO" DataIndex="VEHI_MODELO" Header="Modelo" Align="Center" Width="200" />
                                                <ext:Column ColumnID="CVEHI_MARCA" DataIndex="VEHI_MARCA" Header="Marca" Align="Center" />
                                                <ext:Column ColumnID="CVEHI_TIPO" DataIndex="VEHI_TIPO" Header="Tipo" Align="Center" Width="200" />
                                            </Columns>
                                        </ColumnModel>

                                        <View>
                                            <ext:GroupingView ID="GVVEHICULO" runat="server" MarkDirty="false" ShowGroupName="false" EnableNoGroups="true" GroupTextTpl='{text} ({[values.rs.length]} {[values.rs.length > 1 ? " Vehiculos " : " Elemento " ]})' StartCollapsed="true" />
                                        </View>

                                        <SelectionModel>
                                            <ext:RowSelectionModel>
                                                <Listeners>
                                                    <RowSelect Handler="
                                                        var filaSeleccionada = #{GPVEHICULOS}.selModel.selections.items[0].data;
                                                    " />
                                                </Listeners>
                                            </ext:RowSelectionModel>
                                        </SelectionModel>
                                    </ext:GridPanel>

                                    <ext:GridPanel ID="GPVEHICULOSAUTORIZADOS" runat="server" AutoExpandColumn="VEHI_MARCA" ColumnWidth="0.50" AnchorVertical="100%">
                                        <Store>
                                            <ext:Store ID="SVEHICULOAUTORIZADO" runat="server" OnRefreshData="recargarVehiculoAutorizado" GroupField="VEHI_TIPO">
                                                <Reader>
                                                    <ext:JsonReader>
                                                        <Fields>
                                                            <ext:RecordField Name="VEHI_ID" />
                                                            <ext:RecordField Name="VEHI_PLACA" />
                                                            <ext:RecordField Name="VEHI_MODELO" />
                                                            <ext:RecordField Name="VEHI_MARCA" />
                                                            <ext:RecordField Name="VEHI_TIPO" />
                                                        </Fields>
                                                    </ext:JsonReader>
                                                </Reader>
                                            </ext:Store>
                                        </Store>
                                        <ColumnModel>
                                            <Columns>
                                                <ext:RowNumbererColumn />
                                                <ext:Column ColumnID="CVEHI_PLACA" DataIndex="VEHI_PLACA" Header="Placa" Align="Center" Width="200" />
                                                <ext:Column ColumnID="CVEHI_MODELO" DataIndex="VEHI_MODELO" Header="Modelo" Align="Center" Width="200" />
                                                <ext:Column ColumnID="CVEHI_MARCA" DataIndex="VEHI_MARCA" Header="Marca" Align="Center" />
                                                <ext:Column ColumnID="CVEHI_TIPO" DataIndex="VEHI_TIPO" Header="Tipo" Align="Center" Width="200" />
                                            </Columns>
                                        </ColumnModel>

                                        <SelectionModel>
                                            <ext:RowSelectionModel>
                                                <Listeners>
                                                    <RowSelect Handler="
                                                        var filaSeleccionada = #{GPVEHICULOS}.selModel.selections.items[0].data;" />
                                                </Listeners>
                                            </ext:RowSelectionModel>
                                        </SelectionModel>
                                    </ext:GridPanel>
                                </Items>

                                <Listeners>
                                    <Expand Handler="PUSUARIO.collapse();  this.setHeight(FPBIOMETRICO.getHeight()-80);" />
                                </Listeners>
                            </ext:Panel>
                        </Items>
                    </ext:FormPanel>
                </Items>
            </ext:Viewport>
        </div>
    </form>
</body>
</html>
