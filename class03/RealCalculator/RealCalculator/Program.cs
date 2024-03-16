namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");

            double firstInput;
            double secondInput;
            char operand;
            double result = 0;



            while (!double.TryParse(Console.ReadLine(), out firstInput))
            {
                Console.WriteLine("Invalid input. Enter the number again:");
            }

            Console.WriteLine("Input the second number:");

            

            while (!double.TryParse(Console.ReadLine(), out secondInput))
            {
                Console.WriteLine("Invalid input. Enter the number again:");
            }

            Console.WriteLine("Choose one of the following operations:  +, - , * , /");

            

            while (!char.TryParse(Console.ReadLine(), out operand))
            {
                Console.WriteLine("Invalid input. Enter an operation again:");
            }


            

            switch (operand)
            {
                case '+':
                    result = firstInput + secondInput;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = firstInput - secondInput;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = firstInput * secondInput;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = firstInput / secondInput;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Invalid operation selected");
                    break;
            }
        }
    }
}
