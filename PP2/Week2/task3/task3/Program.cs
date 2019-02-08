using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void Psp(int time)
        {
            for(int i = 0; i < time; i++)
            {
                Console.Write("   ");
            }
        }
        static void Main(string[] args)
        {
            int k = 0;

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\t");
            foreach (var fi in di.GetFileSystemInfos("*", SearchOption.AllDirectories))
            {
                if(fi.GetType() == typeof(DirectoryInfo))
                {
                    k++;
                    Psp(k);
                    Console.WriteLine(fi.Name);
                }
                else if(fi.GetType() == typeof(FileInfo))
                {
                    Psp(k + 1);
                    Console.WriteLine("  " + fi.Name);
                }
                // k++;
                //Console.WriteLine(fi.Name);
            }
            //Console.WriteLine();
           // Console.WriteLine(k);
            Console.WriteLine();
        }
    }
}
