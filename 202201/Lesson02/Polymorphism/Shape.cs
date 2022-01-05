namespace Lesson02
{
    // Polymorphism is closely related to inheritance
    public class Shape
    {
        // Polymorphism means many shapes
        // In OOP it means many "messages"
        // Use 'virtual' keyword to indicate methods that need to be defined in the child class
        public virtual string Draw()
        {
            return @"/ __|| || |/   \| _ \| __|
\__ \| __ || - ||  _/| _| 
|___/|_||_||_|_||_|  |___|";
        }
    }
}