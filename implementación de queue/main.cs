using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static implementación_de_queue.Program;

namespace implementación_de_queue
{
    class program
    {
        static bool Exit()
        {
            int opt;
            do
            {
                Console.WriteLine("¿Desea realizar otra operacion?\n1.Si 2.No\n");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 1) { return true; }  // Si elige 1, el programa continúa
                else if (opt == 2) { return false; } // Si elige 2, el programa termina
                else { Console.WriteLine("Introduzca una opción correcta"); } // Mensaje de error en caso de opción inválida
            } while (opt != 1 && opt != 2);
            return true;
        }



        static void Main()
        {
            /* Los clientes lleguen a una fila de espera de manera secuencial.
            Se atiendan en el orden en que llegaron(FIFO).
            Se permita agregar nuevos clientes a la cola y atender al siguiente en turno.
            Se muestre el estado actual de la cola en todo momento. */


            Cola cola = new Cola("Cola de clientes feos original ;)");
            cola.Encolar("Cheputa");
            cola.Encolar("Antonio");
            cola.Encolar("Yorch");
            cola.Encolar("Emilio");
            cola.Encolar("Maikol");
            int opcion = 0;


            do
            {
                Menu(cola, ref opcion);


            } while (Exit() && (opcion > 0 && opcion < 4));

            

        }

        static void Menu(Cola cola, ref int opcion)
        {
            String menuTexto =
            "¿Qué operación desea realizar?\n" +
            "1. Agregar un nuevo cliente\n" +
            "2. Atender al cliente en turno\n" +
            "3. Mostrar la fila actual\n" +
            "4. Salir de aquí\n";
            Console.WriteLine(menuTexto);

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: // agregar cliente lol
                    Console.WriteLine("Ingrese el nombre del cliente: ");
                    string cliente = Console.ReadLine();
                    cola.Encolar(cliente);
                    cola.mostrar();
                    break;
                case 2: // atender cliente lol
                    Console.WriteLine("Atendiendo a: " + cola.primero.Dato);
                    cola.Desencolar();
                    cola.mostrar();
                    break;
                case 3: // mostrar fila
                    cola.mostrar();
                    
                    break;
                case 4: //salir 
                    Console.WriteLine("Adios");
                    break;
            }


        }
    }
}
