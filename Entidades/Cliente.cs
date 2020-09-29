using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
       
        float descuentoCliente;


        public Cliente()
        {
  
            this.descuentoCliente = 0;
        }

        public Cliente(string nombreCliente,string apellidoCliente,int dniCliente,float descuentoCliente)
        {
            this.nombrePersona = nombreCliente;
            this.apellidoPersona = apellidoCliente;
            this.dniPersona = dniCliente;
            this.descuentoCliente = descuentoCliente;
        }

        public string NombreCliente
        {
            get { return this.nombrePersona; }
            set { this.nombrePersona = value; }
        }

        public string ApellidoCliente
        {
            get { return this.apellidoPersona; }
            set { this.apellidoPersona = value; }
        }

        public int DniCliente
        {
            get { return this.dniPersona; }
            set { this.dniPersona = value; }
        }

        public float DescuentoCliente
        {
            get { return this.descuentoCliente; }
            set { this.descuentoCliente = value; }
        }

        
        public static List<Cliente> HardcodearClientes()
        {
            List<Cliente> clientesHardcodeados = new List<Cliente>();
           
            clientesHardcodeados.Add(new Cliente("Bart", "Simpson", 3937594, 10));
            clientesHardcodeados.Add(new Cliente("Marge", "Simpson", 3837593, 10));
            clientesHardcodeados.Add(new Cliente("Homero", "Simpson", 3637592, 10));
            clientesHardcodeados.Add(new Cliente("Carl", "Carlson", 3437591, 10));
            clientesHardcodeados.Add(new Cliente("Edna", "Krabaple", 3637580, 10));
            clientesHardcodeados.Add(new Cliente("Moe", "Zislack", 3237557, 10)) ;
            clientesHardcodeados.Add(new Cliente("Ned", "Flanders", 3137534, 10));
            clientesHardcodeados.Add(new Cliente("Montgomery", "Burns", 3937511, 10));
            clientesHardcodeados.Add(new Cliente("Wandulo", "Smithers", 3337534, 10));
            clientesHardcodeados.Add(new Cliente("Nelson", "Months", 3637523, 10));

            return clientesHardcodeados;
           
        }

 
     

      
        
    

    }
}
