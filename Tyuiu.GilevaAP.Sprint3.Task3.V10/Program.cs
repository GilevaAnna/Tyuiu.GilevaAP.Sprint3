using Tyuiu.GilevaAP.Sprint3.Task3.V10.Lib;
namespace Tyuiu.GilevaAP.Sprint3.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gdfppf vfppt p";
            char item = 'p';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомый символ: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат = " + ds.DeleteCharInString(value, item));

            Console.ReadKey();
        }
    }
}