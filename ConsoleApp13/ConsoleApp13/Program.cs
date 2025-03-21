using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
   public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 1, c;
                Console.WriteLine(" " + a + "\n" + " " + b);
                for (int i = 2; i < 20; i++)
                {
                    c = a + b;
                    b = c;
                    a = b;
                    Console.WriteLine(" " + c);
                }
            }
            catch (FormatException dr)
            {
                Console.WriteLine("=============Format Exception seems===========");
                Console.WriteLine(dr.Message);
                Console.WriteLine(dr.StackTrace);
                Console.WriteLine(dr.Source);
                Console.WriteLine(dr.HelpLink);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("==============OverFlowException seems===========");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);

            }
            catch (Exception ex)
            {
                Console.WriteLine("==================Parent Exception Seems===========");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.HelpLink);
            }
        }
    }
}
