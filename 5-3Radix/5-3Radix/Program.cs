using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Radix obj2 = new Radix();//creacion del objeto de la clase radix
                obj2.imprimir();//llamdo del metodo imprimir
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class Radix
    {
        //metodo radix
        public void radix(int [] Arre1)//recibe de parametro un arreglo
        {
            int a, b, c;
            for(a= 31;a>=0; a--)
            {
                int [] aux = new int[Arre1.Length];//este nuevo arreglo se hace para hacer el movedero de los numeros
                c= 0;//se inicializa la variable C en cero, ya que sera un contador 
                for(b=0; b<Arre1.Length; b++)
                {
                    bool mover = Arre1[b] << a >= 0;//variable de tipo bolean,  es como una pregunta, si es mayor a cero te devuelve un true o lo movera
                    if(a==0 ? !mover:mover)//si la a es igual igual a cero entonces entra la condicion, el ? es un operador ternario
                    {
                        aux[c] = Arre1[b];//se intercambian los arreglos
                        c++;
                    }
                    else//entra el else en caso de que no resulte ser cierta la condicion
                    {
                        Arre1[b-c] = Arre1[b];
                    }
                }
                for (b=c; b < aux.Length; b++)//este for sirve para ir copiando lo que tengamos en el arreglo auxiliar
                {
                    aux[b] = Arre1[b-c];
                }
                Arre1 = aux;//se copea lo que ya se tiene en nuestro arreglo
            }
            Mostararreglo(Arre1);//se muestra el arreglo ordenado
        }
        public void Mostararreglo(int [] arreglo)//este metodo muestra el arreglo pero sin ordenar
        {
            int k;
            for(k=0;k<arreglo.Length;k++)
            {
                Console.Write(arreglo[k]+", ");
            }
            Console.ReadKey();
        }
        public void imprimir()
        {
            int[] arre1 = { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };//se declaran los arreglos
            int[] arre2 = { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] arre3 = { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] arre4 = { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] arre5 = { 25, 108, 1024, 12, 351, 251, 39 };
            Console.WriteLine("Arreglo 1 ordenado:");
            radix(arre1);//se muestra cada uno de los arreglos ya ordenados
            Console.Clear();
            Console.WriteLine("Arreglo 2 ordenado:");
            radix(arre2);
            Console.Clear();
             Console.WriteLine("Arreglo 3 ordenado:");
            radix(arre3);
            Console.Clear();
            Console.WriteLine("Arreglo 4 ordenado:");
            radix(arre4);
            Console.Clear();
            Console.WriteLine("Arreglo 5 ordenado:");
            radix(arre5);
            Console.ReadKey();
        }
    }
}
