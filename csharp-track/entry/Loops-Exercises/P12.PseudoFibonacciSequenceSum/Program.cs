internal class Program
{
    private static void Main(string[] args)
    {
        int fibonacciNumbersCount = int.Parse(Console.ReadLine()!);
        int sumOfFibonacciNumbers = 0;
        int currentFibonacciNumber = 1;
        int nextFibonacciNumber = 1;
        int counter = 0;

        while (counter < fibonacciNumbersCount)
        {
            sumOfFibonacciNumbers += currentFibonacciNumber;
            int temp = currentFibonacciNumber;
            currentFibonacciNumber = nextFibonacciNumber;
            nextFibonacciNumber += temp;
            counter++;
        }

        Console.WriteLine(sumOfFibonacciNumbers);
    }
}