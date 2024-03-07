namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");

            double firstInput;

            while (!double.TryParse(Console.ReadLine(), out firstInput))
            {
                Console.WriteLine("Invalid input. Enter the number again:");
            }

            Console.WriteLine("Input the second number:");

            double secondInput;

            while (!double.TryParse(Console.ReadLine(), out secondInput))
            {
                Console.WriteLine("Invalid input. Enter the number again:");
            }

            Console.WriteLine("Choose one of the following operations:  +, - , * , /");

            char operand;

            while (!char.TryParse(Console.ReadLine(), out operand))
            {
                Console.WriteLine("Invalid input. Enter an operation again:");
            }


            double sum = 0;

            switch (operand)
            {
                case '+':
                    sum = firstInput + secondInput;
                    Console.WriteLine(sum);
                    break;
                case '-':
                    sum = firstInput - secondInput;
                    Console.WriteLine(sum);
                    break;
                case '*':
                    sum = firstInput * secondInput;
                    Console.WriteLine(sum);
                    break;
                case '/':
                    sum = firstInput / secondInput;
                    Console.WriteLine(sum);
                    break;
                default:
                    Console.WriteLine("Invalid operation selected");
                    break;
            }
        }
    }
}
