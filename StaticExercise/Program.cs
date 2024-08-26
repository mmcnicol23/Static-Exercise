namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var convertedFahrenheit = TempConverter.FahrenheitToCelsius(100);
            Console.WriteLine($"This temperature converted to Celsius is: {convertedFahrenheit}");

            var convertedCelsius = TempConverter.CelsiusToFahrenheit(100);
            Console.WriteLine($"This temperature converted to Fahrenheit is: {convertedCelsius}");
        }
    }
}
