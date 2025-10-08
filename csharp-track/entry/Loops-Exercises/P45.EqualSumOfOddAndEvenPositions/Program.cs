internal class Program
{
    private static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine()!);
        int secondNumber = int.Parse(Console.ReadLine()!);
        var foundNumbers = new List<int>();

        for (int i = firstNumber + 1; i < secondNumber; i++)
        {
            string currentNumber = i.ToString();
            int sumOfDigitsOnEvenPositions = 0;
            int sumOfDigitsOnOddPositions = 0;

            for (int position = 0; position < currentNumber.Length; position++)
            {
                int digit = int.Parse(currentNumber[position].ToString());

                if (position % 2 == 0)
                {
                    sumOfDigitsOnEvenPositions += digit;
                }
                else
                {
                    sumOfDigitsOnOddPositions += digit;
                }
            }

            if (sumOfDigitsOnEvenPositions == sumOfDigitsOnOddPositions)
            {
                foundNumbers.Add(i);
            }
        }

        foreach (var number in foundNumbers)
        {
            Console.WriteLine(number);
        }

        if (foundNumbers.Count == 0)
        {
            Console.WriteLine("None");
        }
    }
}