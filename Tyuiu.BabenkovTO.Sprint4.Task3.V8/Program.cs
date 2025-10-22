using Tyuiu.BabenkovTO.Sprint4.Task3.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #8                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 2 до 8. Найдите минимальный      *");
        Console.WriteLine("* элементов массива в четвертом столбце массива.                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int[,] array = {{4, 4, 3, 3, 8 },
                       { 5, 3, 5, 5, 8 },
                       { 3, 7, 2, 2, 7 },
                       { 5, 2, 4, 4, 4 },
                       { 4, 4, 6, 8, 2 }};
        Console.WriteLine("Массив:");
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("\n\r");
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
       
        int result = ds.Calculate(array);
        Console.WriteLine($"Минимальный элемент 4-го столбца = {result}");
    }
}