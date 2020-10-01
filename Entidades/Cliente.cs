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
      

        public Cliente()
        {
  
         
        }

        public Cliente(string nombreCliente,string apellidoCliente,int dniCliente)
        {
            this.nombrePersona = nombreCliente;
            this.apellidoPersona = apellidoCliente;
            this.dniPersona = dniCliente;
           
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

 
     

      
        
    

    }
}
