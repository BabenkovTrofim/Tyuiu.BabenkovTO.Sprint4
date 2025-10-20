using Tyuiu.BabenkovTO.Sprint4.Task1.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 8 подсчитать сумму четных   *");
        Console.WriteLine("* элементов массива.  С клавиатуры: 8, 1, 5, 4, 2, 1, 2, 7, 6, 1          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите значение элемента " + i + " массива array: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Массив: ");
        foreach(int x in array)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
        DataService ds = new DataService();
        int sum = ds.Calculate(array);
        Console.WriteLine($"Сумма четных элементов массива = {sum}");
    }
}