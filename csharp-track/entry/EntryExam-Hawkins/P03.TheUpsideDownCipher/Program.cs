internal class Program
{
    private static void Main(string[] args)
    {
        var encryptedMessage = Console.ReadLine()!;
        var shiftPositions = int.Parse(Console.ReadLine()!);
        var decryptedMessage = encryptedMessage
            .Select(c => (char)(c + shiftPositions));

        Console.WriteLine(string.Join("", decryptedMessage));
    }
}