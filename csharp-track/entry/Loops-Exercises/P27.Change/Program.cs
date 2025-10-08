internal class Program
{
    private static void Main(string[] args)
    {
        var changeAmount = (int)(double.Parse(Console.ReadLine()!) * 100);
        var coinAmounts = new List<int> { 200, 100, 50, 20, 10, 5, 2, 1};
        var coinsCount = 0;

        for (int i = 0; i < coinAmounts.Count; i++)
        {
            coinsCount += changeAmount / coinAmounts[i];
            changeAmount %= coinAmounts[i];
        }

        Console.WriteLine(coinsCount);
    }
}