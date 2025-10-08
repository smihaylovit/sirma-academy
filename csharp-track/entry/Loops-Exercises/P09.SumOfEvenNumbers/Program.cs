internal class Program
{
    private static void Main(string[] args)
    {
        int evenNumbersCount = int.Parse(Console.ReadLine()!);
        int sumOfEvenNumbers = 0;
        int currentEvenNumber = 2;
        int counter = 0;

        while (counter < evenNumbersCount)
        {
            sumOfEvenNumbers += currentEvenNumber;
            currentEvenNumber += 2;
            counter++;
        }

        Console.WriteLine(sumOfEvenNumbers);
    }
}