using System;

namespace FirstConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*string stringvalue = Console.ReadLine();

            int value = Convert.ToInt32(Console.ReadLine());

            */

            //testcase
            /*
            int caselimit = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumber = Array.ConvertAll(Console.ReadLine().Split(' '),Convert.ToInt32);
            */

            /*
                string[] twospace = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] arraynum = Array.ConvertAll(twospace,Convert.ToInt32);
            */

            //Eof input
            /* string caseval= " ";
             while ((caseval = Console.ReadLine()) != null && caseval != "")
             {

             }
             */

            
            Fruit fruit = new Fruit();
            fruit.name = "Apple";

            Fruit fruit2 = fruit;
            fruit2.name = "Banana";

            Console.WriteLine(fruit.name);

            /*
             product product = new product();
            product.name = "Light";

            product product2 = product;
            product2.name = "Fan";

            Console.WriteLine(product.name);
            */

        }
    }

    public struct Fruit
    {
        public string name;
    }

    public class product
    {  
        public string name;
    }
}
