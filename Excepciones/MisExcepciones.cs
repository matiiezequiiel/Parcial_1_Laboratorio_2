using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MisExcepciones : Exception
    {
        public MisExcepciones(string mensaje) : base(mensaje)
        {
            
        }

    }
}
