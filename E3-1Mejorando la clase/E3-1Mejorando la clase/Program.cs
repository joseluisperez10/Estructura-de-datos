using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_1Mejorando_la_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            List<Salon> Lista = new List<Salon>(); //creacion de la lista y que guardara los arreglos que tiene la clase Salon
            Salon Salon1;
            do
            {
                Console.Clear();
                Console.Write(
                    "\n1.- Agregar Clases" +
                    "\n2.- Agregar alumnos" +
                    "\n3.- Ver alumnos" +
                    "\n4.- Salir" +
                    "\n\nEliga una opcion: ");
                Num1 = Convert.ToInt16(Console.ReadLine());
                switch (Num1)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Introducir cantidad de clases: ");
                        int x = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < x; i++)//el for estara condicionado por la cantidad de materias que el usuario introduzca
                        {
                            Console.Write("Nombre de la clase {0}: ", (i + 1));
                            string Nombre = Console.ReadLine();
                            Console.Write("Cantidad de alumnos: ");
                            int Alumnos = Convert.ToInt16(Console.ReadLine());
                            Salon1 = new Salon(Alumnos, Nombre); //se instancia el objeto y tendra dos parametros, uno para la cantidad de clases y otro para el nombre de cada clase
                            Lista.Add(Salon1);//aqui ya se iran guardando los valores que se estan introduciendo
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        foreach (Salon i in Lista)
                        {
                            i.Alumno();//aqui se captura ya el nombre del alumno y las calificaciones de cada uno
                        }
                        break;
                    case 3:
                        foreach (Salon i in Lista)
                        {
                            Console.Clear();
                            i.VerAlumno();//y por ultimo se tiene la opcion de ver al nombre y la calificacion de cada alumno dependiendo la materia
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Programa finalizado");
                        Console.ReadKey();
                        break;
                }
            } while (Num1 != 4);
        }
    }
    public class Salon
    {
        public string Clases; //Atributos de la clase Salon que pasaran por parametros
        public string[] Alumnos;
        public int[] Calificaciones;
        public Salon(int alumnos, string Nom)//constructor de la clase y las variables que pasaran por parametros
        {
            Clases = Nom;
            Alumnos = new string[alumnos];//el arreglo guardara el nombre de los alumnos
            Calificaciones = new int[alumnos];//aqui el arreglo guardara la calificacion de cada alumno
        }
        public void Alumno() //metodo de la clase
        {
            for (int i = 0; i < Alumnos.Length; i++)//en este for estara condicionado por la cantidad de alumnos que se alla ingresado
            {
                Console.Clear();
                Console.WriteLine("Clase: {0}", Clases);
                Console.Write("Nombre del alumno: ");
                Alumnos[i] = Console.ReadLine();
            }
            for (int j = 0; j < Alumnos.Length; j++)//en este for lo que ara es que asignara la calificacion de cada uno de los alumnos
            {
                Console.Write("\ncalificacion del alumno {0}:", (j + 1));
                Calificaciones[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
        public void VerAlumno()
        {
            Console.WriteLine("Calificaciones de la materia de {0}", Clases);// en este meto se ara que por cada materia se imprima el nombre de cada aluno y su respectiva calificacion
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.SetCursorPosition(0, i + 1); //el setcursorposition hace la funcion de donde aparecera dichos datos en la consola, en este caso el nombre de los alumnos
                Console.Write(Alumnos[i]);
                Console.SetCursorPosition(10, i + 1);//aqui lo que hace es que la calificacion aparecera un poco mas adelante del nombre
                Console.Write(Calificaciones[i]);
            }
        }
    }
}
