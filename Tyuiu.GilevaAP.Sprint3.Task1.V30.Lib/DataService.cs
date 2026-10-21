using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GilevaAP.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumS = 0;
            int i = startValue;
            while (i <= stopValue) 
            {
                double x1 = Math.Pow(value, i);
                double x2 = 5.0/(i+4);

                sumS += x1+x2;
                i++;
            }
            double x3 = Math.Sin(value);
            double res = sumS * x3;
            return Math.Round(res, 3);
        }
    }
}
