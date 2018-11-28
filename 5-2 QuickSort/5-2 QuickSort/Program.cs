using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Quicksort obj1 = new Quicksort();//creacion del objeto de la clase Quicksort
                obj1.Imprimir();//llamada del metodo para que se imprima
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class Quicksort
    {
        public  void Swap(double [] arreglo, int primeo, int ultimo)//se crea un metodo que pasara por parametro un arreglo y dos variables
        {
            int a = primeo, b = ultimo;
            int central = (a + b) / 2;
            double pivote = arreglo[central];
            do
            {//este ciclo se va hacer siempre y cuando la variabla a sea menor que la b
                while (arreglo[a] < pivote) a++;
                while (arreglo[b] > pivote) b--;
                if (a <= b)
                {
                    double temporal = arreglo[a];
                    arreglo[a] = arreglo[b];
                    arreglo[b] = temporal;//se hace el intercambio de variable
                    a++;
                    b--;
                }
            } while (a <= b);
            if (primeo < b) Swap(arreglo, primeo, b);
            if (a < ultimo) Swap(arreglo, a, ultimo);
        }
        public void Imprimir()
        {
            //se crean los 4 arreglos
             double[] Arre1 = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };
             double[] Arre2 = { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };
             double[] Arre3 = { 3, 7, 15, 4 / 3, 155, 100, 15, 1.732, 5, 2, 3, 2 };
             double[] Arre4 = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };
            //se llama el metodo quicksort para ordenar cada uno de los arreglos
            Swap(Arre1, 0, Arre1.Length - 1);
            Console.WriteLine("Primer arreglo ordenado");
            for(int i=0;i<Arre1.Length; i++)
            {
                Console.Write(Arre1[i].ToString() + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Segundo arreglo ordenado");
            Swap(Arre2, 0, Arre2.Length - 1);
            for (int i = 0; i < Arre2.Length; i++)
            {
                Console.Write(Arre2[i].ToString() + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Tercer arreglo ordenado");
            Swap(Arre3, 0, Arre3.Length - 1);
            for (int i = 0; i < Arre3.Length; i++)
            {
                Console.Write(Arre3[i].ToString() + ", ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Cuarto arreglo ordenado");
            Swap(Arre4, 0, Arre4.Length - 1);
            for (int i = 0; i < Arre4.Length; i++)
            {
                Console.Write(Arre4[i].ToString() + ", ");
            }
            Console.ReadKey();
        }
    }
}
