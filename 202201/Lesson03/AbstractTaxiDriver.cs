namespace lesson03
{
    public class AbstractTaxiDriver
    {
        // Interface = method definition, visible to the user
        public string DriveToAirport()
        {
            // Implementation = Code inside the method, not visible to the user
            // complex GPS calculations and routing and navigation
            GetGPSLocation();
            return "We have arrived! That'll be $40.";
        }
        private void GetGPSLocation()
        {
            // these are not available to the user but can be used in other methods of my class
        }
    }
}