using Tyuiu.ZaicevYaA.Sprint3.Task7.V10.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                         *");
            Console.WriteLine("* Задание #7                                                    *");
            Console.WriteLine("* Вариант #10                                                   *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5                *");
            Console.WriteLine("*  вычислить значение функции y=sin(x)/x                        *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* +-----------+-----------+                                     *");
            Console.WriteLine("* |     X     |    F(X)   |                                     *");
            Console.WriteLine("* +-----------+-----------+                                     *");

            int len = dataService.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray = new double[len];

            valueArray = dataService.GetMassFunction(startValue, stopValue);

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("* | {0, 4:d}      |  {1, 6:f2}   |                                     *", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("* +-----------+-----------+                                     *");

            Console.WriteLine("*****************************************************************");



            Console.ReadKey();
        }
    }
}