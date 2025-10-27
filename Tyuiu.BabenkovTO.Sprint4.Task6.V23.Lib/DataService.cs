using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkovTO.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, x => x.Length == 6);
            return result.Length;
        }
    }
}
