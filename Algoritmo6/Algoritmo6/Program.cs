using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int mayor = 0, posicion = 0;
                Console.Write("Numero de veces: ");
                int a = int.Parse(Console.ReadLine());
                string[] Cadena = new string[a];
                for(int i=0; i<a;i++)
                {
                    Console.Write("palabra {0}: ",(i + 1));
                    Cadena[i] = Console.ReadLine();
                    int k = 0;
                    foreach(char b in Cadena[i])
                    {
                        k++;
                    }
                    if(k>mayor)
                    {
                        mayor = k;
                        posicion = i ;
                    }
                    
                }
                Console.WriteLine("la primera ves que la palabra sucesora fue mas alta es: {0} en la posicion: {1}", Cadena[posicion], (posicion +1) );
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
