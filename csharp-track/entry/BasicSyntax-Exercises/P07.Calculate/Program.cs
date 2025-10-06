internal class Program
{
    private static void Main(string[] args)
    {
        var numOne = int.Parse(Console.ReadLine()!);
        var numTwo = int.Parse(Console.ReadLine()!);

        long sum = numOne + numTwo;
        long difference = Math.Abs(numOne - numTwo);
        long product = numOne * numTwo;
        var average = sum / 2.0;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The difference is: {difference}");
        Console.WriteLine($"The product is: {product}");
        Console.WriteLine($"The average is: {average}");
    }
}