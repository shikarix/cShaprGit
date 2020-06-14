using System;

namespace gitTest
{
    class Drawing
    {
        public void Start(string[,] field)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Крестики-Нолики\n");
            Console.ResetColor();
            for (int i = 0; i < field.GetLength(0); i++)
            {
               
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    
                    Console.Write(" " + field[i, j]);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|");
                    Console.ResetColor();
                }
                Console.WriteLine();
                if(i!=2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" ————————");
                    Console.ResetColor();
                }

            }
          
        }
    }
}
