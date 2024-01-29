using AbstractionInCSharpCompleteExample;

Shape[] shapes = {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 7),
            new Square(5)
        };

foreach(var shape in shapes)
{
    Console.WriteLine($"Area of {shape.GetType().Name}: {shape.CalculateArea()}");
}