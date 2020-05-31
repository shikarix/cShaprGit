using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace gitTest
{
    class TemnijClass
    {
        public static void Start()
        {
            Console.Clear();
            char[] pass = "1234567890-=qwertyuiopasdfghjkl;zxcvbnm,.:".ToCharArray();
            Random rnd = new Random();
            int rand = rnd.Next(0, 42);
            Console.Title = "ThisPloit";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Loading ThisPloit Framework...");
            Console.ResetColor();
            Thread.Sleep(700);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hacking Pentagon");
            Thread.Sleep(500);
            Console.WriteLine("Password of Pentagon is Leaked:");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Password:");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 200; i>0;i--)
            {
                rand = rnd.Next(0, 42);
                Console.Write(pass[rand]);
                Thread.Sleep(50);
                if(i == 50)
                {
                    Console.Write("\n");
                }
                if (i == 97)
                {
                    Console.Write("\n");
                }
                if (i == 153)
                {
                    Console.Write("\n");
                }
                if (i == 199)
                {
                    Console.Write("\n");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nThere is a password. Copy it, and Enjoy!");
            Thread.Sleep(400);

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
