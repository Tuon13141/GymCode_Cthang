internal class Program
{
    public class Rectangle {
        double width, height;

        public Rectangle() {
        }

        public Rectangle(double width, double height) {
            this.width = width;
            this.height = height;
        }
        //code below here
        public double GetArea() {
            return this.width * this.height;
        }

        public double GetPerimeter() {
            return (this.width + this.height) * 2;
        }

        public string Display() {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the width:");
        double width = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Double.Parse(Console.ReadLine());
    }
}