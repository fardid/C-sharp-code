using System;

namespace box
{
    class Line
    {
        private double length;   // Length of a line

        public Line()
        {   // constructor
            Console.WriteLine("Object is being created");
        }
        ~Line()
        {   //destructor
            Console.WriteLine("Object is being deleted");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
        static void Main(string[] args)
        {
            Line line = new Line();

            // set line length
            line.setLength(6.0);
            Console.WriteLine("Length of line : {0}", line.getLength());
      
    /*class Box
    {
        public double length;
        public double breadth;
        public double height;
    }

class Boxtester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            double volume = 0.0;

            box1.length = 4.5;
            box1.breadth = 5.5;
            box1.height = 5.7;

            box2.length = 8.4;
            box2.breadth = 4.4;
            box2.height = 6.7;


            volume = box1.length * box1.breadth * box1.height;
            Console.WriteLine("Volume of box1 is: {0:F3}", volume);

            volume = box2.length * box2.breadth * box2.height;
            Console.WriteLine("Volume of box2 is: {0}", volume);
            Console.ReadKey();
            */

        }
    }
}
