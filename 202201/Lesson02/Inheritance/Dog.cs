namespace Lesson02
{
    // Inheritance is an "is-a" relationship
    // Dog is a Mammal
    // Dog inherits from Mammal
    // Dog is a derived or child or sub class
    public class Dog : Mammal
    {
        public int barkFrequency;

        public string Bark()
        {
            return "Woof! woof! Bark! Bark!";
        }
    }
}