using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string s = System.IO.File.ReadAllText(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task2\pp.txt");
            string[] arr = s.Split();
            for(int i = 0; i < arr.Length; i++)
            {
                double a = double.Parse(arr[i]);
                for(int j = 2; j <= Math.Sqrt(a); j++)
                {
                    if(a%j == 0 && a != j)
                    {
                        a = 0;
                        break;
                    }
                }
                if (a != 0 && a != 1)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task2\sol.txt", true))
                    {
                        // System.IO.File.WriteAllLines(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task2\sol",b);
                        file.WriteLine(a);
                    }
                }

            }
        }
    }
}
