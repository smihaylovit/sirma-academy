internal class Program
{
    private static void Main(string[] args)
    {
        var lostGamesCount = int.Parse(Console.ReadLine()!);
        var headsetPrice = double.Parse(Console.ReadLine()!);
        var mousePrice = double.Parse(Console.ReadLine()!);
        var keyboardPrice = double.Parse(Console.ReadLine()!);
        var displayPrice = double.Parse(Console.ReadLine()!);
        var trashedHeadsetsCount = lostGamesCount / 2;
        var trashedMiceCount = lostGamesCount / 3;
        var trashedKeyboardsCount = lostGamesCount / 6;
        var trashedDisplaysCount = lostGamesCount / 12;
        var totalRageExpenses =
            trashedHeadsetsCount * headsetPrice +
            trashedMiceCount * mousePrice +
            trashedKeyboardsCount * keyboardPrice +
            trashedDisplaysCount * displayPrice;

        Console.WriteLine($"Rage expenses: {totalRageExpenses:f2} lv.");
    }
}