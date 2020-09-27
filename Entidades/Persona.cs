using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected string nombrePersona;
        protected string apellidoPersona;
        protected int dniPersona;

        public Persona()
        {
            this.nombrePersona = "Sin nombre.";
            this.apellidoPersona = "Sin apellido.";
            this.dniPersona = 0;
        }
    }
}
