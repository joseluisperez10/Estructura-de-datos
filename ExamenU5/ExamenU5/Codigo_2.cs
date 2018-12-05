using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5
{
    class Codigo_2
    {
        //metodo radix
        public void radix(int[] Arre1)//recibe de parametro un arreglo
        {
            int a, b, c;
            for (a = 31; a >= 0; a--)
            {
                int[] aux = new int[Arre1.Length];//este nuevo arreglo se hace para hacer el movedero de los numeros
                c = 0;//se inicializa la variable C en cero, ya que sera un contador 
                for (b = 0; b < Arre1.Length; b++)
                {
                    bool mover = Arre1[b] << a >= 0;//variable de tipo bolean,  es como una pregunta, si es mayor a cero te devuelve un true o lo movera
                    if (a == 0 ? !mover : mover)//si la a es igual igual a cero entonces entra la condicion, el ? es un operador ternario
                    {
                        aux[c] = Arre1[b];//se intercambian los arreglos
                        c++;
                    }
                    else//entra el else en caso de que no resulte ser cierta la condicion
                    {
                        Arre1[b - c] = Arre1[b];
                    }
                }
                for (b = c; b < aux.Length; b++)//este for sirve para ir copiando lo que tengamos en el arreglo auxiliar
                {
                    aux[b] = Arre1[b - c];
                }
                Arre1 = aux;//se copea lo que ya se tiene en nuestro arreglo
            }
            Mostararreglo(Arre1);//se muestra el arreglo ordenado
        }
        public void Mostararreglo(int[] arreglo)//este metodo muestra el arreglo pero sin ordenar
        {
            int k;
            for (k = 0; k < arreglo.Length; k++)
            {
                Console.Write(arreglo[k] + ", ");
            }
            Console.ReadKey();
        }
        public void imprimir()
        {
            int x = 0;
            int[] arre1 = new int[80];
            Random r = new Random();
            for (int i = 0; i < 80; i++)
            {
                x = r.Next(0, 200);
                if (arre1.Contains(x))
                {
                    i = i - 1;
                }
                else
                {
                    arre1[i] = x;
                }
            }
            radix(arre1);

        }
    }
}
