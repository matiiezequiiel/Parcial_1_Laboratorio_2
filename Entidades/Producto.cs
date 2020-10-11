using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        //string nombreProducto;
        //// string categoriaProducto;
        //public enum ECategoriaProducto
        //{
        //    Secos, Lacteos, Frutas, Verduras, Refrigerados, Congelados, Panificados, Ninguna
        //};
        //ECategoriaProducto tipoProducto;
        //double precioProducto;
        //int stockProducto;
        //int codigoProducto; 
        
        public string nombreProducto;
        // string categoriaProducto;
        public enum ECategoriaProducto
        {
            Secos, Lacteos, Frutas, Verduras, Refrigerados, Congelados, Panificados, Ninguna
        };
        public ECategoriaProducto tipoProducto;
        public double precioProducto;
        public int stockProducto;
        public int codigoProducto;

        public Producto()
        {
            this.nombreProducto = "Sin nombre";
            this.precioProducto = 0;
            this.tipoProducto = ECategoriaProducto.Ninguna;
            this.stockProducto = 0;
            this.codigoProducto = 0;
        }

        public Producto(string nombreProducto, ECategoriaProducto categoriaProducto, double precioProducto, int stockProducto, int codigoProducto)
        {
            this.nombreProducto = nombreProducto;
            this.tipoProducto = categoriaProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
            this.codigoProducto = codigoProducto;

        }
        //public Producto(string nombreProducto)
        //{
        //    this.nombreProducto = nombreProducto;
        //}

        //public string NombreProducto
        //{
        //    get { return this.nombreProducto; }
        //    set { this.nombreProducto = value; }
        //}

        //public ECategoriaProducto CategoriaProducto
        //{
        //    get { return this.tipoProducto; }
        //    set { this.tipoProducto = value; }
        //}

        //public double PrecioProducto
        //{
        //    get { return this.precioProducto; }
        //    set { this.precioProducto = value; }
        //}

        //public int StockProducto
        //{
        //    get { return this.stockProducto; }
        //    set { this.stockProducto = value; }
        //}

        //public int CodigoProducto
        //{
        //    get { return this.codigoProducto; }
        //    set { this.codigoProducto = value; }
        //}

        public static List<Producto> HardcodearProductos()
        {
            List<Producto> productosHardcodeados = new List<Producto>();

            productosHardcodeados.Add(new Producto("Harina", ECategoriaProducto.Secos, 100, 20, 1));
            productosHardcodeados.Add(new Producto("Galletitas", ECategoriaProducto.Secos, 111, 15, 2));
            productosHardcodeados.Add(new Producto("Banana", ECategoriaProducto.Frutas, 120, 10, 3));
            productosHardcodeados.Add(new Producto("Nuggets", ECategoriaProducto.Congelados, 150, 10, 4));
            productosHardcodeados.Add(new Producto("Jamon", ECategoriaProducto.Refrigerados, 180, 10, 5));

            return productosHardcodeados;

        }


    }
}