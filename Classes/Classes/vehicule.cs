using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Vehicule
    {
        string couleur;
        int vitesse;

        public Vehicule(string c, int v)
        {
            couleur = c;
            vitesse = v;
        }

        public void setColor(string c)
        {
            couleur = c;
        }
        public void Accelerate(int val)
        {
            vitesse = vitesse + val;
        }

        public string GetColor()
        {
            return couleur;
        }

        public int GetSpeed()
        {
            return vitesse;
        }
    }
}
