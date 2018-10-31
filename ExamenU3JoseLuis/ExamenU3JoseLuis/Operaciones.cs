using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace ExamenU3JoseLuis
{
    public class Operaciones
    {
        List<Clase> escuela = new List<Clase>();
        Queue Cola = new Queue();

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Stack Pila = new Stack();
            Pila.Push(5);
            Pila.Push(3);
            Pila.Pop();
            Pila.Push(2);
            Pila.Push(8);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(9);
            Pila.Push(1);
            Pila.Pop();
            Pila.Push(7);
            Pila.Push(6);
            Pila.Pop();
            Pila.Pop();
            Pila.Push(4);
            Pila.Pop();
            Pila.Pop();
            foreach(var item in Pila)
            {
                Console.WriteLine(item);
            }
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            LinkedList<int> Listas1 = new LinkedList<int>();
            List<int> Lista2 = new List<int>();
            Stopwatch medir = new Stopwatch();
            medir.Start();
            for(int i=0; i<9877; i++)
            {
                Listas1.AddLast(i);
            }
            medir.Stop();
            Console.WriteLine("tiempo que tardo la lista ligada {0}", medir.Elapsed.ToString());
            medir.Start();
            for(int i=0;i<9877;i++)
            {
                Lista2.Add(i);
            }
            medir.Stop();
            Console.WriteLine("tiempo que tardo la lista normal {0}", medir.Elapsed.ToString());
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            int Alto = 0, Bajo = 100;
            double sumacali = 0;
            double promedio = 0;
            
            Clase escuelas = new Clase();

            Console.Write("Nombre de la clase: ");
            escuelas.NombreClase = Console.ReadLine();
            Console.Write("\nNombre del maestro: ");
            escuelas.Maestro = Console.ReadLine();
            for (int i = 0; i < 30; i++)
            {
                Clase clase = new Clase();
                Console.Write("\nNombre del alumno: ");
                clase.Alumno = Console.ReadLine();
                Console.Write("Calificacion del alumno {0} es: ", (i + 1));
                clase.Calificacion = int.Parse(Console.ReadLine());
                if (clase.Calificacion > Alto)
                {
                    Alto = clase.Calificacion;
                }
                if (Bajo > clase.Calificacion)
                {
                    Bajo = clase.Calificacion;
                }
                escuela.Add(clase);
            }
            
            foreach (var item in escuela)
            {
                sumacali += item.Calificacion;
                promedio = sumacali / escuela.Count;
            }
            Console.WriteLine("\nCalificaciones del mas alto: {0} ", Alto);
            Console.WriteLine("Calificaciones del mas bajo: {0} ", Bajo);
            Console.WriteLine("El promedio es: {0} ", promedio);


        }        
    }
}
