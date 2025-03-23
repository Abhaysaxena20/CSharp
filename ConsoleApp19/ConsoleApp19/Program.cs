using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] arr = { 2,5,1,5,2,7,4,9,1,11,7,8,11,};
                int duplicate = -1;
                Array.Sort(arr);
                ArrayList arr2=new ArrayList();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == duplicate)
                    {
                        arr2.Add(arr[i]);
                    }
                    else
                    {
                        duplicate = arr[i];
                    }
                }
                foreach (object i in arr2)
                {
                    Console.WriteLine(i + " ");
                }
            }
           
            catch (FormatException br)
            {
                Console.WriteLine("=============Format Exception Seems============");
                Console.WriteLine(br.Message);
                Console.WriteLine(br.Source);
                Console.WriteLine(br.StackTrace);
                Console.WriteLine(br.HelpLink);
            }
            catch (OverflowException br)
            {
                Console.WriteLine("=============Overflow Exception Seems============");
                Console.WriteLine(br.Message);
                Console.WriteLine(br.Source);
                Console.WriteLine(br.StackTrace);
                Console.WriteLine(br.HelpLink);
            }
            catch (IndexOutOfRangeException br)
            {
                Console.WriteLine("==============Index Out of Exceptiopn Seems============");
                Console.WriteLine(br.Message);
                Console.WriteLine(br.Source);
                Console.WriteLine(br.StackTrace);
                Console.WriteLine(br.HelpLink);
            }
            catch (Exception br)
            {
                Console.WriteLine("==============Parent Exception Seems===================");
                Console.WriteLine(br.Message);
                Console.WriteLine(br.Source);
                Console.WriteLine(br.StackTrace);
                Console.WriteLine(br.HelpLink);
            }
            finally
            {

            }
        }
    }
}
