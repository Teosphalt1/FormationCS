using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lancement du programme");
            direBonjour();
            direBonjourParam("Lavensse", "Antoine");
            Test instance = new Test();
            instance.testFunc("Test1", "Test1");
            instance.testFunc("Test2", "Test2");
            instance.testFunc("Test3", "Test3");
            instance.testFunc("Test4", "Test4");
        }

        static void direBonjour()
        {
            Console.WriteLine("Bonjour");
        }

        static void direBonjourParam(string nom, string prenom)
        {
            Console.WriteLine($"Bonjour {nom} {prenom}");
        }
    }

    public class Test
    {
        public void testFunc(string nom, string prenom)
        {
            Console.WriteLine($"Bonjour {nom} {prenom}");
        }
    }
}