namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dog's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the dog's breed: ");
            string breed = Console.ReadLine();

            Console.Write("Enter the dog's color: ");
            string color = Console.ReadLine();

            Dog dog = new Dog
            {
                Name = name,
                Breed = breed,
                Color = color
            };

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Eat");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Chase Tail");

                int selectedNumber;
                if (!int.TryParse(Console.ReadLine(), out selectedNumber))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }
                else if (selectedNumber < 1 || selectedNumber > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3!");
                    continue;
                }
                else if (selectedNumber == 1)
                {
                    Console.WriteLine(dog.Eat());
                }
                else if (selectedNumber == 2)
                {
                    Console.WriteLine(dog.Play());
                }
                else if (selectedNumber == 3)
                {
                    Console.WriteLine(dog.ChaseTail());
                }

                break;
            }
        }
    }
}