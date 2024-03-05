using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueño
{
    internal class Casa
    {
        public int Area { get; set; }
        public Puerta puerta { get; set; }

        public Casa(int area)
        {
            Area = area;
        }
        public Casa(Puerta puerta)
        {
            this.puerta = puerta;
        }
        public void SetArea(int area)
        {
            Area = area;
        }
        public void SetPuerta(Puerta puerta)
        {
            this.puerta = puerta;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Soy una Casa, mi area es {Area} m2");
        }
    }
}
