namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arrayOfNames = new string[50];
            int counter = 0;

            while (true)
            {
                Console.Write("Enter a name: ");
                string addedName = Console.ReadLine();
                arrayOfNames[counter] = addedName;
                counter++;

                Console.Write("Do you want to enter another name? (Y/N): ");
                string usersInput = Console.ReadLine();

                if (usersInput != "Y" && usersInput !="y")
                    break;
            }

            Console.WriteLine("Names entered:");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(arrayOfNames[i]);
            }
        }
    }
}