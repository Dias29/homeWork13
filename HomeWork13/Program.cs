using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10);

            Random rnd = new Random();
            int digit = 0;

            Console.WriteLine("Дан массив: ");
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(rnd.Next(-10, 10));
                Console.Write(list[i] + "\t");
                if (i % 2 == 0)
                    digit += list[i];
            }
            Console.WriteLine("\nСумма чисел на четных позициях: " + digit);

            int first = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[first])
                {
                    first = i;
                }
            }

            int second = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (i != first && list[i] != list[first] && list[i] > list[second])
                {
                    second = i;
                }
            }
            Console.WriteLine("\n\nВторое максимальное значение: [" + second + "] : " + list[second]);

            Console.ReadLine();
        }
    }
}
