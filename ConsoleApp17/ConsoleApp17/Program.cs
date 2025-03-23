using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            foreach (DriveInfo dr2 in drive)
            {
                Console.WriteLine("======================Drive Name======================");
                Console.WriteLine("Drive FullName : " + dr2.Name);
                Console.WriteLine("Drive Size : " + dr2.TotalSize);
                Console.WriteLine("Drive Freespace: " + dr2.TotalFreeSpace);
                Console.WriteLine("Drive Format : " + dr2.DriveFormat);
                Console.WriteLine("Drive Type : " + dr2.GetType().Name);
            }
        }
    }
}
