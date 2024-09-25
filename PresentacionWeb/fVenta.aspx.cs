using Datos.Models;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class fVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatosIniciales();
            }
        }

        #region "Datos iniciales"
        private void CargarDatosIniciales()
        {
            bFormaPago bForma = new bFormaPago();
            List<FormaPago> lstFormaPagos = bForma.Listar();
            CargarComboFormaPago(ddlFormaPago, lstFormaPagos);

            bFormaEntrega bFormaEntrega = new bFormaEntrega();
            List<FormaEntrega> lstFormaEntrega = bFormaEntrega.Listar();
            CargarComboFormaEntrega(ddlFormaEntrega, lstFormaEntrega);

            bAlmacen bAlmacen = new bAlmacen();
            List<Almacen> lstAlmacen = bAlmacen.Listar();
            CargarComboAlmacen(ddlCalm, lstAlmacen);

            txtCantidad.Text = "0.0";
            txtPrc.Text = "0.0";
            //txtDsto.Text = "0.0";
            txtSubtotal.Text = "0";
            txtDescuento.Text = "0";
            txtImpuesto.Text = "0";
            txtPagar.Text = "0";
            IniciarGrillaDetalle();
        }

        private void IniciarGrillaDetalle()
        {
            grvDetalle.DataSource = new List<DetalleVenta>();
            grvDetalle.DataBind();

        }

        private void CargarComboFormaPago(DropDownList ddl, List<FormaPago> lst)
        {
            ListItem loItem;
            ddl.Items.Clear();
            if (lst.Count > 0)
            {
                foreach (FormaPago item in lst)
                {
                    loItem = new ListItem();
                    loItem.Value = item.codFormaPago.ToString();
                    loItem.Text = item.nombreFormaPago;
                    ddl.Items.Add(loItem);
                }
            }
            else
            {
                loItem = new ListItem();
                loItem.Value = "0";
                loItem.Text = "Sin Seleccionar";
                ddl.Items.Add(loItem);
            }

        }

        private void CargarComboFormaEntrega(DropDownList ddl, List<FormaEntrega> lst)
        {
            ListItem loItem;
            ddl.Items.Clear();
            if (lst.Count > 0)
            {
                foreach (FormaEntrega item in lst)
                {
                    loItem = new ListItem();
                    loItem.Value = item.codFormaEntrega.ToString();
                    loItem.Text = item.nombreFormaEntrega;
                    ddl.Items.Add(loItem);
                }
            }
            else
            {
                loItem = new ListItem();
                loItem.Value = "0";
                loItem.Text = "Sin Seleccionar";
                ddl.Items.Add(loItem);
            }

        }

        private void CargarComboAlmacen(DropDownList ddl, List<Almacen> lst)
        {
            ListItem loItem;
            ddl.Items.Clear();
            if (lst.Count > 0)
            {
                foreach (Almacen item in lst)
                {
                    loItem = new ListItem();
                    loItem.Value = item.codAlmacen.ToString();
                    loItem.Text = item.nombreAlmacen;
                    ddl.Items.Add(loItem);
                }
            }
            else
            {
                loItem = new ListItem();
                loItem.Value = "0";
                loItem.Text = "Sin Seleccionar";
                ddl.Items.Add(loItem);
            }

        }

        #endregion

        #region "ABM"
        private void AgregarVenta()
        {
            bVenta bVenta = new bVenta();
            Venta venta = new Venta();

            venta = CargarObjetoVenta(venta);


            bVenta.GuardarVenta(venta);
            limpiarForm();
            CargarDatosIniciales();
        }

        private Venta CargarObjetoVenta(Venta venta)
        {
            bCliente bCliente = new bCliente();
            Cliente cliente;
            cliente = bCliente.Buscar(int.Parse(txtCodCli.Text.Trim()));
            venta.NroVenta = int.Parse(txtNroVenta.Text);
            venta.codAlmacen = int.Parse(ddlCalm.SelectedValue);
            venta.Descuento = double.Parse(txtDescuento.Text);
            venta.Factura = chkConFactura.Checked;
            venta.Impuesto = double.Parse(txtImpuesto.Text);
            venta.objCliente = cliente;
            venta.items = StringToListDetVenta((string)ViewState["xLstDetalleVenta"]);

            return venta;
        }
        #endregion

        #region "Detalle"
        private bool RevisarDatosDetalle()
        {
            string mensaje = "";
            if (txtNroVenta.Text == "")
            {
                mensaje = "Debe indicar el código de venta";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return false;
            }
            if (txtSKUProd.Text == "")
            {
                mensaje = "Debe indicar el código del producto";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return false;
            }
            if (txtCantidad.Text == "")
            {
                mensaje = "Debe indicar la cantidad";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return false;
            }
            if (double.Parse(txtCantidad.Text.Trim()) <= 0)
            {
                mensaje = "La cantidad debe ser mayor que 0";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return false;
            }
            if (txtPrc.Text == "")
            {
                mensaje = "Debe indicar el precio de venta";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return false;
            }
            if (double.Parse(txtPrc.Text.Trim()) <= 0)
            {
                mensaje = "El precio debe ser mayor que 0";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return false;
            }
            return true;
        }

        private void AgregarItemDetalle()
        {
            if (!RevisarDatosDetalle())
            {
                return;
            }
            List<DetalleVenta> oLst = StringToListDetVenta((string)ViewState["xLstDetalleVenta"]); //new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();

            item.NroVenta = int.Parse(txtNroVenta.Text);
            item.SKU = txtSKUProd.Text;
            item.cantidad = int.Parse(txtCantidad.Text);
            item.descuento = 0;
            item.precioUnitario = double.Parse(txtPrc.Text);

            oLst.Add(item);

            ViewState["xLstDetalleVenta"] = this.lstDetVentaToString(oLst);

            grvDetalle.DataSource = oLst;
            grvDetalle.DataBind();

            CalcularTotales();
            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            txtSKUProd.Text = "";
            txtNombProducto.Text = "";
            txtPrc.Text = "0";
            txtCantidad.Text = "0";
        }
        #endregion

        #region "Metodos Auxiliares"
        private void CalcularTotales()
        {
            bVenta bVenta = new bVenta();
            Venta venta = new Venta();

            venta = CargarObjetoVenta(venta);
            txtSubtotal.Text = venta.TotalVenta().ToString();

            venta.Descuento = bVenta.AplicarDescuento(venta);            
            txtDescuento.Text = venta.Descuento.ToString();
            venta.Impuesto = bVenta.AplicarImpuestoIVA(venta);
            txtImpuesto.Text = venta.Impuesto.ToString();
            txtPagar.Text = venta.TotalPagar().ToString();
        }

        private void ObtenerCliente()
        {
            bCliente bCliente = new bCliente();
            Cliente cliente;

            if (txtCodCli.Text == "")
            {
                string mensaje = "Debe ingresar el codigo del cliente";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return;

            }
            cliente = bCliente.Buscar(int.Parse(txtCodCli.Text.Trim()));
            txtNombreCli.Text = cliente.snombreCliente;
            txtNombreGrupoCliente.Text = cliente.objGrupocliente.sNombreGrupo;
            txtPrctDstoGrupoCliente.Text = cliente.objGrupocliente.dPorcentajeDsto.ToString();
        }

        private void ObtenerProducto()
        {
            bProducto bProducto = new bProducto();
            string mensaje = "";
            if (txtCodCli.Text == "")
            {
                txtSKUProd.Text = "";
                mensaje = "Debe seleccionar al cliente";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return;
            }
            if (txtSKUProd.Text == "")
            {
                mensaje = "Debe ingresar el código del producto";
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "nombre1", "_showMessage('" + mensaje + "');", true);
                return;
            }
            Producto producto = bProducto.Buscar(txtSKUProd.Text.Trim());
            txtSKUProd.Text = producto.sCodigo;
            txtNombProducto.Text = producto.sNombre;
            txtPrc.Text = "1000";
            txtCantidad.Text = "1";
            //txtDescuento.Text = (double.Parse(txtPrc.Text) * int.Parse(txtCantidad.Text) * (double.Parse(txtPrctDstoGrupoCliente.Text) / 100)).ToString();
        }

        private string lstDetVentaToString(List<DetalleVenta> lst)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(lst);
        }

        private List<DetalleVenta> StringToListDetVenta(string json)
        {
            List<DetalleVenta> lst = new List<DetalleVenta>();
            if (json != null)
            {
                lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DetalleVenta>>(json);
            }
            return lst;
        }

        private void limpiarForm()
        {
            txtNroVenta.Text = "";
            txtCodCli.Text = "";
            txtNombreCli.Text = "";
            txtNombreGrupoCliente.Text = "";
            txtPrctDstoGrupoCliente.Text = "";
            chkConFactura.Checked = false;

            txtSubtotal.Text = "0";
            txtDescuento.Text = "0";
            txtImpuesto.Text = "0";
            txtPagar.Text = "0";
        }
        #endregion



        #region "EVENTOS"
        protected void txtSKUProd_TextChanged(object sender, EventArgs e)
        {
            ObtenerProducto();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarItemDetalle();
        }

        protected void txtCodCli_TextChanged(object sender, EventArgs e)
        {
            ObtenerCliente();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            AgregarVenta();
        }

        protected void chkConFactura_CheckedChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }
        #endregion


    }
}