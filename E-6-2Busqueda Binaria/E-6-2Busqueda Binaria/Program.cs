using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_6_2Busqueda_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Num1 = 0;
                do
                {
                    Console.Write("" +
                        "\n1.- Ejercicio 1" +
                        "\n2.- Ejercicio 2" +
                        "\n3.- Salir" +
                        "\nElige una opcion: ");
                    Num1 = Convert.ToInt32(Console.ReadLine());
                    switch (Num1)
                    {
                        case 1:
                            Console.Clear();
                            BusquedaBinaria1 obj1 = new BusquedaBinaria1();//creacion del objeto de la clase BusquedaBinaria1
                            obj1.Imprimir();//llamada del metodo
                            break;
                        case 2:
                            Console.Clear();
                            BusquedaBinaria2 obj2 = new BusquedaBinaria2();//creacion del objeto de la clase BusquedaBinaria2
                            obj2.imprimir();//llamada del metodo

                            break;
                        case 3:
                            Console.WriteLine("Presione <ENTER> para salir");
                            break;
                    }

                } while (Num1 != 3);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
