using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto duke390 = new Moto("orange", 0);
            Moto r1 = new Moto("bleu", 0);

            Console.WriteLine($"Couleur de duke 390 est {duke390.GetColor()}");
            Console.WriteLine($"Couleur de yamaha r1 est {r1.GetColor()}");


            Voiture twingo = new Voiture("Blanc", 10, 2);
            twingo.DeclencherAirbags();
            Console.WriteLine($"vitesse de twingo = {twingo.GetSpeed()}");
            twingo.Accelerate(40);
            Console.WriteLine($"vitesse de twingo = {twingo.GetSpeed()}");
        }
    }
}