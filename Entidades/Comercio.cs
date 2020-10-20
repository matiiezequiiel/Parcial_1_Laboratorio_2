using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Comercio
    {
        static List<Empleado> listaEmpleados;
        static List<Cliente> listaClientes;
        static List<Producto> listaProductos;
        static List<Venta> listaVentas;
        static Dictionary<string, string> usuariosContraseñas;

        static Comercio()
        {
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
            listaProductos = new List<Producto>();
            listaVentas = new List<Venta>();
            usuariosContraseñas = new Dictionary<string, string>();
           
        }
    
        /// <summary>
        /// Agrega un obj del tipo Cliente a la lista de clientes.
        /// </summary>
        /// <param name="auxCliente">Cliente a agregar.</param>
        /// <returns>Cliente agregado.</returns>
        public static bool AgregarCliente(Cliente auxCliente)
        {
            bool clienteAgregado = false;

            if(listaClientes+auxCliente)
            {
                clienteAgregado=true;
            }
            else
            {
                clienteAgregado = false;
            }

            return clienteAgregado;
          //  listaClientes += auxCliente;
          //  return auxCliente;
            //listaClientes.Add(auxCliente);
            //return auxCliente;
               
        }

        /// <summary>
        /// Agrega un obj del tipo Producto a la lista de productos.
        /// </summary>
        /// <param name="auxProducto">Producto a agregar.</param>
        /// <returns>Producto agregado.</returns>
        public static bool AgregarProducto (Producto auxProducto)
        {

            bool productoAgregado = false;

            if (listaProductos + auxProducto)
            {
                productoAgregado = true;
            }
            else
            {
                productoAgregado = false;
            }

            return productoAgregado;
            //listaProductos += auxProducto;
            //listaProductos.Add(auxProducto);
            //return auxProducto;
        }
        
        /// <summary>
        /// Carga clientes,empleados,user/pass,productos y ventas para pruebas.
        /// </summary>
        /// <returns></returns>
        public static bool CargarHardcodeo()
        {
            listaClientes = Cliente.HardcodearClientes();
            listaEmpleados = Empleado.HardcodearEmpleados();
            usuariosContraseñas = Empleado.HardcodearUsuariosYPass();
            listaProductos = Producto.HardcodearProductos();
            listaVentas = Venta.HardcodearVenta();

            if(listaClientes.Count>0 && listaEmpleados.Count>0 && listaProductos.Count > 0 && usuariosContraseñas.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// Retora la lista de empleados cargados.
        /// </summary>
        /// <returns>Lista de empleados cargados.</returns>
        public static List<Empleado> RetornarListaEmpleados()
        {
            return listaEmpleados;
        }

        /// <summary>
        /// Retora la lista de clientes cargados.
        /// </summary>
        /// <returns>Lista de clientes cargados.</returns>
        public static List<Cliente> RetornarListaClientes()
        {
            return listaClientes;
        }

        /// <summary>
        /// Retora la lista de ventas cargadas.
        /// </summary>
        /// <returns>Lista de ventas cargadas.</returns>
        public static List<Venta> RetornarListaVentas()
        {
            return listaVentas;
        }

        /// <summary>
        /// Retora la lista de productos cargados.
        /// </summary>
        /// <returns>Lista de productos cargados.</returns>
        public static List<Producto> RetornarListaProductos()
        {
            List<Producto> aux = new List<Producto>();


            foreach (Producto item in listaProductos)
            {
                string nombre = item.nombreProducto;
                int stock = item.stockProducto;
             //   string categoria = item.CategoriaProducto.ToString();
                int codigo = item.codigoProducto;
                double precio = item.precioProducto;

                aux.Add(new Producto(nombre, item.tipoProducto, precio, stock, codigo));
            }
 
            return aux;  
        }


        /// <summary>
        /// Valida si el usuario y contraseña ingresada es correcta.
        /// </summary>
        /// <param name="usuario">Usuario a validar.</param>
        /// <param name="contraseña">Contraseña a validar.</param>
        /// <returns>True si es correcta, false si es incorrecta.</returns>
        public static bool validarUsuario (string usuario, string contraseña)
        {
            bool retorno = false;

            foreach (var item in usuariosContraseñas)
            {
                if (item.Key == usuario && item.Value==contraseña)
                {
                    retorno = true;
                    break;
                }
                else
                {
                    retorno = false;
                }


            }
            return retorno;
           
            
        }

        /// <summary>
        /// Carga venta en la lista y genera nro de ticket de la compra realizada.
        /// </summary>
        /// <param name="productosVendidos">Lista de productos vendidos.</param>
        /// <param name="empleadoVenta">Empleado que realizo la compra.</param>
        /// <returns>Nro de ticket de la venta.</returns>
        public static int CargarVenta(List<Producto> productosVendidos, string empleadoVenta)
        {
            int nroTicket = listaVentas.Count + 1;
            List<Producto> listaNuevaVenta = new List<Producto>();

            foreach (Producto item in productosVendidos)
            {
                string nombre = item.nombreProducto;
                int stock = item.stockProducto;
            //    string categoria = item.CategoriaProducto.ToString();
                int codigo = item.codigoProducto;
                double precio = item.precioProducto;

                listaNuevaVenta.Add(new Producto(nombre, item.tipoProducto, precio, stock, codigo));
            }
           
            Venta miVenta = new Venta(nroTicket, listaNuevaVenta);
            listaVentas.Add(miVenta);
            CargarTicketAEmpleado(empleadoVenta,nroTicket);
            return nroTicket;
           

        }

        /// <summary>
        /// Carga el ticket generado en una compra al empleado que la realizo.
        /// </summary>
        /// <param name="empleado">Nombre del empleado que realizo la compra.</param>
        /// <param name="nroTicketNuevo">Nro de ticket de la compra.</param>
        public static void CargarTicketAEmpleado(string empleado,int nroTicketNuevo)
        {
            string[] valores;
            valores = empleado.Split(' ');

            foreach (Empleado item in listaEmpleados)
            {
                if(valores[0]==item.NombrePersona && valores[1]==item.ApellidoPersona)
                {
                   
                        for(int i=0;i<item.TicketsEmpleado.Length;i++)
                        {
                              if(item.TicketsEmpleado[i]==0)
                              {
                                     item.TicketsEmpleado[i] = nroTicketNuevo;
                                    break;
                              }
                         }
                }
            }
        }
        /// <summary>
        /// Limpia la lista de productos y agrega la nueva lista actualizada.
        /// </summary>
        /// <param name="nuevaListaAct">Nueva lista.
        /// </param>
        public static void ActualizarListaStock(List<Producto> nuevaListaAct)
        {
            listaProductos.Clear();
            
            foreach (Producto item in nuevaListaAct)
            {
                string nombre = item.nombreProducto;
                int stock = item.stockProducto;
             //   string categoria = item.CategoriaProducto.ToString();
                int codigo = item.codigoProducto;
                double precio = item.precioProducto;

                listaProductos.Add(new Producto(nombre, item.tipoProducto, precio, stock, codigo));
            }

        }

    }
}
