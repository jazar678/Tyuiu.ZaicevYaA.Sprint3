using Tyuiu.ZaicevYaA.Sprint3.Task2.V30.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                         *");
            Console.WriteLine("* Задание #2                                                    *");
            Console.WriteLine("* Вариант #30                                                   *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Написать программу используя цикл do...while                  *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле, при х=0,25    *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            DataService dataService = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            Console.WriteLine("Переменная x: " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Произведение ряда = " + dataService.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}