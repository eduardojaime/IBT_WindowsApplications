using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started");

            // I'm using the class to create an object
            // MyPerson is a class/template and exists in code (text)
            // personA is an object and exists in my computer memory
            MyPerson personA = new MyPerson();
            var speak = personA.SayHello();
            Console.WriteLine(speak);

            speak = personA.SayWhatsOnMyMind();
            Console.WriteLine(speak);

            speak = personA.TellAge();
            Console.WriteLine(speak);

            Console.WriteLine(personA.myName);
            // This is why we want encapsulation and data hiding
            personA.myName = "not my name anymore";
            Console.WriteLine(personA.myName);

        }
    }
}
