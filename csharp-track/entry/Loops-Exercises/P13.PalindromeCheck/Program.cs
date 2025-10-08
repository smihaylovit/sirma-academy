internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine()!;
        var halfLength = input.Length / 2;
        var isPalindrom = true;

        for (int index = 0; index < halfLength; index++)
        {
            var oppositeIndex = input.Length - 1 - index;

            if (input[index] != input[oppositeIndex])
            {
                isPalindrom = false;
                break;
            }
        }

        Console.WriteLine(isPalindrom);
    }
}