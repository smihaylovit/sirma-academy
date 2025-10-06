internal class Program
{
    private static void Main(string[] args)
    {
        var kilometers = double.Parse(Console.ReadLine()!);
        var miles = kilometers * 0.621371192;

        Console.WriteLine(miles);
    }
}