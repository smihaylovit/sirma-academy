internal class Program
{
    private static void Main(string[] args)
    {
        uint numberOfOneBgn = uint.Parse(Console.ReadLine()!);
        uint numberOfTwoBgn = uint.Parse(Console.ReadLine()!);
        uint numberOfFiveBgn = uint.Parse(Console.ReadLine()!);
        uint targetAmount = uint.Parse(Console.ReadLine()!);

        for (int oneBgnCount = 0; oneBgnCount <= numberOfOneBgn; oneBgnCount++)
        {
            for (int twoBgnCount = 0; twoBgnCount <= numberOfTwoBgn; twoBgnCount++)
            {
                for (int fiveBgnCount = 0; fiveBgnCount <= numberOfFiveBgn; fiveBgnCount++)
                {
                    var amount = oneBgnCount + twoBgnCount * 2 + fiveBgnCount * 5;
                    
                    if (amount == targetAmount)
                    {
                        Console.WriteLine(
                            $"{oneBgnCount} * 1 lv. + " +
                            $"{twoBgnCount} * 2 lv. + " +
                            $"{fiveBgnCount} * 5 lv. = {amount} lv.");
                    }
                }
            }
        }
    }
}