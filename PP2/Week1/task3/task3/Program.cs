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
            string s = Console.ReadLine();//вводим строку 
            int n = int.Parse(s);//превращаем строку в число
            string l = Console.ReadLine();//вводим массив с помощью строки 
            string[] arr = l.Split();//с помощью сплита мы делим строку на отдельные символы
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i] + " "); //выводим числа с помощью двойного цыкла чтобы числа повторялись 
                }
                //Console.WriteLine();
            }
            Console.WriteLine();//новая строка
        }
        
    }
}
