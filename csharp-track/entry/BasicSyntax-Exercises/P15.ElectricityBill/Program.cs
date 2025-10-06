internal class Program
{
    private static void Main(string[] args)
    {
        var numberOfUnits = int.Parse(Console.ReadLine()!);
        var ratePerUnit = double.Parse(Console.ReadLine()!);
        var totalBill = numberOfUnits * ratePerUnit + 10;

        Console.WriteLine($"{totalBill:f2}");
    }
}