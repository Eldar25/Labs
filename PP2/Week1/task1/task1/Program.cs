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
            string s = Console.ReadLine();//вводим строку
            int n = int.Parse(s);//строку превращаем в число
            string l = Console.ReadLine();//вводим массив
            string[] arr = l.Split();//строку превращаем в отдельные элементы
            for (int i = 0; i < n; i++)
            {
                double a = int.Parse(arr[i]);// элементы массива превращаем в тип дабл чтобы math.sqrt неругался
                for (int j = 2; j <= Math.Sqrt(a); j++)//
                {

                    if (a % j == 0 && a != j)
                    {
                        a = 0;
                        break;
                    }
                }
                if (a != 0 && a != 1)
                {
                    Console.Write(a + " ");
                }

            }
           
            Console.WriteLine();
        }
    }
}
