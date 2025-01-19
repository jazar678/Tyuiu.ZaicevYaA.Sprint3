using Tyuiu.ZaicevYaA.Sprint3.Task5.V20.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task5.V20
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                         *");
            Console.WriteLine("* Задание #5                                                    *");
            Console.WriteLine("* Вариант #20                                                   *");
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
            int x = 5;
            int startValue1 = 1;
            Console.WriteLine("Старт шага 1 = " + startValue1);
            int startValue2 = 1;
            Console.WriteLine("Старт шага 2 = " + startValue2);
            int stopValue1 = 3;
            Console.WriteLine("Конец шага 1 = " + stopValue1);
            int stopValue2 = 6;
            Console.WriteLine("Конец шага 2 = " + stopValue2);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("ответ " + dataService.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));
            Console.ReadKey();
        }
    }
}