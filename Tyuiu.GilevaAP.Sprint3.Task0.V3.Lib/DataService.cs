using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GilevaAP.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                double sinv = Math.Sin((double)i);
                double powv = Math.Pow(0.5, 2);
                S = S + (sinv * powv);
            }
            return Math.Round(S, 3);
        }
    }
}