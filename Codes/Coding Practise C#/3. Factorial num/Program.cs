using System;

namespace factorial
{
    public class factoria
    {
        public int fact(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = fact(num - 1) * num;
                return result;
            }

        }
    
        static void Main(string[] args)
        {
            factoria n = new factoria();

            Console.WriteLine("Factorial of 7 is: {0}" +n.fact(7));
            Console.WriteLine("Factorial of 8 is:{0} " + n.fact(8));
        }
    }
}
