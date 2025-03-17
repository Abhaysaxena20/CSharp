using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        Program()
        {
            Console.WriteLine("This is me Constructor");
        }
       
        static void Main(string[] args)
        {
           new Program();
        }
    }
}
