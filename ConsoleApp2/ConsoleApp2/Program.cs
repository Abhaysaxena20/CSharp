using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2   //This is Program of Inheritance//
{
    public class Program
    {
        public virtual void display()
        {
            Console.WriteLine("this is display1");
        }
    }
        public class Program2 : Program
        {     
           public override void display() {
            Console.WriteLine("this is display2");
        }
      static void Main(string[] args)
        {
            Program2 obj = new Program2();
            obj.display();
        }
    }
}
