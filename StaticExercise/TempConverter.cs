namespace StaticExercise;

public class TempConverter
{
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return ((fahrenheit - 32) / 1.8); 
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return ((celsius * 1.8) + 32);
    }
}