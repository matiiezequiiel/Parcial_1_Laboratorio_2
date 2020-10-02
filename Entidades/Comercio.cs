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

        public static Empleado AgregarEmpleado(Empleado auxEmpleado)
        {
            listaEmpleados.Add(auxEmpleado);
            return auxEmpleado;
        }
        public static Cliente AgregarCliente(Cliente auxCliente)
        {
            listaClientes.Add(auxCliente);
            return auxCliente;
        }

        public static Producto AgregarProducto (Producto auxProducto)
        {
            listaProductos.Add(auxProducto);
            return auxProducto;
        }
        
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

        public static List<Empleado> RetornarListaEmpleados()
        {

            return listaEmpleados;
        } 
        
        public static List<Cliente> RetornarListaClientes()
        {
            return listaClientes;
        }
        public static List<Venta> RetornarListaVentas()
        {
            return listaVentas;
        } 
        
        public static List<Producto> RetornarListaProductos()
        {
            List<Producto> aux = new List<Producto>();


            foreach (Producto item in listaProductos)
            {
                string nombre = item.NombreProducto;
                int stock = item.StockProducto;
                string categoria = item.CategoriaProducto;
                int codigo = item.CodigoProducto;
                double precio = item.PrecioProducto;

                aux.Add(new Producto(nombre, categoria, precio, stock, codigo));
            }
 
            return aux;  
        }

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

        public static void CargarVenta(List<Producto> productosVendidos, string empleadoVenta)
        {
            int nroTicket = listaVentas.Count + 1;
            List<Producto> listaNuevaVenta = new List<Producto>();

            foreach (Producto item in productosVendidos)
            {
                string nombre = item.NombreProducto;
                int stock = item.StockProducto;
                string categoria = item.CategoriaProducto;
                int codigo = item.CodigoProducto;
                double precio = item.PrecioProducto;

                listaNuevaVenta.Add(new Producto(nombre, categoria, precio, stock, codigo));
            }
           
            Venta miVenta = new Venta(nroTicket, listaNuevaVenta);
            listaVentas.Add(miVenta);
            CargarTicketAEmpleado(empleadoVenta,nroTicket);
           

        }

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
        public static void ActualizarListaStock(List<Producto> nuevaListaAct)
        {
            listaProductos.Clear();
            
            foreach (Producto item in nuevaListaAct)
            {
                string nombre = item.NombreProducto;
                int stock = item.StockProducto;
                string categoria = item.CategoriaProducto;
                int codigo = item.CodigoProducto;
                double precio = item.PrecioProducto;

                listaProductos.Add(new Producto(nombre, categoria, precio, stock, codigo));
            }

        }

    }
}
