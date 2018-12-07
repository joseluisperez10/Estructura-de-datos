using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_6_2Busqueda_Binaria
{
    class BusquedaBinaria2
    {
        public void imprimir()
        {
            int[] Arre1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };//arreglo ya definido y ordenado
            int posini = 0;
            int posfin = Arre1.Length - 1;
            int poscent;//tres variables que funcionan como indices
            Console.Write("Ingrese un Numero: ");
            int a = int.Parse(Console.ReadLine());
            while(posini<=posfin)//si el indice inicial es menor que el final entonces entra el ciclo
            {
                poscent = (posini + posfin) / 2;//se calcula el indice central
                if(Arre1[poscent]==a)//entarara si el elemento esta dentro del arrreglo
                {
                    Console.WriteLine("Dato encontrado entre las posiciones " + posini + " y " + posfin);
                    break;
                }
                else if(a<Arre1[poscent])
                {
                    posfin = poscent - 1;
                }
                else
                {
                    posini = poscent + 1;
                }
            }
            Console.ReadKey();
        }
    }
}
