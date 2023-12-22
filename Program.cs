using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string way = @"D:\2k\lb3(1)\files\";
            string[] fileNames = {
                "10.txt", "11.txt", "12.txt",
                "13.txt", "14.txt", "15.txt",
                "16.txt", "17.txt", "18.txt",
                "19.txt", "20.txt", "21.txt",
                "22.txt", "23.txt", "24.txt",
                "25.txt", "26.txt", "27.txt",
                "28.txt", "29.txt"};
            int count = 0;

            try
            {
                File.Delete(way + "no_file.txt");
                File.Delete(way + "bad_data.txt");
                File.Delete(way + "overflow.txt");
                Directory.GetFiles(way);
                long res = CurrentDirectory.CurrentFiles(way, fileNames, ref count);
                Console.WriteLine(res / count);
                Console.ReadKey();
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Папку {way} не знайдено");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Усі файли невідповідні, тому середнє значення визначити неможливо");
            }
        }
    }
}
