using System;

namespace codingpractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 5;

            for (int i = 1; i <= 9; i++)
            {
                if (i < 5)
                {
                    Console.Write(' ');
                    Console.Write(i);
                }
                else

                    {
                        Console.Write(' ');
                        Console.Write( s );
                        s--;
                    }

                }

            }
        }
    }

