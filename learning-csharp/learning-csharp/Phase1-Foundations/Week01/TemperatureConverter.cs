namespace learning_csharp.Phase1_Foundations.Week01
{
    internal static class TemperatureConverter
    {
        public static void Main()
        {

            // Show menu
            Console.WriteLine("Week 1 - Day 5 - Temperature Converter");
            Console.WriteLine("======================================");

            Console.WriteLine("Choose a conversion:");
            Console.WriteLine("  1. Celsius    -> Fahrenheit");
            Console.WriteLine("  2. Fahrenheit -> Celsius");
            Console.Write("\nChoice (1 or 2): ");

            // Read user's choice
            string? conversion = Console.ReadLine();

            // Use TryParse to validate user's input (conversion choice)
            if (!int.TryParse(conversion, out int parsedResult) || (parsedResult < 1 || parsedResult > 2))
            {
                Console.WriteLine($"\n\"{conversion}\" is not a valid choice.");
                return;
            }

            // Read user's input
            Console.Write("\nEnter the temperature value: ");
            string? valueInput = Console.ReadLine();

            // Use TryParse to validate user's inpute (temperature)
            if (!double.TryParse(valueInput, out double temperature))
            {
                Console.WriteLine($"\n\"{valueInput}\" is not a valid number.");
                return;
            }

            // Show result
            Console.WriteLine("\n----- Result -----");

            if (parsedResult == 1)
            {
                // Convert celsius to fahrenheit
                double fahrenheit = (temperature * 9.0 / 5.0) + 32;
                Console.WriteLine($"{temperature}°C = {fahrenheit}°F");
            }
            else
            {
                // Convert fahrenheit to celsius
                double celsius = (temperature - 32) * 5.0 / 9.0;
                Console.WriteLine($"{temperature}°F = {celsius}°C");
            }

        }
    }
}
