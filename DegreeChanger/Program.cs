internal class Program
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }
    public static double FahrenheitToCelsius(double fahrenheit) {
        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;
    } 
    private static void Main(string[] args)
    {
        double fahrenheit;
        double celsius;
        int choice;

        do
        {
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());

            double input = 0;
            Console.WriteLine("Enter your input");
            input = double.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                FahrenheitToCelsius(input);
                break;
                case 2: 
                CelsiusToFahrenheit(input);
                break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        } while (choice != 0);
    }
}