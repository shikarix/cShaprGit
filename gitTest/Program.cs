using System;

namespace gitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[,] field = {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };



          











            new Drawing().Start(field);
            Console.ReadKey();
        }
    }
}

