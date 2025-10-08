internal class Program
{
    private static void Main(string[] args)
    {
        int firstDigitUpperLimit = int.Parse(Console.ReadLine()!);
        int secondDigitUpperLimit = int.Parse(Console.ReadLine()!);
        int thirdDigitUpperLimit = int.Parse(Console.ReadLine()!);

        for (int firstDigit = 1; firstDigit <= firstDigitUpperLimit; firstDigit++)
        {
            if (firstDigit % 2 == 0)
            {
                for (int secondDigit = 1; secondDigit <= secondDigitUpperLimit; secondDigit++)
                {
                    if (IsPrime(secondDigit))
                    {
                        for (int thirdDigit = 1; thirdDigit <= thirdDigitUpperLimit; thirdDigit++)
                        {
                            if (thirdDigit % 2 == 0)
                            {
                                Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}");
                            }
                        }
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