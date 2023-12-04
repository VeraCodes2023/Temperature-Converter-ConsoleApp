using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter App");
        bool exit = false;

        while (!exit)
        {
            Console.Write("Please enter a temperature value and its unit of measurement (F or C):\n");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Input cannot be null.");
                continue;
            }
            else 
            {
                input = input.Trim();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    exit = true;
                    Console.WriteLine("Program terminated.");
                    break;
                }

                if (TryParseTemperatureInput(input, out double temperature, out char unit))
                {
                    double convertedTemperature = TempConvert(temperature, unit);
                    Console.WriteLine($"{temperature} {unit} = {Math.Round(convertedTemperature,2)} {(unit == 'C' ? 'F' : 'C')}");
                }
                else {
                    Console.WriteLine("Invalid input. Please enter a valid temperature value and its unit of measurement (F or C):");
                }
            }
        }
    }

    static bool TryParseTemperatureInput(string input, out double temperature, out char unit)
    {
        temperature = 0;
        unit = ' ';

        string[] parts = input.Split(' ');
        if (parts.Length != 2)
        {
            return false;
        }

        if (!double.TryParse(parts[0], out temperature))
        {
            return false;
        }

        if (parts[1].Length != 1)
        {
            return false;
        }

        unit = char.ToUpper(parts[1][0]);
        return unit == 'F' || unit == 'C';
    }

    static double TempConvert(double temperature, char unit)
    {
        switch (unit)
        {
            case 'F':
                return (temperature - 32) * 5 / 9;
            case 'C':
                return (temperature * 9 / 5) + 32;
            default:
                return 0;
        }
    }
}
