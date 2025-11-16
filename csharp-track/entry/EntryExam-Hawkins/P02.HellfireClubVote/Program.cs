internal class Program
{
    private static void Main(string[] args)
    {
        var votes = Console.ReadLine()!.Split(", ");
        var yesVotes = votes.Count(v => v == "Yes");
        var noVotes = votes.Count(v => v == "No");
        var abstainVotes = votes.Count(v => v == "Abstain");

        if (abstainVotes == votes.Length)
        {
            Console.WriteLine("Abstain");
        }
        else if (yesVotes > noVotes)
        {
            Console.WriteLine("Yes");
        }
        else if (yesVotes == noVotes)
        {
            Console.WriteLine("Tie");
        }
        else if (yesVotes < noVotes)
        {
            Console.WriteLine("No");
        }
    }
}