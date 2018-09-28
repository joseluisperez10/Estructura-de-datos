using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ejercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                Console.Write("ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                clasefactorial obj1 = new clasefactorial(n);
                obj1.Imprimir();
                Console.WriteLine("\n");
                obj1.Factorialfor(n);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class clasefactorial
    {
        public int N;
        public int valor = 1;
        public clasefactorial(int x)
        {
            N=x;
        }
        public int factorialrecursiva(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * factorialrecursiva(n - 1);
        }
        public void Factorialfor(int z)
        {
            for(int i=1;i<=N;i++)
            {
                valor= valor * i;
            }
            Console.WriteLine("Factorial con for");
            Console.WriteLine("el factorial de {0} es: {1}", N, valor);
            Stopwatch cronometro1 = new Stopwatch();
            cronometro1.Start();
            cronometro1.Stop();
            Console.WriteLine("el tiempo de ejecucion es: {0}", cronometro1.Elapsed.ToString());

        }
        public void Imprimir()
        {
            Console.WriteLine("Factorial en pseudocodigo");
            Console.WriteLine("el factorial de {0} es: {1}", N, factorialrecursiva(N));
            Stopwatch cronometro2 = new Stopwatch();
            cronometro2.Start();
            cronometro2.Stop();
            Console.WriteLine("el tiempo de ejecucion es: {0}", cronometro2.Elapsed.ToString());
        }
    }

}
