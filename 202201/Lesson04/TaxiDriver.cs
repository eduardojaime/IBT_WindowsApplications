namespace Lesson04
{
    // Class definition
    public class TaxiDriver
    {
        // class attributes > static fields that are shared accross instances of the class
        public static int CompanyCode; // all taxidrivers belong to same company
        
        // public properties/attributes/fields
        // object attributes are public/private attributes that can be used anywhere in the class
        public string FirstName { get; set; } // same as public string FirstName;
        public string LastName { get; set; }
        public string AreaCode { get; set; }
        // this one should exist but not accessible from outside
        private string SIN { get; set; }

        // Constructors allow you to create a class in a particular state
        // State = values that are assigned to its attributes
        // Default constructor > no parameters, generic
        public TaxiDriver()
        {
            // Initialize attributes
            // default constructor
            AreaCode = "647"; // defaults to Toronto unless you modify it later
        }

        // method overloading >> works with any kind of method
        // 'chain' this overloaded constructor to the default one by using ': this()'
        // signature is (taxiDriver string string) 
        public TaxiDriver(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            // option 1 repeat code > AreaCode = "647"; // not a good idea
        }

        // public methods/interface
        public string SayHello()
        {
            // Local scope
            string message = "Welcome to my Taxi!";
            return $"{message} My name is {FirstName} and I'll be your driver today!";
        }

        public string PrintAreaCode()
        {
            return $"I work at {AreaCode}";
        }
    }
}