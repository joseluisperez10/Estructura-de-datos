using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_unidad4_grafo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir imprimir = new Imprimir();
            imprimir.Desplegar();
            Console.ReadKey();

        }
    }
    public class Imprimir
    {
        public void Desplegar()
        {
            Seleccion:
            Console.Clear();
            Console.WriteLine("Seleccione la Ruta que desea mirar:\n1) Boston->LA\n2)NewYork->San Francisco\n3)Atlanta->San Francisco\n4)Denver->NewYork\n5)Salir");
            int Numerito1 = int.Parse(Console.ReadLine());
            if (Numerito1 == 1)
            {
                Grafo Grafito1 = new Grafo(5);
                Grafito1.Agregar(0, 1);
                Grafito1.Agregar(1, 2);
                Grafito1.Agregar(2, 3);
                Grafito1.DFS(0, 1);
                Console.WriteLine("\n");
                Console.WriteLine("el recorrido es de 2,602 millas");
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }

            if (Numerito1 == 2)
            {
                Grafo Grafito1 = new Grafo(7);
                Grafito1.Agregar(0, 1);
                Grafito1.Agregar(1, 2);
                Grafito1.Agregar(2, 3);
                Grafito1.Agregar(4, 5);
                Grafito1.DFS(4, 2);
                Console.WriteLine("\n");
                Console.WriteLine("el recorrido es de 2,587 millas");
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }

            if (Numerito1 == 3)
            {
                Grafo Grafito1 = new Grafo(4);
                Grafito1.Agregar(0, 1);
                Grafito1.Agregar(1, 2);
                Grafito1.DFS(0, 3);
                Console.WriteLine("\n");
                Console.WriteLine("el recorrido es de 2,461 millas");
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }

            if (Numerito1 == 4)
            {
                Grafo Grafito1 = new Grafo(4);
                Grafito1.Agregar(0, 1);
                Grafito1.Agregar(1, 2);
                Grafito1.DFS(0, 4);
                Console.WriteLine("\n");
                Console.WriteLine("el recorrido es de 1,630 millas");
                Console.WriteLine("\n\nPresione para continuar...");
                Console.ReadKey();
                goto Seleccion;
            }
            if (Numerito1 == 5)
            {
                Console.Clear();
                Console.WriteLine("ADIOS");
                Console.ReadKey();
            }
        }
    }
    public class Grafo
    {
        public int Vertices { get; set; }
        List<int>[] Lista;
        public Grafo(int Valor)
        {
            Vertices = Valor;
            Lista = new List<int>[Valor];
            for (int i = 0; i < Valor; i++)
            {
                Lista[i] = new List<int>();
            }
        }

        public void Agregar(int Indice, int Valor)
        {
            Lista[Indice].Add(Valor);
        }



        public void DFS(int Valor, int Numerito1)
        {
            List<string> Ciudad = new List<string>();
            if (Numerito1 == 1 || Numerito1 == 2)
            {
                Ciudad.Add("Boston");
                Ciudad.Add("Chicago");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Miami");
                Ciudad.Add("Atlanta");
            }
            if (Numerito1 == 3)
            {
                Ciudad.Add("Atlanta");
                Ciudad.Add("Chicago");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("Denver");
                Ciudad.Add("LA");
                Ciudad.Add("New York");
                Ciudad.Add("Miami");
            }
            if (Numerito1 == 4)
            {
                Ciudad.Add("Denver");
                Ciudad.Add("Chicago");
                Ciudad.Add("New York");
                Ciudad.Add("Atlanta");
                Ciudad.Add("San Francisco");
                Ciudad.Add("Boston");
                Ciudad.Add("LA");
                Ciudad.Add("Miami");
            }

            bool[] Visita = new bool[Vertices];
            Stack<int> Pila = new Stack<int>();
            Visita[Valor] = true;
            Pila.Push(Valor);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("El camino para llegar al ultimo elmento es: ");
            while (Pila.Count != 0)
            {
                Valor = Pila.Pop();
                Console.Write("{0}-> ", Ciudad[Valor]);
                foreach (int item in Lista[Valor])
                {
                    if (!Visita[item])
                    {
                        Visita[item] = true;
                        Pila.Push(item);
                    }
                }
            }
            Console.Write("Fin de la ruta");
        }
    }
}
