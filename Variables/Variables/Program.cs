using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Théophile";
            float age = 25.9f;
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine($"Bonjour, je m'appelle {firstName}, j'ai {age} ans et je mesure {height}");
            Console.ReadLine();
        }
    }
}