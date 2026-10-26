using Tyuiu.GilevaAP.Sprint3.Task4.V9.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task4.V9
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

            Console.WriteLine("Результат = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}