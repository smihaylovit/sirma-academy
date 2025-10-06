internal class Program
{
    private static void Main(string[] args)
    {
        var firstCarSpeed = double.Parse(Console.ReadLine()!);
        var secondCarSpeed = double.Parse(Console.ReadLine()!);
        var firstCarDistance = firstCarSpeed * 5;
        var secondCarDistance = secondCarSpeed * 3;
        var distanceBetweenCars = Math.Abs(firstCarDistance - secondCarDistance);

        Console.WriteLine($"{distanceBetweenCars:f2}");
    }
}