using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E_6_2Busqueda_Binaria
{
    class BusquedaBinaria1
    {
        public int Busquedabina(int [] arreglo, int element)//metodo que retornara un entero y que pasara por parametro un arreglo y un entero
        {
          int centro, primero, valorcentro;//creacion de 4 variables
          primero =0;//primero, centro y ultimo son indices
          int  ultimo = arreglo.Length - 1;//sera el tamaño del arreglo
            while(primero<=ultimo)//mientras primero sea menor o igual a ultimo entonces va hacer
            {
                centro = (primero + ultimo) / 2;//el centro sera el primero mas el ultimo entre 2
                valorcentro = arreglo[centro];//valorcentro se le asignara el valor que que tiene el indice centro dentro del arreglo
                Console.WriteLine(" comparando " + element + " con " + arreglo[centro]);//se hace la comparacion del elemento con el indice centro del arreglo
                if(element == valorcentro)//si el elemento es == al valorcentro
                {
                    return centro;//que nos retorne el indice
                }
                else if(element<valorcentro)//si no se cumple esto
                {
                    ultimo = centro - 1;//nos desplaza a la izquierda
                }
                else
                {
                    primero = centro + 1;//nos dezplazara a la derecha
                }
            }
            return -1;//cuando se retorna un -1 es que no se encontro el elemento

        }
        public void Swap(int [] arreglo, int primeo, int ultimo)//se crea un metodo que pasara por parametro un arreglo y dos variables
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
                    int temporal = arreglo[a];
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
            int [] vector1 = {55,4,43,44,2,10,4567,638,3,0,-5,-9};
            Console.WriteLine("Arreglo desordenado");
            foreach(double i in vector1)//imprime el arreglo desordenado
            {
                Console.WriteLine("[{0}]",i);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Arreglo ordenado");//imprime el arreglo ordenado
            Swap(vector1, 0, vector1.Length-1);
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write(vector1[i].ToString() + ", ");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            double indice = Busquedabina(vector1, numero);//aqui se inicia la busqueda binaria del elemento
            if(indice != -1)//si el indice es diferente de -1 es que si esta el elemento
            {
                Console.WriteLine("Elemento {0} encontrado en el indice {1}", numero, indice);
            }
            else//si no pues el elemento no esta
            {
                Console.WriteLine("Elemento {0} no encontrado",numero);
            }
            Console.ReadKey();
        }
    }
}
