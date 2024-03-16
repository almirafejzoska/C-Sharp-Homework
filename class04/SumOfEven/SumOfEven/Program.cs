namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {


         int[] sixIntegers = new int[6];
         int isEven = 0;

            for (int i = 0; i < sixIntegers.Length; i++)
            {
            Console.Write($"Enter the {i + 1}st number: ");
                if (int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    sixIntegers[i] = inputNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            foreach (int num in sixIntegers)
            {
                if (num % 2 == 0)
                {
                    isEven += num;
                }
            }
            Console.WriteLine($"The sum of the even numbers is: {isEven}");
        }
    }
}
