namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];
            words[0] = "Dog";
            words[1] = "Cat";
            words[2] = "Capybara";
            words[3] = "Monkey";
            words[4] = "Owl";

            double[] decimalValue = new double[5];
            decimalValue[0] = 5.32;
            decimalValue[1] = 1.54;
            decimalValue[2] = 0.31;
            decimalValue[3] = 3.41;
            decimalValue[4] = 6.21;

            char[] characters = new char[5];
            characters[0]= 'A';
            characters[1] = 'J';
            characters[2] = '!';
            characters[3] = '?';
            characters[4] = 'D';

            bool[] boolValue = new bool[5];
            boolValue[0] = true;
            boolValue[1] = true;
            boolValue[2] = false;
            boolValue[3] = true;
            boolValue[4] = false;

            int[][] arrayWithNumbers = new int[5][];
            arrayWithNumbers[0] = new int[] { 31, 10 };
            arrayWithNumbers[1] = new int[] { 3, 7 };
            arrayWithNumbers[2] = new int[] { 90, 20 };
            arrayWithNumbers[3] = new int[] { 4, 9 };
            arrayWithNumbers[4] = new int[] { 20, 60 };
        }
    }
}
