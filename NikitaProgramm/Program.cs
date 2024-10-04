using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikitaProgramm
{
    class Student // класс
    {
        public string Name;
        public int Age;
        public decimal Avg;
    }

    class Program
    {
        /* Метод
        public static void Student(string name = "None", int age = 0, double srball = 0)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Average score: {srball}");
        }
        */

        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = Console.ReadLine();
            student1.Age = Convert.ToInt32(Console.ReadLine());
            student1.Avg = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Имя: {student1.Name}");
            Console.WriteLine($"Возраст: {student1.Age}");
            Console.WriteLine($"Средний балл: {student1.Avg}");
            Console.ReadKey();
        }
    }
}
