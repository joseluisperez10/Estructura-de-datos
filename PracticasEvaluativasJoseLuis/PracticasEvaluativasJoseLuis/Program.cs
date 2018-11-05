using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PracticasEvaluativasJoseLuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Practicas Obj1 = new Practicas();
            Inicio2:
            Console.Clear();
            Console.WriteLine("eliga la practica deseada");
            Console.WriteLine("1. Las vacas de Bob");
            Console.WriteLine("2. Torres de hanoi");
            Console.WriteLine("3. Administrador de tareas");
            Console.WriteLine("4. Finalizar");
            int numero = Int32.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Obj1.VacasBob();
                    goto Inicio2;
                case 2:
                    Obj1.CantidadHanoi();
                    goto Inicio2;
                case 3:
                    Obj1.AdmiTareas();
                    goto Inicio2;
                case 4:
                    Console.WriteLine("Programa finalizado  Presione <Enter>");
                    break;
                default:
                    break;
            }

        }
    }
}

