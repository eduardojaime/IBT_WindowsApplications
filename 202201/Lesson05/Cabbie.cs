using System;

/* 
<< Comment starts

add as many
lines of comments
as you wish

comment ends >>  
*/

namespace Lesson05
{
    // Taxi Driver == Cabie
    // Names will be nouns: Dog, Cat, Cabbie, Driver, Student, etc.
    public class Cabbie
    {
        // private attributes (encapsulation)
        private string _Name; // Best practice > use underscore to indicate that a field is private
        // Composition > a driver has a cab
        private string SIN; // Social Insurance Number > Canada, SSN > US
        private Cab _Cab;

        // Constructors
        public Cabbie()
        {
            _Name = null;
            _Cab = null;
        }

        public Cabbie(string name, string serialNumber)
        {
            _Name = name;
            _Cab = new Cab(serialNumber);
        }

        // Accessor Methods also called Getters/Setters
        // This is the implementation of encapsulation
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        // public interface > methods that can be accessed from outside the class
        public string GoToDestination(string destination)
        {
            try
            {
                // be ready for trouble
                int number = 0;
                bool isNumber = int.TryParse(destination, out number);
                if (String.IsNullOrEmpty(destination) || isNumber)
                    return "Sorry, could you repeat that?";

                Console.WriteLine("Starting the trip");

                // some processing
                // might include calling private implementation methods
                TurnRight();
                GoStraigth();
                GoStraigth();
                GoStraigth();
                TurnRight();
                GoStraigth();
                GoStraigth();
                GoStraigth();
                GoStraigth();
                TurnLeft();

                Console.WriteLine("Ending the trip");

                return "We have arrived!";
            }
            catch (Exception ex)
            {
                return "Sorry! can't go there! " + ex.Message;
            }
        }

        // abstract out (away) non-portable code
        public string HandleCash(decimal amount)
        {
            // code that writes to the db moved to its own class
            var helper = new MongoDbHelper();
            helper.SendToDatabase(amount);


            return "Thank you!";
        }

        public string HandleCreditCard(string amount)
        {
            return "Thank you!";
        }

        // private implementation methods
        // also called helper methods
        private void TurnRight()
        {
            Console.WriteLine("Turning Right");
        }
        private void TurnLeft()
        {
            Console.WriteLine("Turning Left");
        }
        private void GoStraigth()
        {
            Console.WriteLine("Going Straight");
        }


    }
}