using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2JoseLuisPerez
{
    class Node
    {
        public string nombre;
        public Node[] Arre1;//Arreglo de tipo Node llamado Arre1
        public Node()//constructor
        {
        }
        public Node(string name)//constructor con parametro
        {
            nombre = name;//se pasa por parametro
        }
    }
}
