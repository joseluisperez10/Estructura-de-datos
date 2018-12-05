using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5
{
    public class Codigo_4
    {
        int[] Arreglo;
        char[] Arreglo_1;
        public void Quick()
        {
            int x = 0;
            Arreglo = new int[180];
            Arreglo_1 = new char[180];
            String Letras = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. Duis ac massa est.";
            foreach (char y in Letras.ToUpper())
            {
                Arreglo_1[x] = y;
                x++;
            }
            for (int i = 0; i < Arreglo_1.Length; i++)
            {
                switch (Arreglo_1[i])
                {
                    case 'A':
                        Arreglo[i] = 1;
                        break;
                    case 'B':
                        Arreglo[i] = 2;
                        break;
                    case 'C':
                        Arreglo[i] = 3;
                        break;
                    case 'D':
                        Arreglo[i] = 4;
                        break;
                    case 'E':
                        Arreglo[i] = 5;
                        break;
                    case 'F':
                        Arreglo[i] = 6;
                        break;
                    case 'G':
                        Arreglo[i] = 7;
                        break;
                    case 'H':
                        Arreglo[i] = 8;
                        break;
                    case 'I':
                        Arreglo[i] = 9;
                        break;
                    case 'J':
                        Arreglo[i] = 10;
                        break;
                    case 'K':
                        Arreglo[i] = 11;
                        break;
                    case 'L':
                        Arreglo[i] = 12;
                        break;
                    case 'M':
                        Arreglo[i] = 13;
                        break;
                    case 'N':
                        Arreglo[i] = 14;
                        break;
                    case 'O':
                        Arreglo[i] = 15;
                        break;
                    case 'P':
                        Arreglo[i] = 16;
                        break;
                    case 'Q':
                        Arreglo[i] = 17;
                        break;
                    case 'R':
                        Arreglo[i] = 18;
                        break;
                    case 'S':
                        Arreglo[i] = 19;
                        break;
                    case 'T':
                        Arreglo[i] = 20;
                        break;
                    case 'U':
                        Arreglo[i] = 21;
                        break;
                    case 'V':
                        Arreglo[i] = 22;
                        break;
                    case 'W':
                        Arreglo[i] = 23;
                        break;
                    case 'X':
                        Arreglo[i] = 24;
                        break;
                    case 'Y':
                        Arreglo[i] = 25;
                        break;
                    case 'Z':
                        Arreglo[i] = 26;
                        break;

                }
            }
        }
        public void Swap(int[] arreglo, int primeo, int ultimo)
        {
            int a = primeo, b = ultimo;
            int central = (a + b) / 2;
            int pivote = arreglo[central];
            do
            {
                while (arreglo[a] < pivote) a++;
                while (arreglo[b] > pivote) b--;
                if (a <= b)
                {
                    int temporal = arreglo[a];
                    arreglo[a] = arreglo[b];
                    arreglo[b] = temporal;
                    a++;
                    b--;
                }
            } while (a <= b);
            if (primeo < b) Swap(arreglo, primeo, b);
            if (a < ultimo) Swap(arreglo, a, ultimo);
        }
        public void Imprimir()
        {
            Quick();
            Swap(Arreglo, 0, Arreglo.Length - 1);
            Console.WriteLine("----Letras Ordenadas----");
            string Abe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (var item in Arreglo)
            {
                if (item != 0)
                {
                    Console.Write("  " + Abe[item - 1]);
                }
            }
            Console.WriteLine("\n\n----Numeros ordenados----");
            foreach (var item in Arreglo)
            {
                if (item != 0)
                {
                    Console.Write("  " + item);
                }
            }
            Console.ReadKey();
        }
    }
}
