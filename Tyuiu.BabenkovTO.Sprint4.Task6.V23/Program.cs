using Tyuiu.BabenkovTO.Sprint4.Task6.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных {Microsoft, Google, Apple, Amazon, Facebook,*");
        Console.WriteLine("* Tesla, Netflix} используя класс Array подсчитайте количество            *");
        Console.WriteLine("* элементов, длина которых равна 6.                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string[] nameCompany = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
        foreach(string item in nameCompany)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int res = ds.Calculate(nameCompany);
        Console.WriteLine($"Количество элементов массива длинной 6 символов = {res}");
    }
}