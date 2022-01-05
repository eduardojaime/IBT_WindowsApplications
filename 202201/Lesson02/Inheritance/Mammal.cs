namespace Lesson02
{
    // Inheritance allows us to pass attributes and methods down the hierarchy tree
    // Mammal is a base or parent or super class
    public class Mammal
    {
        // private attributes and methods are not inherited down the hierarchy
        private int legCount;
        public int eyeColor;
        public string furColor;

        public string Sleep() 
        {
            return "ZZZzzZZzz";
        }

    }
}