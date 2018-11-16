using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string text = "hello world!";
            var formatter = new Formatter();
            var result = formatter.Format(text);
            if (result != "Hello world!")
            {
                Console.WriteLine("Wrong!");
            }

            var secondResult = formatter.Format(text);
            if (secondResult != "Hello World!")
            {
                Console.WriteLine("Wrong!");
            }
        }
    }
}
