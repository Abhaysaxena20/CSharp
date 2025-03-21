using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string path = @"D:\GIT\CSharp";
            var Directory =new DirectoryInfo(path);
            Console.WriteLine("Directory Name = "+Directory.FullName);
            Console.WriteLine("Directory Size = "+Directory.Parent);
            Console.WriteLine("Directory Create Date = "+Directory.CreationTime);
            Console.WriteLine("Directory Last Access Date = "+Directory.LastAccessTime);

        }
           
    }
}
