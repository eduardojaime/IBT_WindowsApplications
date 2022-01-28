namespace SolidPrinciples
{
    // I - Interface Segregation Principle
    // We have several interfaces: one for printing to String, one for calculating areas, etc..
    interface IPrintable
    {
        // follows ISP
        string PrintToString();
    }
}