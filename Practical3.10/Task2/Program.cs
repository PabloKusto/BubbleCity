using System.Threading.Channels;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру 21\nВведите колечиство партий которое хотели бы сыграть!");
            Console.WriteLine("Максимально допустимое партий составляет 255");

            string inputValueParty = Console.ReadLine();
            byte.TryParse(inputValueParty, out byte valueParty);
            if (valueParty > 255 || valueParty < 0) ; Console.WriteLine("Введите число от 1 до 255" );


            for (byte i = 0; i < valueParty; i++)
            {

                Random random = new Random();
                byte handPlayerFirstCard = (byte)random.Next(1, 14);
                byte handPlayerSecondCard = (byte)random.Next(1, 14);
                byte handPlayerScore;
                byte handСroupierFirstCard = (byte)random.Next(1, 14);
                byte handСroupierSecondCard = (byte)random.Next(1, 14);
                byte handСroupierScore;

                switch (handPlayerFirstCard)
                {
                    case 1: Console.WriteLine("У вас [2]"); handPlayerFirstCard = 2; break;
                    case 2: Console.WriteLine("У вас [3]"); handPlayerFirstCard = 3; break;
                    case 3: Console.WriteLine("У вас [4]"); handPlayerFirstCard = 4; break;
                    case 4: Console.WriteLine("У вас [5]"); handPlayerFirstCard = 5; break;
                    case 5: Console.WriteLine("У вас [6]"); handPlayerFirstCard = 6; break;
                    case 6: Console.WriteLine("У вас [7]"); handPlayerFirstCard = 7; break;
                    case 7: Console.WriteLine("У вас [8]"); handPlayerFirstCard = 8; break;
                    case 8: Console.WriteLine("У вас [9]"); handPlayerFirstCard = 9; break;
                    case 9: Console.WriteLine("У вас [10]"); handPlayerFirstCard = 10; break;
                    case 10: Console.WriteLine("У вас [J]"); handPlayerFirstCard = 10; break;
                    case 11: Console.WriteLine("У вас [Q]"); handPlayerFirstCard = 10; break;
                    case 12: Console.WriteLine("У вас [K]"); handPlayerFirstCard = 10; break;
                    case 13: Console.WriteLine("У вас [A]"); handPlayerFirstCard = 11; break;
                }

                switch (handPlayerSecondCard)
                {
                    case 1: Console.WriteLine("У вас [2]"); handPlayerSecondCard = 2; break;
                    case 2: Console.WriteLine("У вас [3]"); handPlayerSecondCard = 3; break;
                    case 3: Console.WriteLine("У вас [4]"); handPlayerSecondCard = 4; break;
                    case 4: Console.WriteLine("У вас [5]"); handPlayerSecondCard = 5; break;
                    case 5: Console.WriteLine("У вас [6]"); handPlayerSecondCard = 6; break;
                    case 6: Console.WriteLine("У вас [7]"); handPlayerSecondCard = 7; break;
                    case 7: Console.WriteLine("У вас [8]"); handPlayerSecondCard = 8; break;
                    case 8: Console.WriteLine("У вас [9]"); handPlayerSecondCard = 9; break;
                    case 9: Console.WriteLine("У вас [10]"); handPlayerSecondCard = 10; break;
                    case 10: Console.WriteLine("У вас [J]"); handPlayerSecondCard = 10; break;
                    case 11: Console.WriteLine("У вас [Q]"); handPlayerSecondCard = 10; break;
                    case 12: Console.WriteLine("У вас [K]"); handPlayerSecondCard = 10; break;
                    case 13: Console.WriteLine("У вас [A]"); handPlayerSecondCard = 11; break;

                }
                handPlayerScore = (byte)(handPlayerFirstCard + handPlayerSecondCard);
                Console.WriteLine($"Сумма очков в вашей руке составляет {handPlayerScore}");


                switch (handСroupierFirstCard)
                {
                    case 1: Console.WriteLine("У вас [2]"); handСroupierFirstCard = 2; break;
                    case 2: Console.WriteLine("У вас [3]"); handСroupierFirstCard = 3; break;
                    case 3: Console.WriteLine("У вас [4]"); handСroupierFirstCard = 4; break;
                    case 4: Console.WriteLine("У вас [5]"); handСroupierFirstCard = 5; break;
                    case 5: Console.WriteLine("У вас [6]"); handСroupierFirstCard = 6; break;
                    case 6: Console.WriteLine("У вас [7]"); handСroupierFirstCard = 7; break;
                    case 7: Console.WriteLine("У вас [8]"); handСroupierFirstCard = 8; break;
                    case 8: Console.WriteLine("У вас [9]"); handСroupierFirstCard = 9; break;
                    case 9: Console.WriteLine("У вас [10]"); handСroupierFirstCard = 10; break;
                    case 10: Console.WriteLine("У вас [J]"); handСroupierFirstCard = 10; break;
                    case 11: Console.WriteLine("У вас [Q]"); handСroupierFirstCard = 10; break;
                    case 12: Console.WriteLine("У вас [K]"); handСroupierFirstCard = 10; break;
                    case 13: Console.WriteLine("У вас [A]"); handСroupierFirstCard = 11; break;
                }

                switch (handPlayerSecondCard)
                {
                    case 1: Console.WriteLine("У вас [2]"); handСroupierSecondCard = 2; break;
                    case 2: Console.WriteLine("У вас [3]"); handСroupierSecondCard = 3; break;
                    case 3: Console.WriteLine("У вас [4]"); handСroupierSecondCard = 4; break;
                    case 4: Console.WriteLine("У вас [5]"); handСroupierSecondCard = 5; break;
                    case 5: Console.WriteLine("У вас [6]"); handСroupierSecondCard = 6; break;
                    case 6: Console.WriteLine("У вас [7]"); handСroupierSecondCard = 7; break;
                    case 7: Console.WriteLine("У вас [8]"); handСroupierSecondCard = 8; break;
                    case 8: Console.WriteLine("У вас [9]"); handСroupierSecondCard = 9; break;
                    case 9: Console.WriteLine("У вас [10]"); handСroupierSecondCard = 10; break;
                    case 10: Console.WriteLine("У вас [J]"); handСroupierSecondCard = 10; break;
                    case 11: Console.WriteLine("У вас [Q]"); handСroupierSecondCard = 10; break;
                    case 12: Console.WriteLine("У вас [K]"); handСroupierSecondCard = 10; break;
                    case 13: Console.WriteLine("У вас [A]"); handСroupierSecondCard = 11; break;

                }
                handСroupierScore = (byte)(handСroupierFirstCard + handСroupierSecondCard);
                Console.WriteLine($"Сумма очков в руке Крупье составляет: {handСroupierScore}");

                if (handPlayerScore > handСroupierScore && handPlayerScore != 22)
                {
                    Console.WriteLine("!!!Вы победили!!!!");

                }
                else if (handPlayerScore < handСroupierScore && handСroupierScore != 22)
                {
                    Console.WriteLine("Вы проиграли");
                }
                else if (handСroupierScore == 22)
                {
                    Console.WriteLine("!!!Вы Победили!!!");
                }
                else if (handPlayerScore == 22)
                {
                    Console.WriteLine("Вы проиграли");

                }
                else if (handPlayerScore == 22 && handСroupierScore == 22)
                {
                    Console.WriteLine("Партия считается очень редкой и не засчитывается можете принять это как ничью");



                }
            }
        }
    }
}