internal class Program
{
    private static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine()!);
        string numberAsString = number.ToString();
        int digitsCount = numberAsString.Length;
        double sumOfDigitPowers = 0;
        bool isArmstrongNumber = false;

        for (int index = 0; index < digitsCount; index++)
        {
            int currentDigit = int.Parse(numberAsString.Substring(index, 1));
            sumOfDigitPowers += Math.Pow(currentDigit, digitsCount);
        }

        if (number == sumOfDigitPowers)
        {
            isArmstrongNumber = true;
        }

        Console.WriteLine(isArmstrongNumber);
    }
}