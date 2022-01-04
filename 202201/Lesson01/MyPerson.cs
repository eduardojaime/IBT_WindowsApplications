namespace program
{
    public class MyPerson
    {
        // Encapsulation
        private int myAge = 25;
        public string myName = "John";

        // some other attributes?
        public string gender = "Male";
        public string emailAddress = "john@mymail.com";

        // how do we know which attributes to add to our object? and when do we stop?
        // >> Depends on the application
        // think about a police investigation app vs student registration app
        
        // How do classes communicate??
        // data or behavior?
        // Behavior is also called Interface or Methods
        public string SayHello()
        {
            return "Hello!";
        }
        public string TellAge()
        {
            return $"I am {myAge} years old";
        }

        public string SayWhatsOnMyMind()
        {
            var mythought = ThinkAnIdea();
            return mythought;
        }

        private string ThinkAnIdea()
        {
            return "I'm sleepy!";
        }
    }
}