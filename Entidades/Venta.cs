using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int nroTicket;
        List<Producto> listaCompra = new List<Producto>();

       
        public Venta()
        {
            this.nroTicket = 0;
        }

        public Venta(int nroTicket, List<Producto> listaCompra)
        {
            
            this.nroTicket = nroTicket;
            this.listaCompra = listaCompra;
        }

        public Venta(List<Producto> listaCompra)
        {
            this.listaCompra = listaCompra;
        }

        public static List<Venta> HardcodearVenta()
        {
            List<Producto> listaProductos = Producto.HardcodearProductos();
            List<Venta> listaVentas = new List<Venta>();

            listaVentas.Add(new Venta(111111111, listaProductos));
            listaVentas.Add(new Venta(222222222, listaProductos));
            listaVentas.Add(new Venta(111111111, listaProductos));
            listaVentas.Add(new Venta(111111111, listaProductos));
            listaVentas.Add(new Venta(111111111, listaProductos));
            listaVentas.Add(new Venta(111111111, listaProductos));
            listaVentas.Add(new Venta(111111111, listaProductos));

            return listaVentas;
         
            
        }
      
    }
}
