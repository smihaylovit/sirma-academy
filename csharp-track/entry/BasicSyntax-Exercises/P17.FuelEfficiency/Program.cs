internal class Program
{
    private static void Main(string[] args)
    {
        var distance = double.Parse(Console.ReadLine()!);
        var consumedFuel = double.Parse(Console.ReadLine()!);
        var fuelEfficiency = distance / consumedFuel;

        Console.WriteLine($"{fuelEfficiency:f2}");
    }
}