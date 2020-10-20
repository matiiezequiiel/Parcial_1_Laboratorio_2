using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        // string categoriaProducto;

        #region Atributos
        public string nombreProducto;
        public enum ECategoriaProducto
        {
            Secos, Lacteos, Frutas, Verduras, Refrigerados, Congelados, Panificados, Ninguna
        };
        public ECategoriaProducto tipoProducto;
        public double precioProducto;
        public int stockProducto;
        public int codigoProducto;
        #endregion

        #region constructores
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
        #endregion
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


        #region Sobrecargas

        /// <summary>
        /// Agrega un Cliente a la lista verificando que no exista.
        /// </summary>
        /// <param name="lista">Lista de clientes</param>
        /// <param name="nuevoProducto">Nuevo Cliente</param>
        /// <returns>True si se agrego, false si ya existe.</returns>
        /// 
        public static bool operator +(List<Producto> lista, Producto nuevoProducto)
        {
            bool flag = true;

            if(lista==nuevoProducto)
            {
                flag = false;
            }

            if (flag)
            {
                lista.Add(nuevoProducto);
            }

            return flag;

        }

        /// <summary>
        /// Busca un Producto en la lista.
        /// </summary>
        /// <param name="listaProductos">Lista de clientes</param>
        /// <param name="p">Cliente</param>
        /// <returns>True si ya existe en la lista, false si no existe.</returns>
        /// 
        public static bool operator==(List<Producto> listaProductos,Producto p)
        {
            bool yaExiste = false;

            foreach (Producto item in listaProductos)
            {
                if(item.nombreProducto == p.nombreProducto && item.tipoProducto == p.tipoProducto)
                {
                    yaExiste = true;
                    break;
                }

            }

            return yaExiste;

        }

        public static bool operator !=(List<Producto> listaProductos, Producto p)
        { 
            return !(listaProductos==p);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Producto))
            {
                return false;
            }

            return this == (Producto)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



        #endregion




    }
}