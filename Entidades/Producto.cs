using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombreProducto;
        string categoriaProducto;
      
        double precioProducto;
        int stockProducto;
        int codigoProducto;

        public Producto()
        {
            this.nombreProducto = "Sin nombre";
            this.categoriaProducto = "Sin categoria";
            this.precioProducto = 0;
            this.stockProducto = 0;
            this.codigoProducto = 0;
        }

        public Producto(string nombreProducto, string categoriaProducto, double precioProducto, int stockProducto, int codigoProducto)
        {
            this.nombreProducto = nombreProducto;
            this.categoriaProducto = categoriaProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
            this.codigoProducto = codigoProducto;

        }
        //public Producto(string nombreProducto)
        //{
        //    this.nombreProducto = nombreProducto;
        //}

        public string NombreProducto
        {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value; }
        }

        public string CategoriaProducto
        {
            get { return this.categoriaProducto; }
            set { this.categoriaProducto = value; }
        }

        public double PrecioProducto
        {
            get { return this.precioProducto; }
            set { this.precioProducto = value; }
        }

        public int StockProducto
        {
            get { return this.stockProducto; }
            set { this.stockProducto = value; }
        }

        public int CodigoProducto
        {
            get { return this.codigoProducto; }
            set { this.codigoProducto = value; }
        }

        public static List<Producto> HardcodearProductos()
        {
            List<Producto> productosHardcodeados = new List<Producto>();

            productosHardcodeados.Add(new Producto("Harina", "Secos", 100, 20, 1));
            productosHardcodeados.Add(new Producto("Galletitas", "Secos", 111, 15, 2));
            productosHardcodeados.Add(new Producto("Banana", "Frutos", 120, 10, 3));
            productosHardcodeados.Add(new Producto("Nuggets", "Congelados", 150, 10, 4));
            productosHardcodeados.Add(new Producto("Jamon", "Refrigerados", 180, 10, 5));

            return productosHardcodeados;

        }


    }
}