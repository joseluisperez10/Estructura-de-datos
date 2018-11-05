using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasEvaluativasJoseLuis
{
    class Practicas
    {

        public void VacasBob()
        {
            /* 1.- Supongamos que Bob tiene cuatro vacas1 que quiere cruzar por un puente,
          * pero solo un yugo, que puede sostener hasta dos vacas1, lado a lado, atadas
          * al yugo.El yugo es demasiado pesado para que lo lleve a través del puente, 
          * pero puede atar(y desatar) vacas1 a él en muy poco tiempo.De sus cuatro vacas1,
          * Mazie puede cruzar el puente en 2 minutos, Daisy puede cruzarlo en 4 minutos, 
          * Crazy puede cruzarlo en 10 minutos y Lazy puede cruzar en 20 minutos.
          * Por supuesto, cuando dos vacas1 están atadas al yugo, deben ir a la velocidad 
          * de la vaca más lenta.Describe cómo Bob puede conseguir que todas sus vacas1 
          * crucen el puente en 34 minutos*/
            List<vacas1> vacas1 = new List<vacas1>// lista de las vacas
            {
             new vacas1 ("mazie", 2),//nombre y el tiempo de cada una de las vacas
             new vacas1 ("daisy", 4),
             new vacas1 ("crazy", 10),
             new vacas1("lazy", 20)
            };
            List<vacas1> Sinpasar = new List<vacas1>();//lista de vacas1 que no han pasado
            Sinpasar.Add(vacas1.ElementAt(0));
            Sinpasar.Add(vacas1.ElementAt(1));
            Sinpasar.Add(vacas1.ElementAt(2));
            Sinpasar.Add(vacas1.ElementAt(3));
            vacas1[] yugo = new vacas1[2];//un arreglo porque el yugo soslo puede llevar 2 vacas
            List<vacas1> Cruzaron = new List<vacas1>();//lista de las vacas que estan del otro lado
            int Sumatoria = 0; //sumatoria del tiempo que tardan en recorrer
            int recorrido = 0;//recorrido en el que va el problema
            imprimirvacas1(Sumatoria, Sinpasar, yugo, Cruzaron, recorrido);//el estado de la primera vuelta
                                                                                  
            recorrido++;
            yugo[0] = vacas1.ElementAt(0);//pongo en el yugo la vaca mazie
            yugo[1] = vacas1.ElementAt(1);//pongo en el yugo a vaca daisy
            Sinpasar.Remove(vacas1.ElementAt(0));//una vez cruzado el puente se elimina
            Sinpasar.Remove(vacas1.ElementAt(1));
            Sumatoria += vacas1.ElementAt(1).Tiempo;//sumatoria de  tiempo de recorrido
            Cruzaron.Add(vacas1.ElementAt(0));//se agregan las vacas porque ya pasaron el puente
            Cruzaron.Add(vacas1.ElementAt(1));
            imprimirvacas1(Sumatoria, Sinpasar, yugo, Cruzaron, recorrido);//imprime el estado cuando la vaca vuelve a regresar
                                                                                   
            recorrido++;
            Cruzaron.Remove(vacas1.ElementAt(1));// elimino de lista de los que ya pasaron porque daisy se va a regresar
            yugo[0] = null;// el yugo en posicion 0 se queda vacio porque mazie se queda al otro lado de puente
            Sumatoria += vacas1.ElementAt(1).Tiempo;//sumo tiempo de recorrido de regreso de daisy
            Sinpasar.Add(vacas1.ElementAt(1)); //regreso a daisy en lista sin pasar
            imprimirvacas1(Sumatoria, Sinpasar, yugo, Cruzaron, recorrido);//lamo a funcion para imprimir estado
            yugo[1] = null;// el yugo en posicion 1  queda vacio puesto que se quita a daisy del yugo
                           //segunda vuelta
            recorrido++;
            yugo[0] = vacas1.ElementAt(2);//pongo en el yugo la vaca crazy
            yugo[1] = vacas1.ElementAt(3);//pongo en el yugo a vaca lazy
            Sinpasar.Remove(vacas1.ElementAt(2));//pasaron el puente por lo que elimino vacas1 de esta lista
            Sinpasar.Remove(vacas1.ElementAt(3));
            Sumatoria += vacas1.ElementAt(3).Tiempo;//sumo tiempo de recorrido
            Cruzaron.Add(vacas1.ElementAt(2));//agrego vacas1  porque ya pasaron el puente
            Cruzaron.Add(vacas1.ElementAt(3));
            imprimirvacas1(Sumatoria, Sinpasar, yugo, Cruzaron, recorrido);//lamo a funcion para imprimir estado
                                                                                   //regreso
            recorrido++;
            Cruzaron.Remove(vacas1.ElementAt(0));// eliminoa mazie de lista de los que ya pasaron porque mazie se va a regresar
            yugo[0] = null; yugo[1] = null;// el yugo  se queda vacio porque crazy y lazy se quedan al otro lado de puente
            yugo[0] = vacas1.ElementAt(0);//pongo en el yugo a vaca mazie
            Sumatoria += vacas1.ElementAt(0).Tiempo;//sumo tiempo de recorrido de regreso de mazie
            Sinpasar.Add(vacas1.ElementAt(0)); //regreso a mazie en lista sin pasar
            imprimirvacas1(Sumatoria, Sinpasar, yugo, Cruzaron, recorrido);//lamo a funcion para imprimir estado
                                                                                   //tercera vuelta
            recorrido++;
            yugo[1] = vacas1.ElementAt(1);//pongo en el yugo a vaca daisy
            Sinpasar.Remove(vacas1.ElementAt(0));//pasaron el puente por lo que elimino vacas1 de esta lista
            Sinpasar.Remove(vacas1.ElementAt(1));
            Sumatoria += vacas1.ElementAt(1).Tiempo;//sumo tiempo de recorrido
            Cruzaron.Add(vacas1.ElementAt(0));//agrego vacas1  porque ya pasaron el puente
            Cruzaron.Add(vacas1.ElementAt(1));
            imprimirvacas1(Sumatoria, Sinpasar, yugo, Cruzaron, recorrido);//lamo a funcion para imprimir estado
        }
        public void CantidadHanoi()
        {
            Stack<int> TorreA = new Stack<int>();//pPila de origen
            Stack<int> TorreB = new Stack<int>();//pila Auxiuliar
            Stack<int> TorreC = new Stack<int>();//Pila destino
            Console.WriteLine("Cntidad de discos");
            int Cantidad = Int32.Parse(Console.ReadLine());
            for (int i = Cantidad; i > 0; i--)
            {
                TorreA.Push(i);
            }
            hanoi(Cantidad, TorreA, TorreB, TorreC);
            ImprHanoi(TorreA, TorreB, TorreC);
            Console.ReadKey();
        }
        public void AdmiTareas()
        {
            /*Agregar y ver tareas numero ID,Tareas con nombre, fecha de inicio, status, fecha de finalizacion, descripcion
             * Debe haber listas Tglobal, listas Tpendiente, listas Finalizadas, Lista en proceso   */

            List<Tareas> Tglobal = new List<Tareas>();//lista de tareas global
            List<Tareas> Tpendiente = new List<Tareas>();//pendiente
            List<Tareas> Proceso = new List<Tareas>();//proceso
            List<Tareas> Finalizadas = new List<Tareas>();//listas Finalizadas
            Inicio1:
            Console.WriteLine("Eliga una opcion");//menu para elegir la opcion deseada
            Console.WriteLine("1. Agregrar tarea");
            Console.WriteLine("2. Ver Tareas");
            Console.WriteLine("0. Salir");
            int num1 = int.Parse(Console.ReadLine());

            switch (num1)
            {
                case 1://agregar tareas
                    Console.WriteLine("Id de la tarea"); //pregunta los atributos del archivo
                    int numeroID = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nombre del documento");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Fecha de asignacion");
                    string fechaInicio = Console.ReadLine();
                    Console.WriteLine("Status");
                    string status = Console.ReadLine();
                    Console.WriteLine("Fecha de finalizacion");
                    string fechaFinalizacion = Console.ReadLine();
                    Console.WriteLine("Descripcion");
                    string descripcion = Console.ReadLine();
                    switch (status)// dependiendo del estatus que le dio el usuario se agrega a determinada lista
                    {//segun el caso agrega en la lista correspondiente el nuevo elemento mandando llamar 
                     //a la clase e ingresando los datos que se pidieron al usuario
                        case "pendiente":
                            Tpendiente.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        case "en proceso":
                            Proceso.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        case "terminado":
                            Finalizadas.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                            break;
                        default:

                            break;
                    }
                    //se agrega tambien en Tglobal puesto que todos deben ingresarse aqui
                    Tglobal.Add(new Tareas(numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion));
                    goto Inicio1;//REGRESA A MENU DE TAREAS es decir a los caso de agregar o ver iniciales

                case 2://caso dos es para ver elementos de una lista determinada
                    Console.WriteLine("¿En que lista se encuentra la tarea que desea ver (insertar numero)?");//da a escoger la lista
                    Console.WriteLine("1. Tpendiente");
                    Console.WriteLine("2. En proceso");
                    Console.WriteLine("3. Finalizadas");
                    int numEleccion = Int32.Parse(Console.ReadLine());
                    switch (numEleccion)
                    {
                        case 1:
                            ver(Tpendiente);//llama a la funcion ver que es para ver los elementos de la lista ya sean todos o uno solo

                            break;
                        case 2:
                            ver(Proceso);
                            break;
                        case 3:
                            ver(Finalizadas);
                            break;
                        default:
                            break;
                    }
                    goto Inicio1;

                case 0:
                    break;
                default:
                    break;
            }
        }
        static void imprimirvacas1(int Sumatoria, List<vacas1> Sinpasar, vacas1[] yugo, List<vacas1> Cruzaron, int recorrido)//imprimir lo que transcurre cada vuelta
        {
            Console.WriteLine("presione una tecla");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Recorrido: " + recorrido);
            Console.Write("vacas sin pasar puente: ");
            foreach (vacas1 x in Sinpasar)
            {
                Console.Write(x.Nombre + "  ");
            }
            Console.WriteLine();
            Console.Write("vacas en yugo: ");
            foreach (vacas1 x in yugo)
            {
                if (x != null)
                {
                    Console.Write(x.Nombre + "  ");
                }
            }
            Console.WriteLine();
            Console.Write("vacas que ya pasaron puente: ");
            foreach (vacas1 x in Cruzaron)
            {
                Console.Write(x.Nombre + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("tiempo transcurrido: {0}", Sumatoria);
            Console.WriteLine();
        }
        static void ver(List<Tareas> lista)//esta funcion hace que si quiere ver algo en especifico o todo lo de la lista
        {
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1. Ver todos los elementos");
            Console.WriteLine("2. Ver un solo elemento de la lista");
            int num3 = int.Parse(Console.ReadLine());
            switch (num3)
            {
                case 1:
                    foreach (Tareas elemento in lista)//imprime todos los elementos de la lista
                    {
                        elemento.imprimir();
                    }
                    break;
                case 2:
                    Console.WriteLine("orden numerico en el que esta el elemento que desea ver");//busca el numero de elemento que el usuario desee
                    int orden = Int32.Parse(Console.ReadLine());
                    lista.ElementAt(orden - 1).imprimir();//se inicializa en cero de nuevo
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
        static void hanoi(int n, Stack<int> a, Stack<int> b, Stack<int> c)
        {
            ImprHanoi(a, b, c);
            if (n == 1)
            {
                c.Push(a.Pop());
            }
            else
            {
                hanoi(n - 1, a, c, b);
                ImprHanoi(a, b, c);
                hanoi(1, a, b, c);
                ImprHanoi(a, b, c);
                hanoi(n - 1, b, a, c);

            }
            ImprHanoi(a, b, c);
        }
        static void ImprHanoi(Stack<int> a, Stack<int> b, Stack<int> c)
        {
            Console.WriteLine("Presione Enter");
            Console.ReadKey();
            Console.Clear();
            Console.Write("TorreA:\n ");
            foreach (int num in a)
            {
                Console.Write(num + "\n ");
            }
            Console.WriteLine();
            Console.Write("TorreB: \n");
            foreach (int num in b)
            {
                Console.Write(num + "\n ");
            }
            Console.WriteLine();
            Console.Write("TorreC:\n ");
            foreach (int num in c)
            {
                Console.Write(num + "\n ");
            }
            Console.WriteLine();

        }
    }
}
