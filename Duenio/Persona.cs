using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueño
{
    internal class Persona
    {
        public string nombre { get; set; }
        public Casa casa { get; set; }

        public Persona()
        {
            this.nombre = "Juan";
            this.casa.Area = 150;
        }

        public Persona(string nombre, Casa casa)
        {
            this.nombre = nombre;
            this.casa = casa;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetCasa(Casa casa)
        {
            this.casa = casa;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Mi nombre es {nombre} \n {casa.MostrarDatos} \n {casa.puerta.MostrarDatos}");
        }
    }
}
