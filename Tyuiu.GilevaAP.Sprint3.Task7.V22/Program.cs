using Tyuiu.GilevaAP.Sprint3.Task7.V22.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Start: " + startValue);
            Console.WriteLine("Stop: " + stopValue);
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("| {0,8} | {1,8} |", x, valueArray[count]);
                count++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}