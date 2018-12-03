using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_Busqueda_secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Menu = 0;
                do
                {
                    Console.Write("" +
                        "\n1.-Ejercicio 1" +
                        "\n2.-Ejercicio 2" +
                        "\n3.-Salir" +
                        "\n\nElige una opcion: ");
                    Menu = Convert.ToInt16(Console.ReadLine());
                    switch (Menu)
                    {
                        case 1:
                            Console.Clear();
                            BusquedaSec1 obj1 = new BusquedaSec1();//creacion del objeto y llamada del metodo
                            obj1.Imprimirsec();
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Busquedasec2 obj2 = new Busquedasec2();//creacion del objeto y llamada del metodo
                            obj2.Imprimirsec2();
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Presione <Enter> para salir...");
                            Console.ReadKey();
                            break;
                    }
                } while (Menu != 3);


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class BusquedaSec1
    {
        public void Imprimirsec()
        {
            Console.Write("Cantidad de numeros: ");//cantidad de numeros a pedir
            int num1 = Convert.ToInt32(Console.ReadLine());
            int[] Arre1 = new int[num1];//creacion del arreglo que tendra la longitud dependiendo del arreglo
            Random Ran = new Random();
            for (int i = 0; i <num1; i++)
            {
                Arre1[i] = Ran.Next(100);
                Console.WriteLine(Arre1[i]);//llenado del arreglo con un random

            }
            Console.Write("ingrese un numero: ");//numero que ingresara el usuario
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < Arre1.Length; i++)
            {
                if (a == Arre1[i])//si el numero que ingreso el usuario esta dentro del arreglo entonces nos dara la posicion
                {
                    Console.WriteLine("el numero que usted busca esta en la posicion: {0}", i + 1);
                }
            }
        }
    }
    public class Busquedasec2
    {
        public void Imprimirsec2()
        {
            Inicio:
            int num, i = 0, pos = 0;
            int[] vector = { 3, 65, 8, 1, 2, 88, 9, 0, 6, 45 };//creacion del vector ya definido
            bool encontro = false;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            while (!(encontro) && i < 10)//mientras sde encuentre y sea menor que 10 entonces entra el ciclo
            {
                if (num == vector[i])//si el numero esta dentro del vector entonces sera verdad
                {
                    encontro = true;
                    pos = i;
                }
                i = i + 1;
            }
            if (encontro)//si se encuentra el numero sera vardad y entrara la condicion de lo contario entrara el else
            {
                pos = pos + 1;
                Console.WriteLine("El numero se encuentra y esta en la posicion: " + pos);
            }
            else
            {
                Console.WriteLine("El dato no se encontro");
                goto Inicio;
            }
            Console.ReadKey();
        }
    }
}
