using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GilevaAP.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumD = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0 && d < 10)
                    {
                        sumD += d;
                    }
                }
            }
            return sumD;
        }
    }
}
