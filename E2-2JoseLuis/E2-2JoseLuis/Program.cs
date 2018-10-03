using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2JoseLuis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("ingrese un numero: ");
                int a = int.Parse(Console.ReadLine());
                clasefibonacci obj1 = new clasefibonacci(a);
                obj1.Recursividad(a);
                obj1.Iterativa(a);  
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class clasefibonacci
    {
        public int Numero;
        
        public clasefibonacci(int N)
        {
            Numero = N;
        }
        public int Fibo(int n)
        {
            if(n<2)
            { 
                return n;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }
        public void Recursividad(int a)
        {
            Console.WriteLine("Fibonacci con Recursividad");
            int num1 = 1;
            Stopwatch cronometro1 = new Stopwatch();
            cronometro1.Start();
            while (num1<Numero)
            {
                Console.WriteLine(Fibo(num1));
                num1++;
            }
            cronometro1.Stop();
            Console.WriteLine("el tiempo de ejecucion es: {0}", cronometro1.Elapsed.ToString());
        }
        public void Iterativa(int x)
        {
         int numero = 1;
         int temporal = 0;
          int resultado = 0;
         Console.WriteLine("\nFibonacci con Iteracion");
            Stopwatch cronometro2 = new Stopwatch();
            cronometro2.Start();
            for (int i=1;i<Numero;i++)
            {
                Console.WriteLine(numero);
                resultado = numero + temporal;
                temporal = numero;
                numero = resultado;
            }
            cronometro2.Stop();
            Console.WriteLine("el tiempo de ejecucion es: {0}", cronometro2.Elapsed.ToString());
        }   
    }
}
