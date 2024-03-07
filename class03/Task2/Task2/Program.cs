namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");

            int firstInput;
            bool firstNum = int.TryParse(Console.ReadLine(), out firstInput);

            for (int i = 1; i <= firstInput; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Input another number:");

            int secondInput;
            bool secondNum = int.TryParse(Console.ReadLine(), out secondInput);

            for (int i = secondInput; i > 0; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
