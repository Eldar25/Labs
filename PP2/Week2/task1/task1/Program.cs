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
            string s = System.IO.File.ReadAllText(@"C:\Users\Пользователь\Desktop\Microsoft\Labs\PP2\Week2\task1\pp.txt");
            // string s = Console.ReadLine();
            char[] s1 = s.ToCharArray();
            Array.Reverse(s1);
            char[] s2 = s.ToCharArray();
            bool tr = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    tr = false;
                    Console.WriteLine("NO");
                    break;
                }
            }
            if (tr == true)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
