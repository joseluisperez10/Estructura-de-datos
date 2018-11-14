using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2JoseLuisPerez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tree Arboles3 = new Tree();//Se crea un objeto de tipo Tree llamado Arboles3
                Arboles3.ImprimirArbolA();//se llama al metodo ImprimirArbolA de la clase Tree
                Console.Clear();
                Arboles3.ImprimirArbolB();
                Console.Clear();
                Arboles3.ImprimirArbolC();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
