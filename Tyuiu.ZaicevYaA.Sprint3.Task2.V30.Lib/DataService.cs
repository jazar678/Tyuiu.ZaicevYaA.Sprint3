using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaicevYaA.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            do
            {
                multiplySeries = multiplySeries * ((Math.Pow(value,2) * startValue)+2);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
