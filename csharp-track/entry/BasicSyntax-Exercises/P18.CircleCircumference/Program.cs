internal class Program
{
    private static void Main(string[] args)
    {
        var radius = double.Parse(Console.ReadLine()!);
        var circumference = 2 * Math.PI * radius;

        Console.WriteLine($"{circumference:f2}");
    }
}