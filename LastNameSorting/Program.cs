using System;
using System.Linq;

namespace LastNameSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberChecker numberChecker = new NumberChecker();
            numberChecker.NumberCheckerEvent += Sorting;

            string[] lastNames = { "Васильев", "Апполонов", "Кузнецов" };

            try
            {
                numberChecker.Read(lastNames);
            }
            catch(FormatException)
            {
                Console.WriteLine("Введено неверное значение");
            }
            Console.ReadLine();
        }

        static void Sorting(string[] lastNames, int value)
        {
            switch (value)
            {
                case 1:
                    foreach (string str in SortLastNamesAscending(lastNames))
                        Console.WriteLine(str);
                    break;
                case 2:
                    foreach (string str in SortLastNamesDescending(lastNames))
                        Console.WriteLine(str);
                    break;
            }
        }

        static string[] SortLastNamesAscending(string[] lastNames)
        {
            return lastNames.OrderBy(s => s).ToArray();
        }

        static string[] SortLastNamesDescending(string[] lastNames)
        {
            return lastNames.OrderByDescending(s => s).ToArray();
        }
    }
}
