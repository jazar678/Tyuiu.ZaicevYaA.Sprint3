using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZaicevYaA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            char[] lox = value.ToCharArray();
            for (int i = 0; i < lox.Length; i++)
            {
                if ((lox[i] == item) & (lox[i + 1] == item))
                {
                    count++;
                    break;
                }
            }
            return count;
        }
    }
}
