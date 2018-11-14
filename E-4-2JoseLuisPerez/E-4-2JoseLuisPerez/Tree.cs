using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2JoseLuisPerez
{
    class Tree
    {
        int CordenadaA = 0,
            CordenadaB = 5;//Para que se dibujen en el arbol
        public void AgregarArre1(Node node, string name, string[] names)//Metodo llamado AgregarArre1
        {
            if (node.Arre1 != null)//entra en la primera vuelta
            {
                foreach (Node item in node.Arre1)//por cada item de la clase Node en Arre1 
                {
                    AgregarArre1(item, name, names);
                }
            }
            else//aqui ya es en la segunda vuelta
            {
                if (node.nombre == name)
                {
                    node.Arre1 = new Node[names.Length];//se crea un nuevo arreglo Node que se le asigna al atributo Arre1 
                    for (int i = 0; i < names.Length; i++)
                    {
                        node.Arre1[i] = new Node(names[i]);//se crea un nuevo arreglo de Node con parametro names en i, y se iguala al atributo Arre1 en la posicion i 
                    }
                }
            }
        }
        int Altura = 0, Nivel = 0;//variables patra la altura y nivel
        public void Imprimir(Node node)//metodo imprimir con un parametro de tipo nodo
        {

            if (node.Arre1 != null)//entra la primera vez
            {
                Console.SetCursorPosition(CordenadaA, CordenadaB);//para que se imprima en cierta posicion de la consola
                Console.Write(node.nombre);//Se imprime el atributo nombre 
                CordenadaA += 5;
                CordenadaB++;
                for (int i = 0; i < node.Arre1.Length; i++)
                {
                    Imprimir(node.Arre1[i]);//se llama el metodo impresion con parametro Arre1 en la posicion i 
                }
                CordenadaA += 5;
            }
            else// entra en la seguda vuelta
            {
                Console.SetCursorPosition(CordenadaA, CordenadaB);// para que aparezca en las coordenadas
                Console.Write(node.nombre);
                CordenadaB++;// se incrementa la coordenada B
            }

            Altura = ((CordenadaB - 1) / 2) - 1;// altura se iguala a ((CordenadaB - 1) /2) - 1
            Nivel = Altura;// Nivel se iguala a Altura 
        }
        public void AlturaNivel()//metodo que imprimira altura y nivel
        {
            Console.WriteLine();
            Console.WriteLine("Altura: {0}", Altura);//Imprime la altura
            Console.WriteLine("Nivel: {0}", Nivel);//imprime el nivel
        }

        public void ImprimirArbolA()//Metodo que imprime el arbol A 
        {
            Console.WriteLine("Arbol A");
            Node Raiz1 = new Node("E");//este sera la raiz
            Tree Arbol = new Tree();//se crea un objeto de tipo Tree llamado Arbol
            Arbol.AgregarArre1(Raiz1, "E", new string[] { "F", "A" });//se llama el metodo AgregarArre1 dandole distintos parametros
            Arbol.AgregarArre1(Raiz1, "A", new string[] { "B", "C", "D" });
            Arbol.Imprimir(Raiz1);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol.AlturaNivel();//Se llama al metodo AlturaNivel que imprime la altura y el nivel 
            Console.WriteLine("Ruta para el camino mas largo: E-->A-->(B,C,D)");//ruta al camino mas largo
            Console.ReadKey();
        }

        public void ImprimirArbolB()//metodo que imprime el arbol B
        {
            Console.WriteLine("Arbol B");//
            Node Raiz1 = new Node("C");//La letra C es la raiz
            Tree Arbol = new Tree();//se crea un objeto de tipo Tree llamado Arbol
            Arbol.AgregarArre1(Raiz1, "C", new string[] { "D", "F", "G", "A" });//se llama el metodo AgregarArre1 dandole distintos parametros
            Arbol.AgregarArre1(Raiz1, "A", new string[] { "B" });
            Arbol.AgregarArre1(Raiz1, "B", new string[] { "E" });
            Arbol.Imprimir(Raiz1);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol.AlturaNivel();//Se llama al metodo AlturaNivel que imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: C-->A-->B-->E");//Ruta al camino mas largo
            Console.ReadKey();
        }

        public void ImprimirArbolC()//metodo que imprime el arbol C
        {
            Console.WriteLine("Arbol C");
            Node NodoRaiz = new Node("K");//K que es la raiz
            Tree Arbol2 = new Tree();//se crea un objeto de tipo Tree llamado Arbol2
            Arbol2.AgregarArre1(NodoRaiz, "K", new string[] { "A", "C", "B", "D" });//se llama el metodo AgregarArre1 dandole distintos parametros
            Arbol2.AgregarArre1(NodoRaiz, "D", new string[] { "I    J", "E" });
            Arbol2.AgregarArre1(NodoRaiz, "E", new string[] { "F", "G" });
            Arbol2.AgregarArre1(NodoRaiz, "G", new string[] { "H" });
            Arbol2.Imprimir(NodoRaiz);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol2.AlturaNivel();//Se llama al metodo AlturaNivel que imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: K-->D-->E-->G-->H");//Ruta al camino mas largo
            Console.ReadKey();
        }
    }
}
