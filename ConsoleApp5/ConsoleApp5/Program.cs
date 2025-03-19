using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        enum books
        {
            MATHS,PHYSICS,CHEMISTRY,BIOLOGY,COMMERCE
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maths book is : "+books.MATHS);
            Console.WriteLine("Physics book is : "+books.PHYSICS);
            Console.WriteLine("Biology book is : "+books.BIOLOGY);
            Console.WriteLine("Commerce book is : "+books.COMMERCE);
            Console.WriteLine("Chemistry book is : "+books.CHEMISTRY);
        }
    }
}
