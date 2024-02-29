namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first number");
            int firstNum;
            bool firstNumber = int.TryParse(Console.ReadLine(), out firstNum);

            Console.WriteLine("Write your second number");
            int secondNum;
            bool secondNumber = int.TryParse(Console.ReadLine(), out secondNum);

            Console.WriteLine("Write your third number");
            int thirdNum;
            bool thirdNumber = int.TryParse(Console.ReadLine(), out thirdNum);

            Console.WriteLine("Write your fourth number");
            int forthNum;
            bool forthNumber = int.TryParse(Console.ReadLine(), out forthNum);

            int averageNum = (firstNum + secondNum + thirdNum + forthNum) / 4;
            Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum} and {forthNum} is:{averageNum}");
        }
    }
}
