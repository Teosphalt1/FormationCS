using System;


namespace ConsoleAppPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer hpOmen = new Computer("HP OMEN", "999888", 1500, "Intel core i7; RTX 3090");
            Computer asusRog = new Computer("asusRog", "99849", 15000, "Intel core i5; RTX 3080TI");
            Laptop myLaptop = new Laptop("MSI", "12345", 890, "Ryzen 5; GTX 1080", "16 pouces");

            //asusRog.Decrire();
            //myLaptop.Decrire();

            Macbook macbook = new Macbook("MacBook Air", "6541", 15000, "M1; None", "20 pouces", "IOS");

            macbook.Decrire();

            List<Computer> computers = new List<Computer>
            {
                new Computer("ACER Predator", "4567", 41065, "None;None"),
                new Computer("Dell Pavillon", "001", 1505, "None;None"),
                new Computer("Rog Strix", "20", 150, "None;None")

            };

            foreach(Computer c in computers)
            {
                c.Decrire();
            }

            Console.WriteLine("==============END==============");
        }
    }

    // Interface pour décrire un ordinateur
    interface IDescriptible
    {
        void Decrire();
    }

    class Computer : IDescriptible
    {
        /// <summary>
        /// Propriétés, caractéristiques de la classe
        /// </summary>
        public string name { get; set; }
        public string reference { get; set; }
        public int price { get; set; }
        public string characteristic { get; set; }


        static int nbComputers = 0;

        public Computer(string name, string reference, int price, string characteristic)
        {
            this.name = name;
            this.reference = reference;
            this.price = price;
            this.characteristic = characteristic;

            nbComputers++;
        }

        public virtual void Decrire()
        {
            Console.WriteLine($"{name} ({reference})");
            Console.WriteLine($"nb computers = {nbComputers}");
            DecrireCharacteristics();
        }

        protected void DecrireCharacteristics()
        {
            string[] caracts = characteristic.Split(';');
            Console.WriteLine($"*** Caractéristiques de l'ordinateur***");
            Console.WriteLine($"CPU " + caracts[0]);
            Console.WriteLine($"GPU " + caracts[1]);
        }

        public void displayNbComputers()
        {
            Console.WriteLine($"{nbComputers} ordinateurs ont été créés.");
        }
    }

    class Laptop : Computer
    {
        string displaySize;

        public Laptop(string name, string reference, int price, string characteristic, string displaySize): base(name, reference, price, characteristic)
        {
            this.displaySize = displaySize;
        }

        public override void Decrire()
        {
            base.Decrire();
            Console.WriteLine($"Laptop avec un écran de {displaySize}");
        }
    }

    class Macbook : Laptop
    {
        string os;

        public Macbook(string name, string reference, int price, string characteristic, string displaySize, string os) : base(name, reference, price, characteristic, displaySize)
        {
            this.os = os;
        }

        public override void Decrire()
        {
            base.Decrire();
            Console.WriteLine($"Le système d'exploitation est {os}");
        }
    }
}