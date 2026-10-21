using Tyuiu.GilevaAP.Sprint3.Task1.V30.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double value = 0.5;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Стоп шаг: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}