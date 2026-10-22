using Tyuiu.GilevaAP.Sprint3.Task2.V4.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task2.V4
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
            int stopValue = 9;

            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Стоп шаг: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(startValue, stopValue));

            Console.ReadKey();
        }
    }
}