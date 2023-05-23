using System;

namespace TD_AdventureText
{
    class Program
    {

        private int vie = 3;
        private int or = 10;
        static void Main(string[] args)
        {
            Program myProg = new Program();
            myProg.showTitle();
            myProg.ShowRules();

            Console.WriteLine("Vous etes dans une forêt. Aller à l'est ou bien à l'ouest?");
            string dir = Console.ReadLine();
            myProg.choix1(dir);
            dir = Console.ReadLine();
            myProg.choix2(dir);
            dir = Console.ReadLine();
            myProg.choix3(dir);
        }

        void showTitle()
        {
            Console.WriteLine("   _____       .___                         __                           ___________                  __   \r\n  /  _  \\    __| _/___  __  ____    ____  _/  |_  __ __ _______   ____   \\__    ___/  ____  ___  ____/  |_ \r\n /  /_\\  \\  / __ | \\  \\/ /_/ __ \\  /    \\ \\   __\\|  |  \\\\_  __ \\_/ __ \\    |    |   _/ __ \\ \\  \\/  /\\   __\\\r\n/    |    \\/ /_/ |  \\   / \\  ___/ |   |  \\ |  |  |  |  / |  | \\/\\  ___/    |    |   \\  ___/  >    <  |  |  \r\n\\____|__  /\\____ |   \\_/   \\___  >|___|  / |__|  |____/  |__|    \\___  >   |____|    \\___  >/__/\\_ \\ |__|  \r\n        \\/      \\/             \\/      \\/                            \\/                  \\/       \\/       ");
            
        }

        void ShowRules()
        {
            Console.WriteLine("C'est comme un livre dont tu es le héros");
        }

        void choix1(string dir)
        {
            while(dir != "est" || dir!="ouest")
            {
                if (dir == "est")
                {
                    Console.WriteLine("Vous tombez d'une falaise. Perdu!");
                    Environment.Exit(0);
                }
                else if (dir == "ouest")
                {
                    Console.WriteLine("Vous allez à l'ouest. Vous trouvez un château. Entrer par la porte ou bien par la fenêtre?");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrez une destination correcte!");
                    dir = Console.ReadLine();
                }
            }
        }

        void choix2(string dir)
        {
            while (dir != "porte" || dir != "fenêtre")
            {
                if (dir == "porte")
                {
                    Console.WriteLine("Le garde vous a vu. PERDU !");
                    Environment.Exit(0);
                }
                else if(dir == "fenêtre")
                {
                    Console.WriteLine("Vous entrez dans le château. Vous êtes dans le couloir. Ouvrir la porte de gauche ou de droite ?");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrez une destination correcte!");
                    dir = Console.ReadLine();
                }
            }
        }

        void choix3(string dir)
        {
            while(dir!="gauche" || dir!="droite")
            {
                if (dir == "gauche")
                {
                    Console.WriteLine("Le garde vous a vu. PERDU !");
                    Environment.Exit(0);
                }
                else if (dir == "droite")
                {
                    Console.WriteLine("Vous trouvez la princesse, bravo !");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrez une destination correcte!");
                    dir = Console.ReadLine();
                }
            }    
        }

        void ShowInfos()
        {
            Console.WriteLine("Vie = " + vie + " - Or = " + or);
        }
    }
}
