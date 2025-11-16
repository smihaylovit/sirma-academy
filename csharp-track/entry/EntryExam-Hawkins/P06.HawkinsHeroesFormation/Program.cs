internal class Program
{
    private static void Main(string[] args)
    {
        var heroIds = Console.ReadLine()!.Split(", ").Select(int.Parse).ToList();
        var heroFormation = new HeroFormation(heroIds);
        string command;

        while ((command = Console.ReadLine()!) != "end")
        {
            var commandParts = command.Split(" ");

            switch (commandParts[0])
            {
                case "remove":
                    if (heroFormation.Remove(int.Parse(commandParts[1])))
                    {
                        Console.WriteLine(heroFormation);
                    }
                    break;
                case "add":
                    if (heroFormation.Add(int.Parse(commandParts[1])))
                    {
                        Console.WriteLine(heroFormation);
                    }
                    break;
                case "swap":
                    if (heroFormation.Swap(int.Parse(commandParts[1]), int.Parse(commandParts[2])))
                    {
                        Console.WriteLine(heroFormation);
                    }
                    break;
                case "insert":
                    if (heroFormation.Insert(int.Parse(commandParts[1]), int.Parse(commandParts[2])))
                    {
                        Console.WriteLine(heroFormation);
                    }
                    break;
                case "center":
                    var centerHeroes = heroFormation.Center();
                    if (centerHeroes.Count > 0)
                    {
                        Console.WriteLine(string.Join(" ", centerHeroes));
                    }
                    break;
            }
        }
    }
}

internal class HeroFormation
{
    private List<int> Heroes { get; set; }

    public HeroFormation(List<int> heroIds)
    {
        Heroes = new List<int>(heroIds);
    }

    public bool Add(int heroId)
    {
        if (!Heroes.Contains(heroId))
        {
            Heroes.Add(heroId);
            return true;
        }

        return false;
    }

    public bool Remove(int index)
    {
        if (index >= 0 && index < Heroes.Count)
        {
            Heroes.RemoveAt(index);
            return true;
        }

        return false;
    }

    public bool Swap(int firstIndex, int secondIndex)
    {
        if (firstIndex >= 0 && firstIndex < Heroes.Count &&
            secondIndex >= 0 && secondIndex < Heroes.Count &&
            firstIndex != secondIndex)
        {
            var temp = Heroes[firstIndex];
            Heroes[firstIndex] = Heroes[secondIndex];
            Heroes[secondIndex] = temp;
            return true;
        }

        return false;
    }

    public bool Insert(int heroId, int index)
    {
        if (index >= 0 && index <= Heroes.Count &&
            !Heroes.Contains(heroId))
        {
            Heroes.Insert(index, heroId);
            return true;
        }

        return false;
    }

    public List<int> Center()
    {
        var centerHeroes = new List<int>();

        if (Heroes.Count > 0)
        {
            if (Heroes.Count % 2 == 0)
            {
                centerHeroes.Add(Heroes[(Heroes.Count / 2) - 1]);
            }

            centerHeroes.Add(Heroes[Heroes.Count / 2]);
        }

        return centerHeroes;
    }

    public override string ToString()
    {
        return string.Join(" ", Heroes);
    }
}