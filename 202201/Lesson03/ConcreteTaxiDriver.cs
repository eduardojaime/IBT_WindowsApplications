namespace lesson03
{
    public class ConcreteTaxiDriver
    {
        // Interface = method definition, visible to the user
        public string GoStraight()
        {
            // Implementation = Code inside the method, not visible to the user
            // makes the driver go straight
            return "Ok, and then?";
        }
        public string TurnLeft()
        {
            // makes the driver turn left
            return "Hmmm, and now?";
        }
        public string TurnRight()
        {
            return "And now?";
        }
    }
}