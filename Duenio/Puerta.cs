using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dueño
{
    internal class Puerta
    {
        public string Color { get; set; }

        public Puerta()
        {
            Color = "Cafe";
        }

        public Puerta(string color)
        {
            Color = color;
        }

        public void SetColor (string color)
        {
            Color = color;
        }
        public void MostrarDatos()
        {
             Console.WriteLine($"Soy puerta, mi color es {Color}");
        }
        
    }
}
