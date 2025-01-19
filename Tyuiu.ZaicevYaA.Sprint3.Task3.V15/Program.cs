using Tyuiu.ZaicevYaA.Sprint3.Task3.V15.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #3                                                     *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                         *");
            Console.WriteLine("* Задание #3                                                    *");
            Console.WriteLine("* Вариант #15                                                   *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("*Используя цикл foreach подсчитать минимальное количество букв m*");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            DataService dataService = new DataService();
            char item = 'm';
            string value = "lrmmse mg sermmmrt";
            Console.WriteLine($"строка :{value}");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("ответ " + dataService.GetMaxCharCount(value,item));
            Console.ReadKey();
        }
    }
}