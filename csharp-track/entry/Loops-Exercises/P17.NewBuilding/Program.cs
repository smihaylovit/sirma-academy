internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfFloors = int.Parse(Console.ReadLine()!);
        int numberOfRoomsPerFloor = int.Parse(Console.ReadLine()!);

        for (int floor = numberOfFloors; floor >= 1; floor--)
        {
            for (int room = 0; room < numberOfRoomsPerFloor; room++)
            {
                string roomType;

                if (floor == numberOfFloors)
                {
                    roomType = "L";
                }
                else if (floor % 2 == 0)
                {
                    roomType = "O";
                }
                else
                {
                    roomType = "A";
                }

                Console.Write($"{roomType}{floor}{room} ");
            }

            Console.WriteLine();
        }
    }
}