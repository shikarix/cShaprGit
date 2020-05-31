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
            char[] pass = "1234567890-=qwertyuiopasdfghjkl;zxcvbnm,.".ToCharArray();
            Random rnd = new Random();
            int rand = rnd.Next(0, 41);
            Console.Title = "ThisPloit";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Loading ThisPloit Framework...");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hacking Pentagon");
            Thread.Sleep(200);
            Console.WriteLine("Password of Pentagon is Leaked:");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Password:");
            Thread.Sleep(200);
            for(int i = 200; i>0;i--)
            {
                rand = rnd.Next(0, 41);
                Console.Write(pass[rand]);
                Thread.Sleep(50);
            }
        }
    }
}
