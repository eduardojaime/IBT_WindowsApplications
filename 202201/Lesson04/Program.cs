using System;

namespace Lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // instantiate the class > assigns some memory to this object
            // object is created and all its properties assume default values
            // string (and any reference datatype) default value is NULL
            // numeric types default value is 0
            TaxiDriver myDriver = new TaxiDriver(); // <<< this line of code calls the constructor method
            // modify attributes that are public after creation
            myDriver.FirstName = "John";
            // should a Taxi Driver be able to change their name after creation?
            myDriver.FirstName = "Matthew";
            // ideally... NO

            var greetings = myDriver.SayHello();
            Console.WriteLine(greetings);
            
            var areaCode = myDriver.PrintAreaCode();
            Console.WriteLine(areaCode);

            // using the second constructor
            TaxiDriver myNamedDriver = new TaxiDriver("John", "Smith");
            var greetings2 = myNamedDriver.SayHello();
            Console.WriteLine(greetings2);

            var areaCode2 = myNamedDriver.PrintAreaCode();
            Console.WriteLine(areaCode2);

            // Error handling
            // wishful programming > writing code hoping it will never fail
            try 
            {
                // think about operations that might break
                // accessing a database > db might be offline
                // accessing a file > file might not exist
                // mathematical operations > users might enter invalid input
                // most always
                // some code that might fail
                int zero = 0;
                int a = 10/zero;
                Console.WriteLine("This will NOT be executed");
            }
            catch(Exception ex)
            {
                // error handling
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("This will be executed");
        }
    }
}
