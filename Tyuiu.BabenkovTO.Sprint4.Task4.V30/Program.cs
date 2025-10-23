using Tyuiu.BabenkovTO.Sprint4.Task4.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (ввод c клавиатуры)                             *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* с клавиатуры в диапазоне от 3 до 7. Заменить нечетные элементы          *");
        Console.WriteLine("* массива на 0.                                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите количество строк матрицы = ");
        int len0 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы = ");
        int len1 = Convert.ToInt32(Console.ReadLine());
        int[,] mtrx = new int[len0, len1];
        for(int i = 0; i < len0; i++)
        {
            for(int j = 0; j < len1; j++)
            {
                Console.Write($"Укажите элемент матрицы с индексами {i+1},{j+1} = ");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < len0; i++)
        {
            for (int j = 0; j < len1; j++)
            {
                Console.Write(mtrx[i, j] + " ");
            }
            Console.Write("\n\r");
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int[,] newMtrx = ds.Calculate(mtrx);
        Console.WriteLine("Результат:");
        for (int i = 0; i < len0; i++)
        {
            for (int j = 0; j < len1; j++)
            {
                Console.Write(newMtrx[i, j] + " ");
            }
            Console.Write("\n\r");
        }
    }
}