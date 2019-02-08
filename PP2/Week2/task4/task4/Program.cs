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
            string fname = Console.ReadLine();
            string sdir1 = @"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path";
            string sdir2 = @"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task4\path1";
            string dir1 = Path.Combine(sdir1, fname);
            string dir2 = Path.Combine(sdir2, fname);
            File.Create(dir1);
            File.Copy(dir1, dir2, true);
            File.Delete(dir1);
        }
    }
}
