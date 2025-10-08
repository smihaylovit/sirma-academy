internal class Program
{
    private static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine()!);
        var collatzSequence = new List<uint>();

        while (number >= 1)
        {
            collatzSequence.Add(number);

            if (number == 1)
            {
                break;
            }

            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                if (number >= uint.MaxValue / 3)
                {
                    throw new OverflowException(
                        "Type Overflow! Cannot print Collatz Seqence! Number is too big!");
                }

                number *= 3;
                number++;
            }
        }

        Console.WriteLine(string.Join(' ', collatzSequence));
    }
}