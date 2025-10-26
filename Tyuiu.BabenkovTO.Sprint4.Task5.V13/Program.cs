using Tyuiu.BabenkovTO.Sprint4.Task5.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* случайными значениями в диапазоне от -2 до 5.                           *");
        Console.WriteLine("* Заменить отрицательные элементы на 0.                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите количество строк матрицы = ");
        int line = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы = ");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[line, columns];
        Random rnd = new Random();
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = rnd.Next(-2, 5);
                Console.Write(matrix[i, j] + " ");
            }
            Console.Write("\n\r");
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int[,] newMatrix = ds.Calculate(matrix);
        Console.WriteLine("Новая матрица:");
        for (int i = 0; i < line; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.Write("\n\r");
        }
    }
}