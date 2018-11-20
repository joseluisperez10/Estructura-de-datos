using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3JoseLuisGrafos
{
    class Grafos
    {
        char[] point;//point de grafo
        bool[,] enlaces;//aqui se aran las enlaces
        public void Crear(char[] arre1)//Crea puntos y dimensiones de la tabla
        {
            point = arre1;
            enlaces = new bool[arre1.Length, arre1.Length];
        }
        public void AddLink(char punto, char[] uniones)//Busca la posicion  y le agrega sus relaciones en la tabla
        {
            int x = Array.IndexOf(point, punto);
            for (int i = 0; i < uniones.Length; i++)
            {
                enlaces[x, Array.IndexOf(point, uniones[i])] = true;
            }
        }

        public void Trayectoria()//Se imprime la trayectoria de forma recursiva
        {
            string pasos = "";
            for (int i = 0; i < point.Length; i++)
            {
                Dibujaruniones();
                Caminos(i, pasos, enlaces);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Dibujaruniones()//aqui se dibujara el formato de la tabla
        {
            for (int i = 0; i < point.Length; i++)
            {
                Console.SetCursorPosition((i * 7) + 5, 0);
                Console.Write(point[i]);
            }
            for (int i = 0; i < point.Length; i++)
            {
                Console.SetCursorPosition(0, i + 1);
                Console.Write(point[i]);
            }
            for (int i = 0; i < point.Length; i++)
            {
                for (int o = 0; o < point.Length; o++)
                {
                    Console.SetCursorPosition((i * 7) + 3, o + 1);
                    Console.Write(enlaces[i, o]);
                }
            }
            Console.SetCursorPosition(0, point.Length + 2);
        }
        private void Caminos(int vertice, string pasos, bool[,] enlaces)
        {
            bool ligas = false;//Indicador si el vertice tiene enlaces todavia
            bool[,] momentaneo;
            pasos = pasos + " => " + point[vertice];//pasos hacia el camino
            for (int i = 0; i < point.Length; i++)
            {//For para pasar por las enlaces
                if (enlaces[vertice, i] == true)//Si hay una relacion
                {
                    momentaneo = enlaces;//Se copia la tabla
                    ligas = true;//Se indica que hay un camino existente
                    for (int o = 0; o < point.Length; o++)
                    {//Se modifica para indicar que ya se tomo ese camino
                        momentaneo[o, vertice] = false;
                        momentaneo[o, i] = false;
                    }
                    Caminos(i, pasos, momentaneo);
                }
            }
            if (!ligas)
            {
                Console.WriteLine(pasos);
            }
        }
    }
}
