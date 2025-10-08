internal class Program
{
    private static void Main(string[] args)
    {
        int stepsCount = int.Parse(Console.ReadLine()!);
        int intervalsCount = 0;

        for (int row = 1; row <= stepsCount; row++)
        {
            string line = 
                new string(' ', intervalsCount) + 
                new string('#', row);
            
            Console.WriteLine(line);
            intervalsCount += row - 1;
        }
    }
}