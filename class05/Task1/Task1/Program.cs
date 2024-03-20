namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year of your birth:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month of your birth with a number(1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the day of your birth with a number:");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);

            int age = CalculateAge(birthDate);

            Console.WriteLine($"Your age is: {age}");
        }

        public static int CalculateAge(DateTime birthDate)
        {
            DateTime todaysDate = DateTime.Now;

            int age = todaysDate.Year - birthDate.Year;

            if (todaysDate.Month < birthDate.Month || (todaysDate.Month == birthDate.Month && todaysDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}