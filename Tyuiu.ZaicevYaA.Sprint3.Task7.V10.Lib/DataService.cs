using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaicevYaA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int er = 0;
            int s = stopValue - startValue + 1;
            double[] result = new double[s];
            for (int i = startValue; i < stopValue; i++) 
            {
                result[er] = ((5*i + 2.5)/(Math.Sin(i) + 3))+ 2 * i + Math.Cos(i);
                if (double.IsInfinity(result[er]) || double.IsNaN(result[er]))
                {
                    result[er] = 0;
                    er++;
                }
                result[er] = Math.Round(result[er],2);
                er++;
            }
            return result;
        }
    }
}
