using Shape;
internal class Program
{
    private static void Main(string[] args)
    {
        Shape.Shape shape = new Shape.Shape("blue", true);
        Console.WriteLine(shape.ToString());
        Console.WriteLine();
        ResizeableShape circle = new Circle(1, "yellow", false);
        Console.WriteLine("Before : ");
        Console.WriteLine(circle.ToString());
        Console.WriteLine("Affter : ");
        circle.Resize(120);
        Console.WriteLine(circle.ToString());
        Console.WriteLine();
        ResizeableShape rectagle = new Rectangle(2, 2, "red", true);
        Console.WriteLine("Before : ");
        Console.WriteLine(rectagle.ToString());
        Console.WriteLine("Affter : ");
        rectagle.Resize(110);
        Console.WriteLine(rectagle.ToString());
        Console.WriteLine();
        ResizeableShape square = new Square(3, "black", true);
        Console.WriteLine("Before : ");
        Console.WriteLine(square.ToString());
        Console.WriteLine("Affter : ");
        square.Resize(150);
        Console.WriteLine(square.ToString());
    }
}

