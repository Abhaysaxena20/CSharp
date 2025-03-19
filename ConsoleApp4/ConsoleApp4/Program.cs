using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj2 = new Class1("Anubhav", "anubhav123@gmail.com");
            Class1 obj3 = new Class1(obj2);
            Console.WriteLine(obj3.Name+" "+obj3.EMAIL+" ");
        }
    }
}
