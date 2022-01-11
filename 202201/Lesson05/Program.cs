using System;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cabbie joe = new Cabbie("Joe", "1234");

            Console.WriteLine(joe.Name);

            // accessing the public interface
            var msg = joe.GoToDestination("Airport");
            Console.WriteLine(msg);

            Console.ReadLine();
        }
    }
}
