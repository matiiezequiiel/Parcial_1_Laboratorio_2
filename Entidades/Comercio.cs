using System;
using System.Collections.Generic;
using System.Linq;
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

        static Comercio()
        {
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
            listaProductos = new List<Producto>();

        }

        public static Empleado AgregarEmpleado(Empleado auxEmpleado)
        {
            listaEmpleados.Add(auxEmpleado);
            return auxEmpleado;
        }






    }
}
