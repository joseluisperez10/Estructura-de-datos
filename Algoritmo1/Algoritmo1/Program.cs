using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {   try
            {
                Console.Write("Cantidad de numeros a ingresar: ");
                int a = int.Parse(Console.ReadLine());
                int[] Arre = new int[a];
                for (int i = 0; i < a; i++)
                {
                    Console.Write("Numero {0}: ", (i + 1));
                    Arre[i] = int.Parse(Console.ReadLine());
                }
                int mayor;
                int menor;
                mayor = menor = Arre[0];
                for (int i = 1; i < a; i++)
                {
                    if (Arre[i] > mayor)
                    {
                        mayor = Arre[i];
                    }
                    if (Arre[i] < menor)
                    {
                        menor = Arre[i];
                    }
                }
                Console.WriteLine("El numero menor es: {0} y el numero mayor es: {1}", menor, mayor);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
