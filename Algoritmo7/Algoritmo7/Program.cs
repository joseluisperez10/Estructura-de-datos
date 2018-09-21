using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Cantidad de numeros del arreglo: ");
                int a = int.Parse(Console.ReadLine());
                int[] Arre = new int[a];
                Random Ran1 = new Random();
                Console.WriteLine("Numeros no ordenados:");
                for (int i = 0; i < a; i++)
                {
                    Arre[i] = Ran1.Next(1, 101);
                    Console.Write("{0} ", Arre[i]);
                }
                Console.WriteLine("\n\nNumeros ordenados:");
                Array.Sort(Arre);
                for(int i=0;i<a;i++)
                {
                    Console.Write("{0} ", Arre[i]);
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
