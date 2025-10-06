internal class Program
{
    private static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var symbol = char.Parse(Console.ReadLine()!);
        var intNumber = int.Parse(Console.ReadLine()!);
        var realNumber = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Symbol: {symbol}");
        Console.WriteLine($"Integer number: {intNumber}");
        Console.WriteLine($"Real number: {realNumber}");
        Console.WriteLine();
        
        Console.Write($"{text} / ");
        Console.Write($"{symbol} / ");
        Console.Write($"{intNumber} / ");
        Console.Write($"{realNumber}");
        Console.WriteLine();
    }
}