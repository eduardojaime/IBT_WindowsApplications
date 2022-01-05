using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Dog object instanciated
            Dog fido = new Dog();
            Console.WriteLine("Fido go to bed!");
            Console.WriteLine(fido.Sleep());
        
            // Polymorphism
            Rectangle myRectangle = new Rectangle();
            Circle myCircle = new Circle();
            // Do you agree all shapes can be drawn?
            Console.WriteLine(myRectangle.Draw());
            Console.WriteLine(myCircle.Draw());
        }
    }
}
