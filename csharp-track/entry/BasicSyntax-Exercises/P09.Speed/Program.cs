internal class Program
{
    private static void Main(string[] args)
    {
        var distance = int.Parse(Console.ReadLine()!);
        var hours = int.Parse(Console.ReadLine()!);
        var minutes = int.Parse(Console.ReadLine()!);
        var seconds = int.Parse(Console.ReadLine()!);

        var time = hours * 3600.0 + minutes * 60 + seconds;
        var speed = distance / time;

        Console.WriteLine($"{speed:f6}");
    }
}