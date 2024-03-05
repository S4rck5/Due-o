using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueño
{
    internal class Apartamento : Casa
    {
        public Apartamento() : base(50)
        {
           
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Soy un Apartamento, mi area es {Area} m2");
        }
    }
}
