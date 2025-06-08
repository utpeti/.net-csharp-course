namespace ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        int[] temperatures = new int[days];
        string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
        string[] weatherConditions = new string[days];

        Random random = new Random();
        for (int i = 0; i < days; ++i)
        {
            temperatures[i] = random.Next(-10, 40);
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
        }

        for (int i = 0; i < days; ++i)
        {
            Console.WriteLine($"Temperature: {temperatures[i]}, Condition: {weatherConditions[i]}");
        }

        Console.WriteLine($"Average temperature: {CalculateAverage(temperatures)}");
    }

    static double CalculateAverage(int[] temperatures)
    {
        double sum = 0;
        for (int i = 0; i < temperatures.Length; ++i)
        {
            sum += temperatures[i];
        }

        return sum / temperatures.Length;
    }
}

