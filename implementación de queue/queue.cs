using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace implementación_de_queue
{
    /* Los clientes lleguen a una fila de espera de manera secuencial.
  Se atiendan en el orden en que llegaron(FIFO).
  Se permita agregar nuevos clientes a la cola y atender al siguiente en turno.
  Se muestre el estado actual de la cola en todo momento. */

    class Cola
    {
        public Nodo primero;
        public Nodo ultimo;
        public string nombre;

        public Cola(string nombreCola)
        {
            nombre = nombreCola;
            primero = ultimo = null;
        }

        public Cola()
        {
            nombre = "Cola";
            primero = ultimo = null;
        }

        public void mostrar()
        {
            if (primero == null) { Console.WriteLine("La cola esta vacia"); }
            else
            {
                Nodo current = primero;
                Console.WriteLine("\nEstado actual de la cola \n");
                while(current != null)
                {
                    Console.WriteLine(current.dato); // Imprime cada elemento de la cola
                    current = current.Siguiente; // Avanza al siguiente nodo
                }
                Console.WriteLine("\n");
            }
        }


        public bool estaVacia()
        {
            return primero == null;
        }

        public void Encolar(object articulo)
        {
            if (estaVacia())
                primero = ultimo = new Nodo(articulo);
            else
            {
                ultimo = ultimo.Siguiente = new Nodo(articulo);
                // ultimo.Siguiente = primero;
                
            }
            

        }

        public object Desencolar()
        {
            if (estaVacia())
            {
                Console.Write("Fak iu, está vacía");
                return null;
            }

            object objetoBorrado = primero.Dato;

             /* if (primero == ultimo)
                {
                    primero = ultimo = null;
                }
                else
                {
                    primero = primero.Siguiente;
                } */
            primero = primero.Siguiente;
            
            return objetoBorrado; 
        }

        public void Imprimir()
        {
            if (estaVacia())
            {
                Console.WriteLine("La cola está vacía bitch");
                return;
            }

            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }


    }
}
