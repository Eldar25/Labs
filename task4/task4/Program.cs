using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int n = int.Parse(s);
            for(int i = 0; i < n; i++)
            {
                for(int j =0; j < n; j++)
                {
                    if (j - i <= 0)
                    {
                        Console.Write("[*]");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
