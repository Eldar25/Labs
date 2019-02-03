using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            
            string l = Console.ReadLine();
            string[] arr = l.Split();
            for (int i = 0; i < n; i++)
            {
                double a = int.Parse(arr[i]);
                for(int j = 2; j <= Math.Sqrt(a); j++)
                {
                    if (a % j == 0 && a != j)
                    {
                        a = 0;
                        break;
                    }
                }
                if(a != 0 && a != 1)
                {
                    Console.Write(a + " ");
                }
                
            }
           
            Console.WriteLine();
        }
    }
}
