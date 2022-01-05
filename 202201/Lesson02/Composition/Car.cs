namespace Lesson02
{
    public class Car
    {
        public string make;
        public string model;
        public string VIN;
        public int year;

        // Composition is a "has-a" relationship between objects
        // Main object contains other objects that wouldn't do much on their own
        // A car has for wheels, represented by an array of size 4
        public Wheel[4] wheels;
        // A car has only one engine
        public Engine engine;

        public string Start(){
            return "clunk clunk clunk clunk! hiss hiss!";
        }
    }
}