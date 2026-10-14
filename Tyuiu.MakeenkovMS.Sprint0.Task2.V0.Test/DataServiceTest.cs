using Tyuiu.MakeenkovMS.Sprint0.Task2.V1.Lib;
namespace Tyuiu.MakeenkovMS.Sprint0.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Максим";

            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Максим", res);
        }
    }
}
