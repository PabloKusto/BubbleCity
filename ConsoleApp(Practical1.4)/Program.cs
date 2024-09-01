namespace ConsoleApp_Practical1._4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello,");
            Console.Write(" World!");
            Console.WriteLine("Hello,");
            Console.WriteLine("World!");
            Console.Write("Нажмите Enter, чтобы завершить процесс.");


            while (true)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {

                    Environment.Exit(0);
                }
            }
        }
    }
}