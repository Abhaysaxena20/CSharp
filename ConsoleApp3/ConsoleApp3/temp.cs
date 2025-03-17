using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class temp
    {
        public int a;
        public int b;
        public static temp operator +(temp fir, temp sec)
        {
            temp third = new temp();
            third.a=fir.a+sec.a;
            third.b=fir.b+sec.b;
            return third;
        }
        public static void Main(string[] args)
        {
           temp t1= new temp();
            t1.a = 10;t1.b = 20;
            temp t2= new temp();
            t2.a = 30; t2.b = 40;
            temp t3 = t1 + t2;
            Console.WriteLine(t3.a + " " + t3.b);
        }
    }
   
}
