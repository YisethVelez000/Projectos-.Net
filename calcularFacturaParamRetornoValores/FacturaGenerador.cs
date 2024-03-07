using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularFacturaParamRetornoValores
{
    internal class FacturaGenerador
    {
        public double[] CalcularPrecioTotal(double subtotal, double impuestos, double descuento)
        {
            double total = subtotal + impuestos - descuento;
            //array que contiene  precio total calculado y los impuestos
            double[] resultado = { total, impuestos };
            return resultado;
        }

        public string generarFactura(string nombreCliente,string direccion, string[]items, double[] precios)
        {

        }


    }
}
