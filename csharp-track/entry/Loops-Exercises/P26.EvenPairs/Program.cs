internal class Program
{
    private static void Main(string[] args)
    {
        int firstPairStart = int.Parse(Console.ReadLine()!);
        int secondPairStart = int.Parse(Console.ReadLine()!);
        int firstPairDiff = int.Parse(Console.ReadLine()!);
        int secondPairDiff = int.Parse(Console.ReadLine()!);
        int firstPairEnd = firstPairStart + firstPairDiff;
        int secondPairEnd = secondPairStart + secondPairDiff;

        for (int firstPair = firstPairStart; firstPair <= firstPairEnd; firstPair++)
        {
            if (IsPrime(firstPair))
            {
                for (int secondPair = secondPairStart; secondPair <= secondPairEnd; secondPair++)
                {
                    if (IsPrime(secondPair))
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                    }
                }
            }
        }
    }

    private static bool IsPrime(int number)
    {
        if (number == 2 || (number > 2 && number % 2 == 1))
        {
            int divisorLimit = number / 2;
            int divisor = 3;

            while (divisor < divisorLimit)
            {
                if (number % divisor == 0)
                {
                    return false;
                }

                divisor += 2;
            }

            return true;
        }

        return false;
    }
}