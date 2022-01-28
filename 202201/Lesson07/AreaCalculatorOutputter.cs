using System.Collections.Generic;

namespace SolidPrinciples
{
    // O - Open-Closed principle
    public class AreaCalculatorOutputter
    {

        public void LiskovTest()
        {
            List<IShape> myList = new List<IShape>();
            myList.Add(new Square(1));
            myList.Add(new Circle(1));
            myList.Add(new Square(3));
            myList.Add(new Circle(2)); //4 OBJECTS OF WHICH 2 SQUARES, 2 CIRCLES

            SumAreas(myList);
        }
        // Sum the areas of different shapes contained in a list
        // Violates Open-Closed Principle
        public decimal SumAreasNoBueno(List<IShape> myShapes)
        {
            decimal sum = 0;
            foreach (IShape shape in myShapes)
            {
                if (shape.GetType() == typeof(Circle))
                {
                    // calculate area based on circle formula
                }
                else if (shape.GetType() == typeof(Square))
                {
                    // calculate area based on square formula
                }
                // will need modification if I add more shapes!
            }
            return sum;
        }
        // Follows Open-Closed Principle
        public decimal SumAreas(List<IShape> myShapes)
        {
            decimal sum = 0;
            // L - Liskov Substitution Principle
            // You can replace an instance of a parent class with 
            // an instance of one of it child classes 
            // Parent > Shape has a CalculateArea() method
            // it means all children classes have that method
            // so you can use the parent to refer to the children and pass the children objects 
            // as parameters
            foreach(IShape shape in myShapes)
            {
                sum = sum + shape.CalculateArea();
            }
            return sum;
        }
    }
}