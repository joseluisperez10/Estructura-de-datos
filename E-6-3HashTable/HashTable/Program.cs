using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Hashtable mitable = new Hashtable();
                //adicionamos elementos
                mitable.Add(20, "Hola");//no se pueden repetir los Key, los Value si
                mitable.Add(33, "Mundo");
                mitable.Add(21, "Programacion");
                mitable.Add(10, "Java");
                mitable.Add(12, "C#");
                mitable.Add(14, "C++");
                mitable.Add(56, "Visual");
                mitable.Add(100, "Basic");
                //mostramos los elementos
                foreach (DictionaryEntry elemento in mitable)
                {
                    Console.WriteLine("({0} , {1})", elemento.Key, elemento.Value);
                }
                //cantidad de elementos dentro de la tabla
                Console.WriteLine("Cantidad de elementos en la tabla: {0}",mitable.Count);
                //obtenemos el elemento de determinada llave
                Inicio:
                Console.Write("Ingrese una clave: ");
                int x = int.Parse(Console.ReadLine());
                if(mitable.Contains(x))//una condicion si el elemento existe o no dentro de la coleccion
                {
                    Console.Clear();
                    Console.WriteLine(mitable[x]);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Dato no existente, Ingrese otro numero");
                    goto Inicio;
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
