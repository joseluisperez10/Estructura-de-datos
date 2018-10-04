using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2JoseLuisPerez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de numeros: ");
            int a = int.Parse(Console.ReadLine());
            int[] Arre = new int[a];
            Recursividad obj = new Recursividad();
            int [] Arre2 = obj.Devolver(Arre, 0);
            Console.WriteLine("\n");
            Console.WriteLine("Tabla de numeros");
            for (int i=0;i<Arre2.Length;i++)
            {
                Console.Write("{0} ",Arre2[i]);    
            }
            Console.WriteLine("\n");
            Console.WriteLine("Valor Maximo: {0}", obj.Maximo(Arre2, 0, Arre2[0]));
            Console.WriteLine("Valor Minimo: {0}", obj.Minimo(Arre2, 0, Arre2[0]));
            Console.WriteLine("\n\nVector invertido");
            obj.Invertir(Arre2, 0, Arre2.Length - 1);
            for(int i=0;i<Arre2.Length;i++)
            {
                Console.Write("{0} ", Arre2[i]);
            }

            Console.ReadKey();
        }
    }
    public class Recursividad
    {
        public int[] Devolver(int [] r, int contador)
        {
            if (contador<=r.Length-1)
            {
                Console.Write("Escribe un numero: ");
                r[contador] = int.Parse(Console.ReadLine());
                return Devolver(r, contador + 1);
            }
            return r;
        }
        public int Maximo(int [] num, int indice, int maximo1)
        {
            if(indice != num.Length)
            {
                if(num[indice]>maximo1)
                {
                    maximo1 = Maximo(num, indice + 1, num[indice]);
                }
                else
                {
                    maximo1 = Maximo(num, indice + 1, maximo1);
                }
            }
            return maximo1;
        }
        public int Minimo(int[] num, int indice, int minimo1)
        {
            if (indice != num.Length)
            {
                if (num[indice] < minimo1)
                {
                    minimo1 = Minimo(num, indice + 1, num[indice]);
                }
                else
                {
                    minimo1 = Minimo(num, indice + 1, minimo1);
                }
            }
            return minimo1;
        }
        public void Invertir(int [] arre3,int inicio,int fin)
        {
            if(inicio<fin)
            {
                int aux = arre3[inicio];
                arre3[inicio] = arre3[fin];
                arre3[fin] = aux;
                Invertir(arre3, inicio + 1, fin - 1);
            }
        }
    }
}
