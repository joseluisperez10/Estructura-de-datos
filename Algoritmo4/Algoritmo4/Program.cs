using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese tres numeros");
            Console.Write("Primer Numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Segundo Numero: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Tetcer Numero: ");
            int c = int.Parse(Console.ReadLine());
            if(a<b && a<c)
            {
                Console.Write("el numero menor es: {0}", a); 
            }
            else
            {
                if (b < a && b < c)
                {
                    Console.Write("el numero menor es: {0}", b);
                }
                else
                {
                    Console.Write("el numero menor es: {0}", c);
                }
            }


            Console.ReadKey();
        }
    }
}
