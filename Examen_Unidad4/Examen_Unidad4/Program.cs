using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbolbinarioordenado arbol = new Arbolbinarioordenado();//se instancia el objeto de la clase Arbolbinarioordenado
            arbol.Menu();
            Console.ReadKey();
        }
    }
    public class Arbolbinarioordenado //se crea una clase de tipo publica llamada Arbolbinarioordenado
    {
        public void Imprimir_1()
        {
            ArbolBinario arbol = new ArbolBinario(); // crea un objeto arbol de BinaryTree

            arbol.z = new Node("A");
            arbol.z.Izquierda = new Node("B");
            arbol.z.Medio = new Node("C");
            arbol.z.Derecha = new Node("D");
            arbol.z.Izquierda.Izquierda = new Node("E");
            arbol.z.Izquierda.Medio = new Node("F");
            arbol.z.Izquierda.Derecha = new Node("G");
            arbol.z.Derecha.Izquierda = new Node("H");
            arbol.z.Derecha.Medio = new Node("I");
            arbol.z.Derecha.Derecha = new Node("J");
            arbol.z.Izquierda.Izquierda.Izquierda = new Node("K");
            arbol.z.Izquierda.Izquierda.Medio = new Node("L");
            arbol.z.Izquierda.Izquierda.Derecha = new Node("M");
            arbol.z.Izquierda.Derecha.Medio = new Node("N");
            arbol.z.Derecha.Izquierda.Medio = new Node("O");
            arbol.z.Derecha.Derecha.Izquierda = new Node("P");
            arbol.z.Derecha.Derecha.Derecha = new Node("Q");
            arbol.z.Izquierda.Derecha.Medio.Izquierda = new Node("R");
            arbol.z.Izquierda.Derecha.Medio.Derecha = new Node("S");

            Console.WriteLine("Arbol A");
            Console.WriteLine("Recorrido preorden " + "del arbol es ");
            arbol.PrintPreorder();
            Console.WriteLine();
            Console.WriteLine("\nRecorrido posorden " + "del arbol es ");
            arbol.PrintPostorder();
            Console.WriteLine();
            Console.ReadKey();
        }
        public void Imprimir()
        {
            ArbolBinario arbol = new ArbolBinario(); // crea un objeto arbol de BinaryTree

            arbol.z = new Node("A");
            arbol.z.Izquierda = new Node("B");
            arbol.z.Derecha = new Node("E");
            arbol.z.Izquierda.Izquierda = new Node("C");
            arbol.z.Izquierda.Derecha = new Node("D");
            arbol.z.Derecha.Derecha = new Node("F");
            arbol.z.Derecha.Derecha.Izquierda = new Node("G");
            arbol.z.Derecha.Derecha.Derecha = new Node("H");

            Console.WriteLine("\nArbol B");
            Console.WriteLine("Recorrido preorden " + "del arbol es ");
            arbol.PrintPreorder();
            Console.WriteLine();
            Console.WriteLine("\nRecorrido posorden " + "del arbol es ");
            arbol.PrintPostorder();
            Console.WriteLine();
            Console.ReadKey();
        }
        public class Node
        {
            public string x;
            public Node Izquierda, Derecha, Medio;

            public Node(string y)
            {
                x = y;
                Izquierda = Derecha = Medio = null;
            }
        }

        public class ArbolBinario
        {
            public Node z;
            public ArbolBinario()
            {
                z = null;
            }
            public void PostOrden(Node node)
            {
                if (node == null)
                    return;

                PostOrden(node.Izquierda);

                PostOrden(node.Medio);


                PostOrden(node.Derecha);


                Console.Write(node.x + " ");
            }
            public void PreOrden(Node node)
            {
                if (node == null)
                    return;

                Console.Write(node.x + " ");

                PreOrden(node.Izquierda);

                PreOrden(node.Medio);

                PreOrden(node.Derecha);
            }
            public void PrintPostorder() { PostOrden(z); }
            public void PrintPreorder() { PreOrden(z); }
        }
        public void Menu()
        {
            int Menu = 0;
            do
            {
                Console.Clear();
                Console.Write("" +
                    "\n1.-Arbol A" +
                    "\n2.-Arbol B" +
                    "\n3.-Salir" +
                    "\n\nElige una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.Clear();
                        Imprimir_1();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Imprimir();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 3);
        }
    }
}
