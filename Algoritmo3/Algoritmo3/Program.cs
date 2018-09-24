using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int mayor = 0;
                int posicion = 0;
                Console.Write("ingrese cantidad de numeros: ");
                int x = int.Parse(Console.ReadLine());
                int[] Arre1 = new int[x];
                for (int i = 0; i < x; i++)
                {
                    Console.Write("Numero {0}: ", (i + 1));
                    Arre1[i] = int.Parse(Console.ReadLine());
                    if (Arre1[i] > mayor || Arre1[i] == mayor)
                    {
                        mayor = Arre1[i];
                        posicion = i + 1;
                    }
                }
                
                Console.WriteLine("el numero mayor es: {0} y se encuentra en la posicion {1}", mayor, posicion);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
