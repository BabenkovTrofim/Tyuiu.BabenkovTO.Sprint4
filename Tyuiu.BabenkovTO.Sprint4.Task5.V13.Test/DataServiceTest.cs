using Tyuiu.BabenkovTO.Sprint4.Task5.V13.Lib;
namespace Tyuiu.BabenkovTO.Sprint4.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = {{ 3, 4, 4, -1, 5 },
                            { 3, -2, 0, 1, 5 },
                            { 1, -1, 5, 4, 3 },
                            { 2, 3, 5, 0, -1 },
                            { 0, -2, 4, -1, 5 }};
            int[,] wait = {{ 3, 4, 4, 0, 5 },
                           { 3, 0, 0, 1, 5 },
                           { 1, 0, 5, 4, 3 },
                           { 2, 3, 5, 0, 0 },
                           { 0, 0, 4, 0, 5 }};
            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}
