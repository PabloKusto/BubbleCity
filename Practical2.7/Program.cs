
namespace Practical2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Аганович Андрей Алексеевич";
            int age = 19;
            double programmicScores = 93.5;
            double MathematicsScores = 78.4;
            double PhysicsScores = 87.8;

            Console.WriteLine($"ФИО: {fullName} \nВозраст: {age}" +
                 $" \nБаллы по программированию:{programmicScores}" +
                 $" \nБаллы по математике:{MathematicsScores} \nБаллы по Физике:{PhysicsScores}");
            Console.ReadKey();

            int countAcademicSubjects = 3;
            double amountScores = (programmicScores + MathematicsScores + PhysicsScores);
            double averageScore = amountScores / countAcademicSubjects;
            double averageScoreFormatted = Math.Round(averageScore, 2);
            Console.WriteLine($"Средний балл студента по предмета:{averageScoreFormatted}");



        }
    }

}