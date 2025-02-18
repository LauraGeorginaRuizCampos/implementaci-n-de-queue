using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementación_de_queue
{
    /* Los clientes lleguen a una fila de espera de manera secuencial.
  Se atiendan en el orden en que llegaron(FIFO).
  Se permita agregar nuevos clientes a la cola y atender al siguiente en turno.
  Se muestre el estado actual de la cola en todo momento. */

    internal class Nodo
    {
        
            public object dato;
            public Nodo siguiente;

            public Nodo(object vDato)
            {
                this.dato = vDato;
                this.siguiente = null;
            }

            public Nodo(object vDato, Nodo siguienteNodo)
            {
                this.dato = vDato;
                this.siguiente = siguienteNodo;
            }

            public Nodo Siguiente
            {
                get
                {
                    return this.siguiente;
                }
                set
                {
                    this.siguiente = value;
                }
            }

            public object Dato
            {
                get
                {
                    return this.dato;
                }
                set
                {
                    this.dato = value;
                }
            }
        
    }
}
