using System;

namespace gitTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int XorO=Console.Read();
            XorO = XorO - 48;
            int counter = 2;
            
            string[,] field = {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };
     
            string[,] field1 = field;
            field = Number2(field, XorO, counter);
            if (field != field1)
            {
                counter++;
            }
         




          









new Drawing().Start(field);

            
            Console.ReadKey();
        }
        static string[,] Number2(string[,] s_field,int XorO, int s_counter)
        {
           

            if (XorO <= 0 || XorO > 9)//проверка 
            {
                return (s_field);
            }
            for (int i = 0; i < 3; i++)//проверка
            {
                for (int j = 0; j < 3; j++)
                {
                    if (s_field[i, j] == "X" || s_field[i, j] == "O")
                    {
                        return (s_field);
                    }
                }
            }

            if (s_counter % 2 == 0)
            {
                if(XorO==1)
                {
                    s_field[0, 0] = "O";
                    return s_field;
                
                }
                else if (XorO == 2)
                {
                    s_field[0, 1] = "O";
                    return s_field;

                }
                else if (XorO == 3)
                {
                    s_field[0, 2] = "O";
                    return s_field;

                }
                else if (XorO == 4)
                {
                    s_field[1, 0] = "O";
                    return s_field;

                }
                else if (XorO == 5)
                {
                    s_field[1, 1] = "O";
                    return s_field;

                }
                else if (XorO == 6)
                {
                    s_field[1, 2] = "O";
                    return s_field;

                }
                else if (XorO == 7)
                {
                    s_field[2, 0] = "O";
                    return s_field;

                }
                else if (XorO == 8)
                {
                    s_field[2, 1] = "O";
                    return s_field;

                }
                else if (XorO == 9)
                {
                    s_field[2, 2] = "O";
                    return s_field;

                }

            }

            else if (s_counter % 2 == 1)
            {
                if (XorO == 1)
                {
                    s_field[0, 0] = "X";
                    return s_field;

                }
                else if (XorO == 2)
                {
                    s_field[0, 1] = "X";
                    return s_field;

                }
                else if (XorO == 3)
                {
                    s_field[0, 2] = "X";
                    return s_field;

                }
                else if (XorO == 4)
                {
                    s_field[1, 0] = "X";
                    return s_field;

                }
                else if (XorO == 5)
                {
                    s_field[1, 1] = "X";
                    return s_field;

                }
                else if (XorO == 6)
                {
                    s_field[1, 2] = "X";
                    return s_field;

                }
                else if (XorO == 7)
                {
                    s_field[2, 0] = "X";
                    return s_field;

                }
                else if (XorO == 8)
                {
                    s_field[2, 1] = "X";
                    return s_field;

                }
                else if (XorO == 9)
                {
                    s_field[2, 2] = "X";
                    return s_field;

                }

            }
            return s_field;
        }
    }
}

