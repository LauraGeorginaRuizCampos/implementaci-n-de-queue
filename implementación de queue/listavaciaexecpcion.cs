using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementación_de_queue
{
    internal class listavaciaexecpcion
    {
        public class ListaVaciaException : ApplicationException
        {
            public ListaVaciaException(string nombre)
                : base("La cola de nombre " + nombre + " está vacía.")
            {

            }
        }
    }
}
