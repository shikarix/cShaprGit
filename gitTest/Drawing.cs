using System;
using System.Collections.Generic;
using System.Text;

namespace gitTest
{
    class Drawing
    {
        public void Start(string[,] field)
        {
            foreach(string line in field)
            {
                Console.Write(line);
            }
            

        }
    }
}
