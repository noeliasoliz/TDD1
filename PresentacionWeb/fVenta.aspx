<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fVenta.aspx.cs" Inherits="PresentacionWeb.fVenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <script language="javascript" type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script>


        function _showMessage(pMsj) {
            /* pMsj = "<div style='margin-left:15px;margin-right:15px;text-align:center;'><br>" + pMsj + " <br> </div>";
            var pTitle = "<div class = 'divCabeceraMsj' style = 'background:#233240;'> " +
                "     <div class = 'clsLeftMsj'> " +
                "         <img class = 'clsImgModal' src = '../Images/_global/msjWarning.png'/> " +
                "         <p class = 'clsParrafo' style = 'font-family:sans-serif; color:#FFF' >ADVERTENCIA</p> " +
                "     </div>" +
                "</div>";
            $('#lblMessage').html(pMsj);
            $('#dialog').dialog({ autoOpen: false, minWidth: 400, resizable: false, modal: true, title: pTitle });
            $('#dialog').dialog('open');
            $(document).keydown(function (event) { if (event.which == 13) { $('#dialog').dialog('destroy'); } }); */
            alert(pMsj)
        }

    </script>
    <form id="form1" runat="server">
        <div id="dialog" title="Mensaje"><span id="lblMessage"></span></div>
        <table style="width: 90%" aling="center">
            <tr>
                <td style="width: 50%">
                    <table style="width: 100%">
                        <tr>
                            <td>Nro. Venta</td>
                            <td>
                                <asp:TextBox runat="server" ID="txtNroVenta"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Cliente</td>
                            <td>
                                <asp:TextBox runat="server" ID="txtCodCli" AutoPostBack="true" OnTextChanged="txtCodCli_TextChanged"></asp:TextBox>
                                <asp:TextBox runat="server" ID="txtNombreCli"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Grupo Cliente</td>
                            <td>
                                <asp:TextBox runat="server" ID="txtNombreGrupoCliente" AutoPostBack="true" Enabled="false"></asp:TextBox>
                                <asp:TextBox runat="server" ID="txtPrctDstoGrupoCliente" Enabled="false"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Almacen</td>
                            <td>
                                <asp:DropDownList ID="ddlCalm" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>ConFactura</td>
                            <td>
                                <asp:CheckBox ID="chkConFactura" runat="server" AutoPostBack="true" Text=" " OnCheckedChanged="chkConFactura_CheckedChanged" />
                            </td>
                        </tr>
                        <tr>
                            <td>Forma Pago</td>
                            <td>
                                <asp:DropDownList ID="ddlFormaPago" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Forma Entrega</td>
                            <td>
                                <asp:DropDownList ID="ddlFormaEntrega" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 50%">
                    <fieldset>
                        <legend>Productos/Servicios</legend>
                        <table style="width: 100%">
                            <tr>
                                <td>SKU</td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtSKUProd" AutoPostBack="true" OnTextChanged="txtSKUProd_TextChanged"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Nombre</td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtNombProducto"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Cantidad</td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtCantidad" AutoPostBack="true"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Precio Unitario</td>
                                <td class="auto-style1">
                                    <asp:TextBox runat="server" ID="txtPrc" AutoPostBack="true"></asp:TextBox>
                                </td>
                            </tr>
                            <%--<tr>
                                <td>Descuento</td>
                                <td>
                                    <asp:TextBox runat="server" ID="txtDsto" AutoPostBack="true"></asp:TextBox>
                                </td>
                            </tr>--%>
                            <tr>
                                <td colspan="2" align="center">
                                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 30px"></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:GridView ID="grvDetalle" runat="server" AutoGenerateColumns="False" Width="70%" ShowHeaderWhenEmpty="true">
                        <Columns>
                            <asp:BoundField DataField="SKU" HeaderText="SKU" />
                            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="precioUnitario" HeaderText="Precio Unitario" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="descuento" HeaderText="Descuento" DataFormatString="{0:N2}" />

                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 30px"></td>
            </tr>
            <tr>
                <td></td>
                <td align="right">
                    <fieldset>
                        <table>
                            <tr>
                                <td>Subtotal:</td>
                                <td>
                                    <asp:TextBox ID="txtSubtotal" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Descuento:</td>
                                <td>
                                    <asp:TextBox ID="txtDescuento" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Impuestos:</td>
                                <td>
                                    <asp:TextBox ID="txtImpuesto" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Total Pagar:</td>
                                <td>
                                    <asp:TextBox ID="txtPagar" runat="server" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </fieldset>

                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 30px"></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                </td>
            </tr>
        </table>
    </form>

</body>
</html>
