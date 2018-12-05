using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu = 0;
            do
            {
                Console.Clear();
                Console.Write("" +
                    "\n1.-Ejercicio 1" +
                    "\n2.-Ejercicio 2" +
                    "\n3.-Ejercicio 3" +
                    "\n4.-Ejercicio 4" +
                    "\n5.-Salir" +
                    "\n\nElige una opcion: ");
                Menu = Convert.ToInt16(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.Clear();
                        Codigo_1 bubble = new Codigo_1();
                        bubble.Ordenamiento();
                        break;
                    case 2:
                        Console.Clear();
                        Codigo_2 radix = new Codigo_2();
                        radix.imprimir();
                        break;
                    case 3:
                        Console.Clear();
                        Codigo_3 Shell = new Codigo_3();
                        Shell.Cargar();
                        Shell.Shell();
                        Shell.Imprimir();
                        break;
                    case 4:
                        Console.Clear();
                        Codigo_4 Quick = new Codigo_4();
                        Quick.Imprimir();
                        break;
                    case 5:
                        Console.WriteLine("Presione <Enter> para salir...");
                        Console.ReadKey();
                        break;
                }
            } while (Menu != 5);
        }
    }
}
