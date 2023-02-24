namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double FTEMP = 98.6;
            Console.WriteLine($"Fahrenheit: {FTEMP} = Celsius: {TempConverter.FahrenheitToCelsius(FTEMP)}");
            double CTEMP = 25;
            Console.WriteLine($"Celsius: {CTEMP} = Fahrenheit: {TempConverter.CelsiusToFahrenheit(CTEMP)}");
        }
    }
}
