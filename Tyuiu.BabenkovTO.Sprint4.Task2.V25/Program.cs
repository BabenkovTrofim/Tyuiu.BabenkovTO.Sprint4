using Tyuiu.BabenkovTO.Sprint4.Task2.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
        Console.WriteLine("* случайными в диапазоне от 3 до 9 подсчитать произведение четных         *");
        Console.WriteLine("* элементов массива.                                                      *"); 
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Random rn = new Random();
        int[] ar = new int[11];
        for (int i = 0; i < ar.Length; i++)
        {
            ar[i] = rn.Next(3, 9);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Массив: ");
        foreach (int x in ar)
            Console.Write(x + " ");
        Console.Write("\n\r");
        DataService ds = new DataService();
        int result = ds.Calculate(ar);
        Console.WriteLine($"Произведение четных элементов массива = {result}");
    }
}