namespace Lesson02
{
    // Inheritance is an "is-a" relationship
    // Cat is a Mammal
    // Cat inherits from Mammal
    // Cat is a derived or child or sub class
    public class Cat : Mammal
    {
        public int meowFrequency;

        public string Meow()
        {
            return "Meow! meow! prrr!";
        }
    }
}