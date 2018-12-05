using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5
{
    class Codigo_1
    {
        public void Ordenamiento()
        {
            int b = 0;
            int x = 0;
            Console.Write("Cantidad de numeros: ");
            int a = int.Parse(Console.ReadLine());
            int[] Arre1 = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                x = int.Parse(Console.ReadLine());
                while (x > 2 || x < 0)
                {
                    Console.WriteLine("Valor equivocado");
                    Console.Write("Ingrese un numero: ");
                    x = int.Parse(Console.ReadLine());
                }
                Arre1[i] = x;
            }
            for (int j = 0; j < a; j++)
            {
                for (int k = 0; k < a - 1; k++)
                {
                    if (Arre1[j] < Arre1[k])
                    {
                        b = Arre1[j];
                        Arre1[j] = Arre1[k];
                        Arre1[k] = b;
                    }
                }
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{0}.- {1}", (i + 1), Arre1[i]);
            }
            Console.ReadKey();
        }
    }
}
