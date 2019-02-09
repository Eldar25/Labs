using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo di = new DirectoryInfo(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path");
            string di = (@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path\");
            string path1 = @"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path1";
            string path = @"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path";
            string nameoft = Console.ReadLine();
            string dir = Path.Combine(path, nameoft + ".txt");
            string dir1 = Path.Combine(path1, nameoft + ".txt");
            StreamWriter sw = File.CreateText(dir);
            sw.Close();
            Console.WriteLine("New file was created");
            File.Copy(dir, dir1, true);
            Console.WriteLine("File has been moved");
            Console.WriteLine("Do you want to delete original?");
            string s = Console.ReadLine();


            File.Delete(di + nameoft + ".txt");
            //File.Delete(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path\papa1.txt");
        }
    }
}
