using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK_ANL
{
    class Student // класс
    {
        public string Name;
        public int Age;
        public decimal Avg;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int SUMMA = 0;

            string Pred = Console.ReadLine();
            String[] words = Pred.Split(new char[] { ' ', ',' });
            String sSearch = Console.ReadLine();

            foreach (var word in words)
            {
                if (sSearch == word.ToLower())
                    SUMMA++;
            }
            Console.WriteLine(SUMMA);
            Console.ReadKey();
        }
    }
}
