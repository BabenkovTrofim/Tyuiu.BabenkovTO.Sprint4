using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkovTO.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach(int x in array)
            {
                if (x % 2 == 0)
                    sum += x;
            }
            return sum;
        }
    }
}
