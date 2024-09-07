namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем вас в игре угадай число!" +
                "\nВведите число (отличное от 0) до которого будет расчитан диапaзон:");
            int playerAnswer = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();
            int correctNumber = randomNumber.Next(1, playerAnswer + 1);
            Console.WriteLine($"Если вы хотите задать диапазон от 0 До {playerAnswer} нажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Введите число");
            
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "")
                {
                    Console.WriteLine($"Загаданное число было  {correctNumber}"); 
                    break;
                }
                
                else playerAnswer = int.Parse(line);
                
                if (playerAnswer > correctNumber)
                {
                    
                    Console.WriteLine("\nЗагаданное число меньше");
                   
                    
                }
                else if (playerAnswer < correctNumber)
                {
                    Console.WriteLine("\nЗагаданное число больше");
                    
                }
                else if (playerAnswer == correctNumber)
                {
                    Console.WriteLine("Поздравляем вы угадали!");
                    break;
                }
               
               
                

                
            }
        }
    }
}