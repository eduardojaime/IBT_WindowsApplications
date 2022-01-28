namespace SolidPrinciples
{
    // Contract of what a shape must implement
    // I - Interface Segregation Principle
    // It's better to have many small interfaces than a few larger ones
    interface IShape
    {
        // Print might not be considered a strict shape behavior...
        // it would violate ISP if we had PrintToX methods here
        // string PrintToString();
        decimal CalculateArea();
    }
}