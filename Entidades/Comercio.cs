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
        static Dictionary<string, string> usuariosContraseñas;

        static Comercio()
        {
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
            listaProductos = new List<Producto>();
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

    }
}
