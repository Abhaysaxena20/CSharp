using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Method
    {
        public void Display(int a , int b) {
            int c = a + b;
            Console.WriteLine("The value of c is : " + c);
        }
        public void Display(double a , double b)
        {
            double c = a + b;
            Console.WriteLine("The value of c is : "+c);
        }
        public void Display(int a , double b)
        {
            double c = a + b;
            Console.WriteLine("The value of c is : " + c);
        }
        public void Display(float a , float b)
        {
            double d = a + b;
            Console.WriteLine("The value of c is : " +d);
        }
        public void Display(string c , string d)
        {
            Console.WriteLine(string.Concat(c, d));
        }

    }
}
