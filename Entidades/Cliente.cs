using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente : Persona
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



    }
}
