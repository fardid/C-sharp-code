using System;

namespace second_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string [] arr = new string[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("The names are-");
            foreach (var items in arr)
            {
                Console.WriteLine(items);
            }*/
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine("you have selected 1");
                    break;
                case 2:
                    Console.WriteLine("you have selected 2");
                    break;
                default:
                    Console.WriteLine("you have selected a random number");
                    break;
            }
        }






            


        
    }
}
