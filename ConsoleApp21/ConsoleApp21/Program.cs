using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 6, 8, 9, 11, 13, 23, 25, 34, 45 };
            int target = 36,flag=0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1;j<arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        flag =1;
                        break;
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Yes ,Sum of 2 elements is Equal to Target: ");
            }
            else
            {
                Console.WriteLine("No ,Sum of 2 elemets is not Equal to Target: ");
            }
               
        }

    }
}
