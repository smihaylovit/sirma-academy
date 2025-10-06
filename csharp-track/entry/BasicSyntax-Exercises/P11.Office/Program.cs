internal class Program
{
    private static void Main(string[] args)
    {
        var firstCabinetPrice = double.Parse(Console.ReadLine()!);
        var secondCabinetPrice = firstCabinetPrice * 0.8;
        var thirdCabinetPrice = (firstCabinetPrice + secondCabinetPrice) * 1.15;
        var totalPrice = firstCabinetPrice + secondCabinetPrice + thirdCabinetPrice;

        Console.WriteLine($"Total price: {totalPrice:f3}");
    }
}