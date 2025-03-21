using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the value for a :");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value for b :");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a + b;
                Console.WriteLine("The value of c = " + c);
            }
            catch (FormatException br)
            {
                Console.WriteLine("=================Format Exception Seems=============");
                Console.WriteLine(br.Message);
                Console.WriteLine(br.StackTrace);
                Console.WriteLine(br.Source);
            }
            catch (OverflowException br)
            {
                Console.WriteLine("=================OverFlow Exception Seems============");
                Console.WriteLine(br.Message);
                Console.WriteLine(br.StackTrace);
                Console.WriteLine(br.Source);
            }
            catch (Exception ex)
            {
                Console.WriteLine("==================Parent Exception Seems==============");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
            Console.ReadLine();
        }
        }
    }

