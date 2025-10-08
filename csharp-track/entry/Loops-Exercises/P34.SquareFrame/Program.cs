internal class Program
{
    private static void Main(string[] args)
    {
        int frameSize = int.Parse(Console.ReadLine()!);

        if (frameSize >= 3)
        {
            int dashesCount = frameSize - 2;
            string dashes = string.Empty;

            for (int i = 1; i <= dashesCount; i++)
            {
                dashes += "- ";
            }

            string topAndBottomLine = "+ " + dashes + "+";
            Console.WriteLine(topAndBottomLine);

            for (int row = 2; row < frameSize; row++)
            {
                string middleLine = "| " + dashes + "|";
                Console.WriteLine(middleLine);
            }

            Console.WriteLine(topAndBottomLine);
        }
    }
}