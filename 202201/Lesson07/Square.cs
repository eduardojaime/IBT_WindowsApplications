using System;

// S - Single Responsibility Principle
// This class takes care of all operations related to a Square shape ONLY
// We don't print, output, send email, or calculate other operations for other shapes, etc...
namespace SolidPrinciples
{
    class Square : IShape, IPrintable
    {
        private decimal _length;

        public Square(decimal length)
        {
            _length = length;
        }

        public decimal CalculateArea()
        {
            return _length * _length;
        }

        public string PrintToString()
        {
            return "Square!";
        }
    }
}