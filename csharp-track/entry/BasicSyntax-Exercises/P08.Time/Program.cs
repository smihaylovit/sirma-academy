internal class Program
{
    private static void Main(string[] args)
    {
        var minutes = int.Parse(Console.ReadLine()!);
        var hours = minutes / 60;
        minutes %= 60;

        Console.WriteLine($"{hours}:{minutes}");
    }
}