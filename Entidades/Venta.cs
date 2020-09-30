using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Venta
    {
        int nroTicket;
        List<Producto> listaCompra = new List<Producto>();

       

        public Venta()
        {
            this.nroTicket = 0;
        }

        public Venta(int dniCliente, int nroTicket, List<Producto> listaCompra)
        {
            
            this.nroTicket = nroTicket;
            this.listaCompra = listaCompra;
        }

        public static List<Venta> HardcodearVenta()
        {
            List<Producto> listaProductos = Producto.HardcodearProductos();
            List<Venta> listaVentas = new List<Venta>();

            listaVentas.Add(new Venta(111111111, 1, listaProductos));
            listaVentas.Add(new Venta(222222222, 2, listaProductos));
            listaVentas.Add(new Venta(111111111, 3, listaProductos));
            listaVentas.Add(new Venta(111111111, 4, listaProductos));
            listaVentas.Add(new Venta(111111111, 5, listaProductos));
            listaVentas.Add(new Venta(111111111, 6, listaProductos));
            listaVentas.Add(new Venta(111111111, 7, listaProductos));

            return listaVentas;
         
            
        }
      
    }
}
