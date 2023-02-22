using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNameSorting
{
    class NumberChecker
    {
        public delegate void NumberCheckerDelegate(string[] lastNames, int number);
        public event NumberCheckerDelegate NumberCheckerEvent;

        public void Read(string[] names)
        {
            Console.WriteLine("Массив фамилий будет отсортирован, введите значение : 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number != 1 && number != 2) throw new FormatException();
            NumberEntered(names, number);
        }

        public void NumberEntered(string[] lastNames, int number)
        {
            NumberCheckerEvent?.Invoke(lastNames, number);
        }
    }
}
