namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int forSwap;

            Console.WriteLine("Input the first number");
            bool firstNumber = int.TryParse(Console.ReadLine(), out firstNum);

            Console.WriteLine("Input the second number");
            bool secondNumber = int.TryParse(Console.ReadLine(), out secondNum);

            forSwap = firstNum;
            firstNum = secondNum;
            secondNum = forSwap;


            Console.WriteLine("After Swapping:");
            Console.WriteLine($"First Number:{firstNum}");
            Console.WriteLine($"Second Number: {secondNum}");
        }
    }
}
