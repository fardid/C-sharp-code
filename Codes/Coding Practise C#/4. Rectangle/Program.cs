using System;

namespace rectangle
{
    public class rectangle

    {
        double length;
        double width;

        public void details()
        {
            length = 6.4;
            width = 4.4;

        }
        public double getarea()
        {
            return length * width;
        }
        public void display()
        {
            Console.WriteLine("Length:{0} "  +length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + getarea());
        }
    }
    class executerectangle
    {
       static void Main(string[] args)
        {
            rectangle r = new rectangle();
            r.details();
            r.display();
        }
    }
}
