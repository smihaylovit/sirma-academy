internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);

        while (number != 0)
        {
            int currentDigit = number % 10;

            if (currentDigit == 0)
            {
                Console.WriteLine("ZERO");
            }
            else
            {
                char currentSymbol = (char)(currentDigit + 33);
                string currentLine = new string(currentSymbol, currentDigit);
                Console.WriteLine(currentLine);
            }

            number /= 10;
        }
    }
}