namespace Lesson02
{
    public class Circle : Shape
    {
        // Polymorphism means:
        // Shape forces all classes that inherit from it to have Draw method
        // Each class should override this method accordingly
        // Use 'override' keyword to indicate that the method below overrides the virtual method from the base class
        public override string Draw()
        {
            return @"        . -- ~~~ -- .
    .-~               ~-.
   /                     \
  /                       \
 |                         |
 |                         |
 |                         |
  \                       /
   \                     /
    `-.               .-'
        ~- . ___ . -~";
        }
    }
}