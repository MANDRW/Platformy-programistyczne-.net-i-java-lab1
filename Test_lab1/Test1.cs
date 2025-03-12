using lab1;
namespace Test_lab1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem  = new Problem(n,1);
                Assert.AreEqual(n, problem.Items.Count);
            }
        }
    }
}
    