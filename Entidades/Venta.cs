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
        #region Atributos
        public int nroTicket;
        List<Producto> listaCompra = new List<Producto>();
        #endregion

        #region constructores
        public Venta()
        {
            this.nroTicket = 0;
        }

        public Venta(int nroTicket, List<Producto> listaCompra)
        {

            this.nroTicket = nroTicket;
            this.listaCompra = listaCompra;
        }
        #endregion



        public List<Producto> ListaCompra
        {
            get { return this.listaCompra; }
         //   set { this.listaCompra = value; }
        }



        public static List<Venta> HardcodearVenta()
        {
            List<Producto> listaProductos = Producto.HardcodearProductos();


            List<Venta> listaVentas = new List<Venta>();


            listaVentas.Add(new Venta(1, listaProductos));
            listaVentas.Add(new Venta(2, listaProductos));
            listaVentas.Add(new Venta(3, listaProductos));
            listaVentas.Add(new Venta(4, listaProductos));
            listaVentas.Add(new Venta(5, listaProductos));
            listaVentas.Add(new Venta(6, listaProductos));


            return listaVentas;


        }

    }
}