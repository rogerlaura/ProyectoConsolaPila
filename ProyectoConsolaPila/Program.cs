using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsolaPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato, opcion;
            Pila pila = new Pila(5);
            do
            {
                Console.WriteLine("\t\t============MENU============");
                Console.WriteLine("\t\t1.- APILAR");
                Console.WriteLine("\t\t2.- DASAPILAR");
                Console.WriteLine("\t\t3.- LISTAR PILA");
                Console.WriteLine("\t\t4.- SALIR");
                Console.Write("\tELIJA UNA OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("\t\tDIGITE EL VALOR DEL ELEMENTO: ");
                        dato = int.Parse(Console.ReadLine());
                        pila.ApilarPila(dato);
                        break;
                    case 2:
                        pila.DesapilarPila();
                        break;
                    case 3:
                        pila.ListarPila();
                        break;

                }
                Console.ReadKey(true);
                Console.Clear();
                
            } while (opcion!=4);



            Console.ReadKey(true);
        }
    }
}
