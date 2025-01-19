using Tyuiu.ZaicevYaA.Sprint3.Task6.V23.Lib;
namespace Tyuiu.ZaicevYaA.Sprint3.Task6.V23
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
            int startValue = 18;
            int stopValue = 28;

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("ответ " + dataService.GetSumTheDivisors(startValue,stopValue));
            Console.ReadKey();
        }
    }
}