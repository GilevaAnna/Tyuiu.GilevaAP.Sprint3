using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GilevaAP.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MS = 1;
            double sin7 = Math.Pow(Math.Sin(1), - 7);
            int k = startValue;
            do
            {
                double c1 = k / sin7;
                double c2 = Math.Pow(c1, -2);
                MS *= c2;
                k++;
            } while (k<=stopValue);
            return Math.Round(MS, 3);
        }
    }
}
