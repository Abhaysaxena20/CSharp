using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int var;
            int[] arr = { 2, 3, 5, 1, 11, 10, 9, 8, 12, 15 };
            int[] arr2=new int[arr.Length];
            int k = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr2[k] = arr[i];
                k++;
            }
            foreach (int i in arr2)
            {
                Console.WriteLine(" " + i);
            }

        }
    }
}
