using Tyuiu.BabenkovTO.Sprint4.Task2.V25.Lib;
namespace Tyuiu.BabenkovTO.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 3, 5, 4, 4, 5, 3, 7, 6, 9, 5 };
            Assert.AreEqual(768, ds.Calculate(array));
        }
    }
}
