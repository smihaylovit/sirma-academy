
internal class Program
{
    private static readonly Dictionary<char, char> SymbolPairs = new()
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };

    private static void Main(string[] args)
    {
        var sequence = Console.ReadLine()!;

        if (IsBalanced(sequence))
        {
            Console.WriteLine("Safe");
        }
        else
        {
            Console.WriteLine("Cursed");
        }
    }

    private static bool IsBalanced(string sequence)
    {
        var firstCloseIndex = sequence
            .IndexOfAny(SymbolPairs.Keys.ToArray());

        if (firstCloseIndex > 0 && 
            sequence[firstCloseIndex - 1] == SymbolPairs[sequence[firstCloseIndex]])
        {
            sequence = sequence.Remove(firstCloseIndex - 1, 2);
            return IsBalanced(sequence);
        }
        else if (firstCloseIndex == -1)
        {
            return sequence.Length == 0;
        }
        else
        {
            return false;
        }
    }
}