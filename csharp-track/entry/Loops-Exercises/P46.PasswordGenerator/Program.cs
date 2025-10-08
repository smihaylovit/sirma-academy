internal class Program
{
    private static void Main(string[] args)
    {
        int numberN = int.Parse(Console.ReadLine()!);
        int numberL = int.Parse(Console.ReadLine()!);
        var passwords = new List<string>();

        for (int charOne = 1; charOne <= numberN; charOne++)
        {
            for (int charTwo = 1; charTwo <= numberN; charTwo++)
            {
                for (char charThree = 'a'; charThree < 'a' + numberL; charThree++)
                {
                    for (char charFour = 'a'; charFour < 'a' + numberL; charFour++)
                    {
                        var startIndex = Math.Max(charOne, charTwo) + 1;

                        for (int charFive = startIndex; charFive <= numberN; charFive++)
                        {
                            string pass = 
                                charOne.ToString() + charTwo + 
                                charThree + charFour + charFive;
                            
                            passwords.Add(pass);
                        }
                    }
                }
            }
        }

        passwords = passwords
            .OrderBy(x => x)
            .ToList();

        foreach (var pass in passwords)
        {
            Console.WriteLine(pass);
        }
    }
}