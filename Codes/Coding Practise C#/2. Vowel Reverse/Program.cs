using System;
using System.IO;
using System.Text;
using System.Web;


namespace reverseString
{
    class Program
    {


        public void Reverse(string s)
        {
            var stringbuilder = new StringBuilder();
            for (int start = 0, end = s.Length - 1; start <s.Length ; start++)
            {
                if ("aeiouAEIOU".IndexOf(s[start]) < 0)
                {
                    stringbuilder.Append(s[start]);
                }
                else
                {
                    while (end >= 0 && "aeiouAEIOU".IndexOf(s[end]) < 0)
                    {
                        end--;
                    }
                    stringbuilder.Append(s[end]);
                    end--;
                }
            }

            Console.WriteLine(stringbuilder.ToString());

        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Program p = new Program();
            p.Reverse(str);
        }
    }
}
