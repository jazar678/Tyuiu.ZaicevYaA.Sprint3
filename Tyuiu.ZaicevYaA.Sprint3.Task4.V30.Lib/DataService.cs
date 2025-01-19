using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaicevYaA.Sprint3.Task4.V30.Lib
{
    public class DataService : ISprint3Task4V30
    {
        public double Calculate(int startValue, int stopValue)
        {
           double b = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                if (i != 0)
                {
                    b = b + (Math.Sin(i)/i);
                }
            }
            return Math.Round(b, 3);
        }
    }
}
