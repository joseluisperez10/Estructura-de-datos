using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasEvaluativasJoseLuis
{
    class Tareas
    {
        //atributos
        int numeroID;
        string nombre;
        string fechaInicio;
        string status;
        string fechaFinalizacion;
        string descripcion;
        //propiedades
        public int NumID
        {
            get { return NumID; }
            set { NumID = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public string FechaFinalizacion
        {
            get { return fechaFinalizacion; }
            set { fechaFinalizacion = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Tareas() { }
        public Tareas(int NumID, string nombre, string fechaInicio, string status, string fechaFinalizacion, string descripcion)
        {
            this.NumID = numeroID;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.status = status;
            this.fechaFinalizacion = fechaFinalizacion;
            this.descripcion = descripcion;
        }
        public void imprimir()//datos que contiene la tarea especificamente
        {
            Console.WriteLine("ID: {0} \nnombre: {1} \nfecha en que se comenzo:{2}\nStatus:{3}" +
                "\nFecha de finalizacion:{4}\nDescripcion{5}", numeroID, nombre, fechaInicio, status, fechaFinalizacion, descripcion);
            Console.WriteLine();
        }
    }
}
