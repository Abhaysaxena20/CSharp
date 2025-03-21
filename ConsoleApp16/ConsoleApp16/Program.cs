using System;
using System.IO;
using System.Collections;

class Drive
{
    public static void Main(string[] args)
    {
        try
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            foreach (var br in drive)
            {
                Console.WriteLine("=============Drive Name=============");
                Console.WriteLine("Drive Name: " + br.Name);
                Console.WriteLine("Drive Type: " + br.DriveType);
                Console.WriteLine("Drive format: " + br.DriveFormat);
                Console.WriteLine("Drive TotalSize: " + br.TotalSize);
                Console.WriteLine("Drive Total Free size: " + br.TotalFreeSpace);
            }

        }
        catch (FormatException br)
        {
            Console.WriteLine("==================Format Exception Seems==================");
            Console.WriteLine(br.Message);
            Console.WriteLine(br.Source);
            Console.WriteLine(br.StackTrace);
            Console.WriteLine(br.Data);
        }
        catch (OverflowException br)
        {
            Console.WriteLine("===================Overflow Exception Seems=================");
            Console.WriteLine(br.Message);
            Console.WriteLine(br.Source);
            Console.WriteLine(br.StackTrace);
            Console.WriteLine(br.Data);
        }
        catch (FileNotFoundException br)
        {
            Console.WriteLine("====================File Not Found Exception Seems=================");
            Console.WriteLine(br.Message);
            Console.WriteLine(br.Source);
            Console.WriteLine(br.StackTrace);
            Console.WriteLine(br.Data);
        }
        catch (Exception br)
        {
            Console.WriteLine("=====================Parent Exception Seems=======================");
            Console.WriteLine(br.Message);
            Console.WriteLine(br.Source);
            Console.WriteLine(br.StackTrace);
            Console.WriteLine(br.Data);
        }
        finally
        {
            Console.WriteLine("My program is Successfull:");
        }
    }
}
