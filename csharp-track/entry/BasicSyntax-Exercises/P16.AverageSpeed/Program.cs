internal class Program
{
    private static void Main(string[] args)
    {
        var distance = double.Parse(Console.ReadLine()!);
        var time = double.Parse(Console.ReadLine()!);
        var avgSpeed = distance / time;

        Console.WriteLine($"{avgSpeed:f2}");
    }
}