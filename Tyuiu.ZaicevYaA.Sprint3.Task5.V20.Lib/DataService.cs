using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaicevYaA.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double ser = 0;
            int j;
            int i;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue2; j++)
                {
                    ser = ser + Math.Pow((x / Math.Sin(x)),j);
                }  
            }
            
            return Math.Round(ser, 3);
        }
    }
    
}
