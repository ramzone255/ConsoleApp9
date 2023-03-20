using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fish = {"Карп", "Щука",
            "Карась", "Лещ", "Окунь", "Судак"};
            string[] fish1 = {"Карп", "Щука",
            "Окунь"};
            string[] fish2 = { "Окунь",
            "Карп", "Карась"};
            string[] fish3 = {"Карп", "Щука",
             "Лещ"};
            var rez1 = fish.Intersect(fish1).Intersect(fish2).Intersect(fish3);
            Console.WriteLine("Видов рыб у каждого рыбака");
            PrintSet(rez1);
            var rez3 = fish.Except(fish1).Except(fish2).Except(fish3);
            Console.WriteLine("Видов рыб нет ни у одного");
            PrintSet(rez3);
            Console.ReadKey();
        }
        private static void PrintSet(IEnumerable<string> rez1)
        {
            foreach (var fl in rez1)
            {
                Console.WriteLine(fl);
            }
        }

        private static void printSet(IEnumerable<int> mas)
        {
            foreach (int x in mas)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        private static void printArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
            Console.WriteLine();

        }

    }
}