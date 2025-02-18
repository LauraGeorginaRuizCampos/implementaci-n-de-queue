using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementación_de_queue
{
    internal class Program
    {

        public class Cola
        {
            private Nodo primero;
            private Nodo ultimo;
            private string nombre;

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
                    //ultimo.Siguiente = primero;
                }

            }

            public object Desencolar()
            {
                if (estaVacia())
                {
                    Console.WriteLine("Fak iu bitch");
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
                 }*/
                primero = primero.Siguiente;

                return objetoBorrado;
            }

        }
    }

}