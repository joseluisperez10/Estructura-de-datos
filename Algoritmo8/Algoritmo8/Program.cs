using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i;
                string a;
                string caracter;
                string inverso;
                inverso = "";
                do
                {
                    Console.Write("introduce 5 digitos: ");
                    a = Console.ReadLine();
                    i = a.Length;
                    if (i != 5)
                    {
                        Console.WriteLine("no tiene los digitos necesarios");
                    }
                } while (i != 5);
                for (int k = 4; k >= 0; k--)
                {
                    caracter = a.Substring(k, 1); 
                    inverso = inverso + caracter; ;
                }                                  
                if (a == inverso)
                {
                    Console.WriteLine("es palindrome");
                }
                else
                {
                    Console.WriteLine("no es palindrome");
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
