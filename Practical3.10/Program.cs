namespace Practical3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double enterNumber;
            Console.WriteLine("Введите число и нажмите 'Enter' ");
            enterNumber = Convert.ToDouble(Console.ReadLine());

            if (enterNumber % 2 == 0)
            {
                Console.WriteLine($"Введенное вами число {enterNumber} является чётным");
            }
            else if (enterNumber == 0)
            {
                Console.WriteLine("Введенное вами число ноль");
            }
            else if (enterNumber % 2 != 0)
            {
                Console.WriteLine($"Введённое вами число {enterNumber} является нечётным");
            }

        }
    }
}
