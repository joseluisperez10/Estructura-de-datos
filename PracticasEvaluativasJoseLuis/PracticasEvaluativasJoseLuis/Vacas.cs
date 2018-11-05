using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasEvaluativasJoseLuis
{
    public class vacas1
    {
        string nombre;
        int tiempo;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public vacas1(string nombre, int tiempo)
        {
            this.nombre = nombre;
            this.tiempo = tiempo;
        }
    }
}
