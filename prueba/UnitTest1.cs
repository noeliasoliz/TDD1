using Datos.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using System;
using System.Collections.Generic;

namespace prueba
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void ValidacionCodigoProductoInventariable()
        //{
        //    string sCodPrd = "";
        //    bProducto objProducto = new bProducto();
        //    objProducto.objGrpProd = new GrupoProducto();
        //    objProducto.bInventario = true;

        //    objProducto.objGrpProd.sPrefijo = "RDMT";
        //    sCodPrd = objProducto.ObtenerCodigo();
        //    Assert.AreEqual("RDMT0001", sCodPrd);
        //}
        [TestMethod]
        public void ValidarTotalPagar()
        {
            GrupoCliente grupoCliente = new GrupoCliente();
            grupoCliente.CodGrupoCliente = 1;
            grupoCliente.sNombreGrupo = "Platinium";
            grupoCliente.dPorcentajeDsto = 20;

            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";
            cliente.objGrupocliente = grupoCliente;

            Venta venta = new Venta();
            venta.NroVenta = 1;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            venta.Factura = true;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();

            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;


            double impuesto = bVenta.AplicarImpuestoIVA(venta);
            venta.Impuesto = impuesto;

            double totalpagar = venta.TotalPagar();
            Assert.AreEqual(904, totalpagar);
        }

        //Test para verificar que se aplicó el % de descuento corrrecto para grupo Platinium
        [TestMethod]
        public void ValidarDescuentoGrupoPlatinium()
        {
            GrupoCliente grupoCliente = new GrupoCliente();
            grupoCliente.CodGrupoCliente = 1;
            grupoCliente.sNombreGrupo = "Platinium";
            grupoCliente.dPorcentajeDsto = 20;

            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";
            cliente.objGrupocliente = grupoCliente;

            Venta venta = new Venta();
            venta.NroVenta = 1;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            venta.Factura = false;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();
            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;
            Assert.AreEqual(200, venta.Descuento);
        }

        //Test para verificar que se aplicó el % 0 de descuento para grupo Anonimo
        [TestMethod]
        public void ValidarDescuentoGrupoAnonimo()
        {
            GrupoCliente grupoCliente = new GrupoCliente();
            grupoCliente.CodGrupoCliente = 1;
            grupoCliente.sNombreGrupo = "Anonimo";
            grupoCliente.dPorcentajeDsto = 0;

            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";
            cliente.objGrupocliente = grupoCliente;

            Venta venta = new Venta();
            venta.NroVenta = 1;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            venta.Factura = false;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();
            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;
            Assert.AreEqual(0, venta.Descuento);
        }

        //Test cliente no pertenece a ningun grupo
        [TestMethod]
        public void ValidarDescuentoClienteSinGrupo()
        {
            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";

            Venta venta = new Venta();
            venta.NroVenta = 1;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            venta.Descuento = 0;
            venta.Factura = false;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();
            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;
            Assert.AreEqual(0, venta.Descuento);
        }

        //Test para verificar que se aplicó el impuesto IVA para venta 
        [TestMethod]
        public void ValidarImpuestoIVAAplicado()
        {
            GrupoCliente grupoCliente = new GrupoCliente();
            grupoCliente.CodGrupoCliente = 1;
            grupoCliente.sNombreGrupo = "Platinium";
            grupoCliente.dPorcentajeDsto = 20;

            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";
            cliente.objGrupocliente = grupoCliente;

            Venta venta = new Venta();
            venta.NroVenta = 1;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            venta.Factura = true;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();

            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;


            double impuesto = bVenta.AplicarImpuestoIVA(venta);
            venta.Impuesto = impuesto;

            Assert.AreEqual(104, venta.Impuesto);
        }


        //Test para verificar que no se aplicó el impuesto IVA para venta
        [TestMethod]
        public void ValidarImpuestoIVANoAplicado()
        {
            GrupoCliente grupoCliente = new GrupoCliente();
            grupoCliente.CodGrupoCliente = 1;
            grupoCliente.sNombreGrupo = "Platinium";
            grupoCliente.dPorcentajeDsto = 20;

            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";
            cliente.objGrupocliente = grupoCliente;

            Venta venta = new Venta();
            venta.NroVenta = 1;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            //venta.Descuento = 200;
            venta.Factura = false;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();
            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;

            double impuesto = bVenta.AplicarImpuestoIVA(venta);
            venta.Impuesto = impuesto;

            Assert.AreEqual(0, venta.Impuesto);
        }

        //Test para verificar agregar venta a base 
        [TestMethod]
        public void ValidarAgregarVentaconIvaAplicado()
        {
            GrupoCliente grupoCliente = new GrupoCliente();
            grupoCliente.CodGrupoCliente = 1;
            grupoCliente.sNombreGrupo = "Platinium";
            grupoCliente.dPorcentajeDsto = 20;

            Cliente cliente = new Cliente();
            cliente.codCliente = 1;
            cliente.snombreCliente = "Pepe";
            cliente.objGrupocliente = grupoCliente;

            Venta venta = new Venta();
            venta.NroVenta = 2;
            venta.objCliente = cliente;
            venta.codAlmacen = 1;
            venta.Factura = true;
            venta.Impuesto = 0;
            venta.items = new List<DetalleVenta>();

            DetalleVenta item = new DetalleVenta();
            item.NroVenta = venta.NroVenta;
            item.SKU = "SRVC001";
            item.cantidad = 1;
            item.descuento = 0;
            item.precioUnitario = 1000;

            venta.items.Add(item);
            bVenta bVenta = new bVenta();

            double descuento = bVenta.AplicarDescuento(venta);
            venta.Descuento = descuento;


            double impuesto = bVenta.AplicarImpuestoIVA(venta);
            venta.Impuesto = impuesto;

            int nro = bVenta.GuardarVenta(venta);
            Assert.AreEqual(1, nro);
        }

    }
}
