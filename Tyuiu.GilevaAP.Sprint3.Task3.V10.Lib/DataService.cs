using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GilevaAP.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            string res = "";
            foreach (char c in value)
            {
                if (c != item)
                {
                    res += c;
                }
            }
            return res;
        }
    }
}
