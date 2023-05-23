using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Voiture : Vehicule
    {
        int nbAirbags;
        public Voiture(string c, int v, int nb):base (c,v)
        {
            nbAirbags = nb;
        }

        public void DeclencherAirbags()
        {
            Console.WriteLine("Lancement Airbag");
        }
    }
}
