internal class Program
{
    private static void Main(string[] args)
    {
        int fromNumber = int.Parse(Console.ReadLine()!);
        int toNumber = int.Parse(Console.ReadLine()!);
        int magicNumber = int.Parse(Console.ReadLine()!);
        int currentCombination = 0;
        bool isCombinationFound = false;

        for (int firstNumber = fromNumber; firstNumber <= toNumber; firstNumber++)
        {
            for (int secondNumber = fromNumber; secondNumber <= toNumber; secondNumber++)
            {
                currentCombination++;

                if (magicNumber == firstNumber + secondNumber)
                {
                    isCombinationFound = true;
                    Console.WriteLine($"Combination {currentCombination} - " +
                        $"({firstNumber} + {secondNumber} = {magicNumber})");
                    break;
                }
            }

            if (isCombinationFound)
            {
                break;
            }
        }

        if (!isCombinationFound)
        {
            Console.WriteLine($"{currentCombination} combinations - neither equals {magicNumber}");
        }
    }
}