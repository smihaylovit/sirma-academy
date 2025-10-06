internal class Program
{
    private static void Main(string[] args)
    {
        var weight = double.Parse(Console.ReadLine()!);
        var height = double.Parse(Console.ReadLine()!);
        var bmi = weight / Math.Pow(height, 2);

        Console.WriteLine($"{bmi:f2}");
    }
}