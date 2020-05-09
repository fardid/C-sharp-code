using System;
using System.Collections.Generic;

namespace BasicDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //list

            /*List<String> listofstring = new List<String>();
            listofstring.Add("zahid");
            listofstring.Add("farhan");
            listofstring.Add("34");

            int ind = listofstring.FindIndex(x => x.Equals("farhan"));
            listofstring.RemoveAt(ind);

            foreach ( var item in listofstring)
            {
                Console.WriteLine(item);
            }
            //String
            string[] name = new string[2];
            
            //stack
            Stack<int> stac = new Stack<int>();

            stac.Push(1);
            stac.Push(2);
            stac.Push(3);
            stac.Pop();

            foreach(var item in stac)
            {
                Console.WriteLine(item);

            }
            
            //queue
            Queue<int> qu = new Queue<int>();

            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);


            for (int i= 0; i < qu.Count; i++)
            {
                Console.WriteLine(qu.Dequeue());

             }
             */
            Dictionary<string, int> student = new Dictionary<string, int>();

            student.Add("age", 20);
            student["weight"] = 60;

            foreach (var item in student)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            
        }
    }
}

