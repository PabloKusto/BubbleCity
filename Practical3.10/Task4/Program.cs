using System.Diagnostics.Metrics;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел:");

            int enterValueNum = int.Parse(Console.ReadLine());
            int inputCounter = 0;
            int minValue = int.MaxValue;

            for (int i = 0; i < enterValueNum; i++)
            {
                inputCounter++;
                Console.WriteLine($"Введите число  {inputCounter}:");
                int inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber < minValue)
                {
                    minValue = inputNumber;

                }

                

                
            }
            Console.WriteLine($"Наименьшие число в последовательности: {minValue}");
        }
    }
}