using System.ComponentModel.DataAnnotations;

namespace Rub9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Зад 1.
            /*string[] array = { "Gfgdk", "dfkskf", "ii", "rtr", "dffa", "Greg", "kill", "Amper", "cxs", "iiIIopdsfo" };
            var Lengths = array.Sum(ar => ar.Length);
            Console.WriteLine(Lengths);*/

            //Зад 2.
            /*int[] nums = {7, -12, 3, 4, 25, 6, 3, -3, 95, 66};
            var pluss = nums.Where( n => n > 0);

            foreach( int n in pluss )
            {
                Console.Write(n + " ")
            }*/

            //Зад 3.
            /*int[] array = { 5, 14, 9, -22, 10, 52, 17, -2, 100, 73 };
            var sort = array.Where(n => n > 9 && n < 100);

            foreach ( var item in sort )
            {
                Console.Write(item + " ");
            }*/

            //Зад 4.
            /*var fitness = new List<FitnessCenter>()
            {
                new FitnessCenter(3972, 2011, 7, 3),
                new FitnessCenter(5011, 2012, 12, 2),
                new FitnessCenter(3712, 2011, 3, 4),
                new FitnessCenter(1742, 2009, 7, 2),
                new FitnessCenter(4260, 2012, 5, 1)
            };

            var LongTraining = fitness.Min(n => n.TrainingDuration);
            var MaxTraining = fitness.Max(n => n.TrainingDuration);

            Console.WriteLine($"Cамое продолжительное занятие {LongTraining} \n" +
                $"Cамое короткое занятие {MaxTraining}");*/

            //Зад 5.
            var fitness = new List<FitnessCenter>()
            {
                new FitnessCenter(3972, 2011, 7, 3),
                new FitnessCenter(5011, 2012, 12, 2),
                new FitnessCenter(3712, 2011, 3, 4),
                new FitnessCenter(1742, 2009, 7, 2),
                new FitnessCenter(2666, 2010, 7, 3),
                new FitnessCenter(1103, 2009, 1, 2),
                new FitnessCenter(3941, 2011, 4, 1),
                new FitnessCenter(1408, 2009, 4, 1),
                new FitnessCenter(4872, 2012, 6, 5),
                new FitnessCenter(4260, 2012, 5, 1)
            };

            var SumYear = fitness.GroupBy(n => n.Year).Select(g => new {Year = g.Key, DurationSum = g.Sum(x => x.TrainingDuration)}).OrderByDescending(n => n.DurationSum).ThenBy(n => n.Year).First();

            Console.WriteLine($"Год с сумарно наибольшей продолжительностью всех занятий = {SumYear.Year}, сумарная сумма = {SumYear.DurationSum}");
            
        }
    }
} 