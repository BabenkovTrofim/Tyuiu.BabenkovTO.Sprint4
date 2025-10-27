using Tyuiu.BabenkovTO.Sprint4.Task6.V23.Lib;
namespace Tyuiu.BabenkovTO.Sprint4.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] nameCompany = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            Assert.AreEqual(2, ds.Calculate(nameCompany));
        }
    }
}
