using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region constructores
        public Cliente(string nombreCliente, string apellidoCliente, int dniCliente) : base(nombreCliente, apellidoCliente, dniCliente)
        {
                    
        }
        #endregion

        #region Metodos
        public static List<Cliente> HardcodearClientes()
        {
            List<Cliente> clientesHardcodeados = new List<Cliente>();
           
            clientesHardcodeados.Add(new Cliente("Bart", "Simpson", 111111111));
            clientesHardcodeados.Add(new Cliente("Marge", "Simpson", 222222222));
            clientesHardcodeados.Add(new Cliente("Homero", "Simpson", 333333333));
            clientesHardcodeados.Add(new Cliente("Carl", "Carlson", 444444444));
            clientesHardcodeados.Add(new Cliente("Edna", "Krabaple", 555555555));
            clientesHardcodeados.Add(new Cliente("Moe", "Zislack", 666666666)) ;
            clientesHardcodeados.Add(new Cliente("Ned", "Flanders", 777777777));
            clientesHardcodeados.Add(new Cliente("Montgomery", "Burns", 888888888));
            clientesHardcodeados.Add(new Cliente("Wandulo", "Smithers", 999999999));

            return clientesHardcodeados;
           
        }

        public override string DatosPersona()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre Cliente: {0}\n", this.nombrePersona);
            sb.AppendFormat("Apellido del Cliente: {0}\n", this.apellidoPersona);
            sb.AppendFormat("DNI del Cliente: {0}\n", this.DniPersona);

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas

        /// <summary>
        /// Agrega un Cliente a la lista verificando que no exista.
        /// </summary>
        /// <param name="lista">Lista de clientes</param>
        /// <param name="nuevoCliente">Nuevo Cliente</param>
        /// <returns>True si se agrego, false si ya existe.</returns>
        public static bool operator +(List<Cliente> lista, Cliente nuevoCliente)
        {
            bool flag=true;

             
            if(lista==nuevoCliente)
            {
                flag = false;
            }

            if(flag)
            {
                lista.Add(nuevoCliente);
            }
           
            
            return flag;
        }


        /// <summary>
        /// Busca un Cliente en la lista..
        /// </summary>
        /// <param name="listaClientes">Lista de clientes</param>
        /// <param name="c">Cliente</param>
        /// <returns>True si ya existe en la lista, false si no existe.</returns>
        public static bool operator ==(List<Cliente> listaClientes, Cliente c)
        {
            bool yaExiste = false;

            foreach (Cliente item in listaClientes)
            {
                if (item.dniPersona == c.dniPersona)
                {
                    yaExiste = true;
                    break;
                }
                
            }

            return yaExiste;

        }

        public static bool operator !=(List<Cliente> listaClientes, Cliente c )
        {
            return !(listaClientes == c);
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() != typeof(Cliente))
            {
                return false;
            }

            return this == (Cliente) obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        #endregion


    }
}
