using Tyuiu.BabenkovTO.Sprint4.Task0.V25.Lib;
namespace Tyuiu.BabenkovTO.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            Assert.AreEqual(42, ds.GetSumEvenArrEl(array));
        }
    }
}
