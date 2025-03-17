using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class2
    {
        public virtual void display()
        {
            Console.WriteLine("This is Me Method1");
        }
    }
    public class Class3 : Class2
    {
        public override void display()
        {
            Console.WriteLine("This is Method2");
        }
        public static void Main(String[] args)
        {
            Class3 ob = new Class3();
            ob.display();

        }

    }
}
