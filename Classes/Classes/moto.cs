using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Moto : Vehicule
    {
        public Moto(string c, int v) : base(c, v)
        {
            Console.WriteLine("Moto créée");
        }

    }
}
