using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1Burbble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int b = 0;//variable temporal
                Console.Write("Cantidad de numeros: ");
                int a = int.Parse(Console.ReadLine());
                int[] Arre1 = new int[a];//arreglo definido por el usuario
                for (int i = 0; i < a; i++)
                {
                    Console.Write("numero {0}: ", i+1);
                    Arre1[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < a; j++)//aqui inicia el metodo de burbuja
                {
                    for (int k = 0; k < a - 1; k++)
                    {
                        if (Arre1[j] < Arre1[k])//condicion que definira si se ordena de menor a mayor o viceversa
                        {
                            b = Arre1[j];//variable de apoyo para conservar los valores antes de cambiarlos
                            Arre1[j] = Arre1[k];//cambios de valores de j
                            Arre1[k] = b;//cambios de valores de k
                        }
                    }
                }
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine("{0}.- {1}", (i + 1), Arre1[i]);//imprime el arreglo ya ordenado
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
