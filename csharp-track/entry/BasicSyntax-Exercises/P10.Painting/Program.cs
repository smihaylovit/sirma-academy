internal class Program
{
    private static void Main(string[] args)
    {
        var totalPaintWeight = double.Parse(Console.ReadLine()!);
        var numberOfRooms = 3;
        var totalPaintWeightPerRoom = totalPaintWeight / numberOfRooms;

        var redPaintWeightPerRoom = totalPaintWeightPerRoom / 13;
        var yellowPaintWeightPerRoom = redPaintWeightPerRoom * 4;
        var whitePaintWeightPerRoom = yellowPaintWeightPerRoom * 2;

        Console.WriteLine($"Red: {redPaintWeightPerRoom:f4}");
        Console.WriteLine($"Yellow: {yellowPaintWeightPerRoom:f4}");
        Console.WriteLine($"White: {whitePaintWeightPerRoom:f4}");
    }
}