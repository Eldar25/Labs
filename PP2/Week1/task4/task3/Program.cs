using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int[] arr = new int[n];
            for(int  i = 0; i < n; i++)
            {
               arr[i] = Console.ReadLine();
            }
        }
    }
}
