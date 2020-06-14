using System;

namespace gitTest
{
    class Drawing
    {
        public void Start(string[,] field)
        {
            for(int i = field.Length; i > 0; i--) { 
                Console.WriteLine(field[i,i]);
            }
            

        }
    }
}
