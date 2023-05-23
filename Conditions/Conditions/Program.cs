using System;

namespace Conditions
{
    class Program
    {
        static float solde = 100;
        static int age = 20;
        static void Main(string[] args)
        {
            Console.WriteLine($"Solde = {solde}");
            if(age <= 18)
            {
                Console.WriteLine("Trop jeune");
            }
            else
            {
                Console.WriteLine("Age adéquat");
            }
            AcheterProduit(50);
            Console.WriteLine($"Solde = {solde}");
            AcheterProduit(10); 
            Console.WriteLine($"Solde = {solde}");
            AcheterProduit(50);
            Console.WriteLine($"Solde = {solde}");
        }

        static void AcheterProduit(float prix)
        {
            solde = solde - prix;
        }
    }
}