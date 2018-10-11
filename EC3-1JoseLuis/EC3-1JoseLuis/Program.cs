using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EC3_1JoseLuis
{
    class Program
    {
        static void Main(string[] args)
        {

            var pila = new Stack();
            pila.Push("Juan");
            pila.Push("Paco");
            pila.Push("Pedro");
            pila.Push(1000);
            Console.WriteLine("Lista de la pila");
            foreach (var i in pila)//imprimira los datos almacenados en la pila
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("La pila contienene a Pedro");
            bool contiene = pila.Contains("Pedro"); //indica si un cierto elemento esta en la pila
            Console.WriteLine(contiene);//si el elemento esta en la pila sera true, y si no esta pues sera false.
            Console.WriteLine(pila.Pop().GetType());//Para saber de que tipo son los elementos almacenados en la pila
            Console.WriteLine(pila.Contains(123).ToString());//devuelve el elemento actual convertido en un string
            Console.WriteLine(pila.ToArray());//Copia la pila a una matriz nueva
            Console.WriteLine(pila.GetEnumerator());//permite usar enumeradores para recorrer la pila
            Console.ReadKey(true);
        }
    }
}
