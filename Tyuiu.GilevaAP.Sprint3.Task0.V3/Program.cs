using Tyuiu.GilevaAP.Sprint3.Task0.V3.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Стоп шаг: " + stopValue);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = "+ds.GetSumSeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}