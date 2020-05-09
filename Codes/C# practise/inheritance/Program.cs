using System;

namespace inheritance
{
    class shape
    {
        public void setwidth(int w)
        { 
            width = w;
        }
        public void setheight(int h)
        {
            height = h;
        }
        public int width;
        public int height;

    }
    class Rectangle : shape
    {
        public int getarea()
        {
            return width * height;
        }
    }
    class Rectanglatester
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.setheight(5);
            rect.setwidth(10);

            Console.WriteLine("The area is: {0}", rect.getarea());

        }
    }
}
