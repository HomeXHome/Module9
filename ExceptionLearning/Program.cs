using System;
using System.IO;

//Признаюсь, не совсем понял задание, надеюсь, то, что я написал, хоть немного походит на решение.
//Я, сначала, попытался создать класс с конструктором, который принимает разнообразные переменные и попытался подставить его в foreach,
//со специально неверными данными, чтобы они вызвали ошибки, но, кажется, это совсем не то, да я и запутался в конце концов.
namespace ExceptionLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            ArgumentNullException argNullEx = new ArgumentNullException();
            FileNotFoundException fileNotFoundException= new FileNotFoundException();
            DivideByZeroException divideByZeroException= new DivideByZeroException();
            ArgumentOutOfRangeException argumentOutOfRangeException = new ArgumentOutOfRangeException();
            PersonalException personalException = new PersonalException("This can not be personal!");

            Exception[] exceptions = { argNullEx, fileNotFoundException, divideByZeroException, argumentOutOfRangeException, personalException };

            foreach (Exception exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }

    class PersonalException : Exception
    {
        public PersonalException(string message) : base(message) { }
    }
}
