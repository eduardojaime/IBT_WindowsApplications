using System;

// S - Single Responsibility Principle
// This class takes care of all operations related to a Circle shape ONLY
// We don't print, output, send email, or calculate other operations for other shapes, etc...
namespace SolidPrinciples
{
    class Circle : IShape, IPrintable
    {
        private decimal _radius;

        public Circle(decimal radius)
        {
            this._radius = radius;
        }

        public decimal CalculateArea()
        {
            return (Math.PI * (_radius * _radius)); // pi * r2
        }

        public string PrintToString()
        {
            return "Circle!";
        }
    }
}