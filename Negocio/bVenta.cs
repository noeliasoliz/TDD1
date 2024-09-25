using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bVenta
    {
        cVenta cVenta;
        public bVenta()
        {
            cVenta = new cVenta();
        }

        public int GuardarVenta(Venta venta)
        {
            
            int nro = 0;
            nro = cVenta.GuardarVenta(venta);
            GuardarDetalleVenta(venta.items);
            return nro;
        }
        public void GuardarDetalleVenta(List<DetalleVenta> detalleVenta)
        {
            cVenta.GuardarDetalleVenta(detalleVenta);
        }
        public double AplicarDescuento(Venta venta)
        {
            double descuento = 0;
            double totalVenta = venta.TotalVenta();            

            if (venta.objCliente.objGrupocliente != null)
            {
                descuento = totalVenta * venta.objCliente.objGrupocliente.dPorcentajeDsto / 100;
            }
            return descuento;
        }

        public double AplicarImpuestoIVA(Venta venta)
        {
            double impuesto = 0;
            double totalVenta = venta.TotalVenta();
            if (venta.Factura)
            {
                impuesto = ( totalVenta - venta.Descuento) * 0.13;
            }

            return impuesto;
        }
    }
}
