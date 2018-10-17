using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_2_JoseLuis_metodos_de_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Miq = new Queue();
            //adicion de objetos
            Miq.Enqueue("Manzana"); //el metodo Enqueue sirve para ir colocando o adicionando elementos dentro de la coleccion
            Miq.Enqueue("fresa"); //a diferencia de las pilas estas se imprimen asi como se van colocando
            Miq.Enqueue(123);
            Miq.Enqueue("Sandia");
            Miq.Enqueue('a');
            foreach(var i in Miq)
            {
                Console.WriteLine("--> {0}", i);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Dequeue {0}", Miq.Dequeue()); //el dequeue saca el primer elemento que se encuentre adentro de la cola
            foreach (var i in Miq)
            {
                Console.WriteLine("Despues de Dequeue --> {0}", i);
            }
            Console.WriteLine("\n\n");
            //adicionamos mas objetos 
            Miq.Enqueue("Melon");
            Miq.Enqueue(1000);
            Console.WriteLine("Peek {0}", Miq.Peek());//El peek nos regresa el primer elemento de la cola, sin embargo no lo saca de la coleccion
            foreach (var i in Miq)
            {
                Console.WriteLine("Despues de Peek --> {0}", i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Cantidad de elementos: {0}", Miq.Count); //con el metodo Count se hace el conteo de objetos en la cola 
            Console.WriteLine("\n");
            //el metodo contains sirve para saber si tal elemento existe o no existe dentro de la cola
            Console.WriteLine(Miq.Contains("Sandia"));
            Console.WriteLine(Miq.Contains(500));
            Console.ReadKey();
        }
    }
}
