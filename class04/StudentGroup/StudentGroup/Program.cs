namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Bob", "Gill", "Will", "John", "Joseph" };

            int chosenGroup;

            do
            {
                Console.Write("Enter the student group, 1 or 2: ");

                if (int.TryParse(Console.ReadLine(), out chosenGroup))
                {
                    if (chosenGroup == 1)
                    {
                        Console.WriteLine("The Students in G1 are:");
                        foreach (var student in studentsG1)
                        {
                            Console.WriteLine(student);
                        }
                    }
                    else if (chosenGroup == 2)
                    {
                        Console.WriteLine("The Students in G2 are:");
                        foreach (var student in studentsG2)
                        {
                            Console.WriteLine(student);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid group number. Please enter 1 or 2.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (chosenGroup != 1 && chosenGroup != 2);
        }
    }
}
