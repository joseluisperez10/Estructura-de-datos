using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_3JoseLuisGrafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafos Grafitos1 = new Grafos();//Creacion de la clase 
            Grafitos1.Crear(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' });//vertices del grafo
            Grafitos1.AddLink('A', new char[] { 'A', 'B' });//relaciones de cada uno
            Grafitos1.AddLink('B', new char[] { 'A', 'C', 'G' });
            Grafitos1.AddLink('C', new char[] { 'B', 'G', 'D' });
            Grafitos1.AddLink('D', new char[] { 'C', 'E', 'F' });
            Grafitos1.AddLink('E', new char[] { 'D', 'F' });
            Grafitos1.AddLink('F', new char[] { 'G', 'D', 'E' });
            Grafitos1.AddLink('G', new char[] { 'B', 'C', 'F' });
            Grafitos1.Dibujaruniones();//dibujar la tabla de relaciones de cada vertice
            Grafitos1.Trayectoria();//dibujar todos los caminos
            Console.ReadKey();
        }
    }
}
