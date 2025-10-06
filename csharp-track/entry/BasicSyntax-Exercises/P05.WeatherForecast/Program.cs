internal class Program
{
    private static void Main(string[] args)
    {
        var city = Console.ReadLine();
        var temperature = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Today in {city} it is {temperature} degrees.");
    }
}