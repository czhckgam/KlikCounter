using System;

namespace KlikCounter
{
    class Program
    { 
        static void Main(string[] args)
        {
            Pade();
        }
        private static void Pade()
        {
            Player player = new Player();
            player.YaaYaa();
            Console.Clear();
            Console.WriteLine("Zadej počet kliků:");
            double kliky;
            try
            {
                kliky = double.Parse(Console.ReadLine());
            }
            catch
            {
                kliky = 50;
                Console.WriteLine("Neumíš zadat číslo. Dej si PADE!");
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Black;
            }
            double done = 0;
            Console.Clear();
            Console.WriteLine(@"Stiskem A započítáš klik 
Stiskem S odebereš klik 
Stiskem Q ukončíš
Stiskem 5 přidáš PADE
Stiskem R začneš znova");
            while (true)
            {
                string selection = Console.ReadKey().KeyChar.ToString().ToUpper();
                Console.WriteLine();
                switch (selection)
                {
                    case "S":
                        if (done < 1)
                        {
                            Console.WriteLine("Má hovno");
                        }
                        else
                        {
                            done--;
                            WriteStatus(kliky, done);
                            Console.Beep(550, 500);
                        }
                        break;
                    case "Q":
                        Console.WriteLine("Vííííííídřená bojovka");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case "A":
                        if (done < kliky - 1)
                        {
                            done++;
                            WriteStatus(kliky, done);
                            if (done % 10 == 0)
                                player.Yaa();
                        }
                        else
                        {
                            done = kliky;
                            for (int i = 0; i < 10; i++)
                            {
                                YouShouldGetPade();
                                DateTime dateTime = DateTime.Now;
                                bool timeOut = false;
                                while (!timeOut)
                                {
                                    TimeSpan time = DateTime.Now - dateTime;
                                    if (time > new TimeSpan(0, 0, 1))
                                        timeOut = true;
                                }
                            }
                            YouShouldGetPade(true);
                        }
                        break;
                    case "5":
                        if (done == kliky)
                        {
                            done = 0;
                            kliky = 50;
                        }
                        else
                            kliky = kliky + 50;
                        Console.WriteLine("Již jen: {0}",kliky-done);
                        player.Nice();
                        break;
                    case "R":
                        Pade();
                        break;
                    case "D":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
                                          
                        ,@,                    
                       ,@@@,               
                      ,@@@@@,              
               `@@@@@@@@@@@@@@@@@@@`       
                 `@@@@@@@@@@@@@@@`         
                   `@@@@@@@@@@@`           
                  ,@@@@@@`@@@@@@,          
                  @@@@`     `@@@@         
                 ;@`           `@;        
                   _   _   _   _          
                  (   (   (   |_)         
                   ~   ~   ~  |
");
                        player.PlaySovietAnthem();
                        break;

                }
            }

        }

        private static void WriteStatus(double kliky, double done)
        {
            Console.WriteLine("Už máš {0}", done);
            Console.WriteLine("Již jen {0}", kliky - done);
        }

        private static void YouShouldGetPade(bool white = false)
        {
            if (!white)
            {
                if (Console.ForegroundColor == ConsoleColor.White || Console.ForegroundColor == ConsoleColor.Green)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Clear();      
            Console.WriteLine("Hotovo, ale zasloužil by sis PADE\nPRO PŘIČTENÍ PADE STISKNI 5 ");
        }
    }
}
