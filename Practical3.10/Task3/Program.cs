using System.Diagnostics.Metrics;

namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для проверки:");
        int enterNumber = int.Parse(Console.ReadLine());
        int counter = 0;
        int i = 2;

        while (i < enterNumber)
        {
            if (enterNumber % i == 0) counter++;

            i++;
        }
        if (counter == 0)
        {
            Console.WriteLine("Введено простое число");
        }
        else Console.WriteLine("Введено непростое число");
       
    }

}