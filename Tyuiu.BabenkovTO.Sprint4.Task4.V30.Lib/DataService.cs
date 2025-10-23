using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkovTO.Sprint4.Task4.V30.Lib
{
    public class DataService : ISprint4Task4V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        matrix[i, j] = 0;
                    else
                        continue;
                }
            }
            return matrix;
        }
    }
}
