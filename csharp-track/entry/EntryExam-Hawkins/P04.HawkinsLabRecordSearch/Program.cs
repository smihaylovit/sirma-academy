internal class Program
{
    private static void Main(string[] args)
    {
        var missingPersonNames = Console.ReadLine()!.Split(", ").ToList();
        var targetName = Console.ReadLine()!;
        var firstOccurrenceIndex = missingPersonNames.IndexOf(targetName);

        if (firstOccurrenceIndex == -1)
        {
            Console.WriteLine("Record not found");
        }
        else
        {
            var lastOccurrenceIndex = missingPersonNames.LastIndexOf(targetName);

            Console.WriteLine($"First Occurrence: {firstOccurrenceIndex}");
            Console.WriteLine($"Last Occurrence: {lastOccurrenceIndex}");
        }
    }
}