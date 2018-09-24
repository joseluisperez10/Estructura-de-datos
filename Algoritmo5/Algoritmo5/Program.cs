using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("cantidad de numeros: ");
                int a = int.Parse(Console.ReadLine());
                int[] arre = new int[a];
                int mayor = 0;
                int posicion = 0;
                for (int i = 0; i < a; i++)
                {
                    Console.Write("numero {0}: ", (i + 1));
                    arre[i] = int.Parse(Console.ReadLine());
                    if (arre[i] > mayor)
                    {
                        mayor = arre[i];
                        posicion = i + 1;
                    }
                }
                Console.Write("el numero mas grande es: {0} y se encuentra en la posicion: {1}", mayor, posicion);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}