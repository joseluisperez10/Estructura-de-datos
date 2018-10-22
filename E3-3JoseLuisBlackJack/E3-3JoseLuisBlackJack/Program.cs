using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_3JoseLuisBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJack Juego = new BlackJack();//se instancia el objeto Juego de la clase blackjack
            Juego.Jugar();
        }
    }
    public class Carta
    {
        public string Descripcion { get; set; }//atributos de la clase
        private int valor;
        public int Valor
        {
            get
            {
                if (valor == 0)//si es 0 entonces sera un AS
                {
                    bool seguir = true;
                    Console.Write("\nIngrese el valor que quiere que tenga el As\n 1 u 11? ");//el usuario decide que valor toamara
                    while (seguir)
                    {
                        try
                        {
                            string numero = Console.ReadLine();
                            if (numero != "1" && numero != "11")
                                throw new Exception();
                            if (numero == "1")
                                valor = 1;
                            else
                                valor = 11;
                            seguir = false;
                        }
                        catch
                        {
                            Console.WriteLine("solo puede ingresasre 1 u 11");
                            seguir = true;
                        }
                    }
                }
                return valor;//En caso de no ser un As, simplemente le devuelve el valor sin rodeos
            }
            set { valor = value; }
        }
        public Carta(string desc, int value)//Constructor de la carta
        {
            Valor = value;
            Descripcion = desc;
        }
    }
    public class BlackJack//clase nueva
    {
        private List<Carta> ObtenerBaraja()//metodo para regresar todas las cartas agregadas
        {
            List<Carta> baraja1 = new List<Carta>();
            string dibujo = "❤";
            for (int o = 0; o < 4; o++)//iteracion para los 4 simbolos
            {
                switch (o)//son los casos para los valores de los az
                {
                    case 2:
                        dibujo = "🍀";
                        break;
                    case 3:
                        dibujo = "♠️";
                        break;
                    case 4:
                        dibujo = "💎";
                        break;
                }
                for (int i = 1; i < 14; i++)//para la iteracion de las 13 cartas
                {
                    if (i < 11 && i != 1)
                        baraja1.Add(new Carta(i + " " + dibujo, i));//es para darle valor y descripcion
                    else//sino lo es tomara las siguientes condiciones
                    {
                        switch (i)
                        {
                            case 1://como el cero sera el as entonces mas adelante se le asignara el valor correspondiente
                                baraja1.Add(new Carta("A " + dibujo, 0));
                                break;
                            case 11:
                                baraja1.Add(new Carta("J " + dibujo, 10));
                                break;
                            case 12:
                                baraja1.Add(new Carta("Q " + dibujo, 10));
                                break;
                            case 13:
                                baraja1.Add(new Carta("K " + dibujo, 10));
                                break;
                        }
                    }
                }
            }
            return baraja1;//retorna la lista ya cargada
        }

        private Stack<Carta> Moverbaraja()//se crea una pila para revolver las barajas
        {
            List<Carta> Nuevo = ObtenerBaraja();//Creamos una lista a cual le ingresamos todas las cartas con el metodo obtenerbaraja
            Stack<Carta> cartasRevueltas = new Stack<Carta>();//iniciamos la pila y un random
            Random Ran = new Random();
            int temporal;//variable temporal
            for (int i = 0; i < 52; i++)
            {
                temporal = Ran.Next(Nuevo.Count);//Generamos un numero al azar dependiendo de las cartas totales en la lista
                cartasRevueltas.Push(Nuevo[temporal]);//sacamos la carta con el random y la guardamos en la pila
                Nuevo.RemoveAt(temporal);//borrar elemento dentro de la pila
            }
            return cartasRevueltas;//Regresamos las cartas revueltas en la pila
        }
        private void Promedio(int ganados, int perdidos)//se calcula el total de juegos y los ganados y perdidos
        {
            Console.WriteLine("\nJugastes {0} veces, ganaste {1} y perdiste {2}", ganados + perdidos, ganados, perdidos);
        }
        public void Jugar()//Este metodo es donde ocurre el juego
        {
            Stack<Carta> cartas = Moverbaraja();//aqui las cartas ya estan revueltas
            int puntos, cartasSacadas, ganados = 0, perdidos = 0;
            bool continuarPreg, seguirjugando = true;
            Carta carta;
            while (seguirjugando)//es la condicion para que el jugador decida hasta cuando para el juego
            {
                Console.Clear();
                puntos = 0;
                cartasSacadas = 0;
                continuarPreg = true;

                Console.WriteLine("Empieza el juego {0}", ganados + perdidos + 1);
                for (int i = 0; i < 5; i++)//para poder sacar las 5 cartas establecidas por el juego
                {
                    carta = cartas.Pop();//Sacamos nuestra primera carta, sumando cada carta que saquemos
                    ++cartasSacadas;
                    Console.WriteLine("\nCarta No.{0} es: {1}", i + 1, carta.Descripcion);//muestra la carta
                    puntos = carta.Valor + puntos;//suam de puntos de la carta y se imprime
                    Console.WriteLine("Puntos: " + puntos);
                    Console.ReadKey();
                    if (puntos == 21 || cartasSacadas == 5)//si se suman 21 puntos se gana
                    {
                        if (puntos == 21)
                            Console.WriteLine("\nGanaste\nIsiste 21 puntos");
                        else
                            Console.WriteLine("\nGanaste!!!\nCon las 5 cartas");
                        ganados++;//es para la sumatoria de juegos ganados
                        break;
                    }
                    if (puntos > 21)
                    {
                        Console.WriteLine("\nMas de 21 puntos, perdiste...");
                        perdidos++;//sumatoria de juegos perdidos
                        break;
                    }
                }
                Console.WriteLine("\nQuieres Jugar de nuevo? si/no");//Nos pregunta si queremos jugar de nuevo
                while (continuarPreg)
                {
                    try
                    {
                        string opcion = Console.ReadLine();
                        if (opcion != "si" && opcion != "no")
                            throw new Exception();
                        else
                            if (opcion == "si")
                            seguirjugando = true;
                        else
                            seguirjugando = false;
                        continuarPreg = false;
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese si/no ...");
                        continuarPreg = true;
                    }
                }
            }//si ya no desa jugar nos imprime el resultado de ganados o perdidos durante el juego
            Promedio(ganados, perdidos);
            Console.ReadKey();
        }
    }
}
