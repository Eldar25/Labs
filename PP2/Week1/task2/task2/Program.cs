using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        public Student(string name1, string Id, int y1)
        {
            this.name = name1;
            this.id = Id;
            this.year = y1;
        }
        public void GetInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
        }
        public void Plus()
        {
            year++;
            Console.WriteLine("Year: " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Eldar", "18BD");
            Console.WriteLine("Please, write your name: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Please, write your id: ");
            string id1 = Console.ReadLine();
            Console.WriteLine("Please, write your year of study: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Student s1 = new Student(n1, id1,y1);
            s1.GetInfo();
            s1.Plus();
            

        }
    }
}
