using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Producto
    {
        string nombreProducto;
        string categoriaProducto;
        float precioProducto;
        int stockProducto;
        string codigoProducto;

        public Producto()
        {
            this.nombreProducto = "Sin nombre";
            this.categoriaProducto = "Sin categoria";
            this.precioProducto = 0;
            this.stockProducto = 0;
            this.codigoProducto = "0000000000";
        }

        public Producto(string nombreProducto,string categoriaProducto,float precioProducto,int stockProducto,string codigoProducto)
        {
            this.nombreProducto = nombreProducto;
            this.categoriaProducto = categoriaProducto;
            this.precioProducto = precioProducto;
            this.stockProducto = stockProducto;
            this.codigoProducto = codigoProducto;

        }

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

        public float PrecioProducto
        {
            get { return this.precioProducto; }
            set { this.precioProducto = value; }
        }

        public int StockProducto
        {
            get { return this.stockProducto; }
            set { this.stockProducto = value; }
        }

        public string CodigoProducto
        {
            get { return this.codigoProducto; }
            set { this.codigoProducto = value; }
        }


    }
}
