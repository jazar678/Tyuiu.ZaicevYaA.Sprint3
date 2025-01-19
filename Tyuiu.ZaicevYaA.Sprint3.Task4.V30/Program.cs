using Tyuiu.ZaicevYaA.Sprint3.Task4.V30.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                         *");
            Console.WriteLine("* Задание #4                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
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
            Console.WriteLine("Старт шага = " + startValue);
            int stopValue = 5;
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("ответ " + dataService.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}