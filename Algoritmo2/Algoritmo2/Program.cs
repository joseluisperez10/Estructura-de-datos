using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] Nombre = { "jose", "Luis", "Perez", "Calvo" };
                foreach (string i in Nombre)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
                for (int i = 3; i >= 0; i--)
                {
                    Console.Write("{0} ", Nombre[i]);
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
