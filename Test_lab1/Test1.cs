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

        [TestMethod]
        public void TestMethod2()
        {
            Problem problem = new Problem(1,2);

            problem.Add(new Przedmiot(1, 1, 1));
            problem.Add(new Przedmiot(2, 1, 2));

            Result result =problem.Solve(1);
            Assert.AreNotEqual(result.Numbers.Count,0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Problem problem = new Problem(0, 2);

            problem.Add(new Przedmiot(1, 2, 2));
            problem.Add(new Przedmiot(2, 2, 2));
            

            Result result = problem.Solve(1);
            Assert.IsTrue(result.Numbers.Count == 0);
        }
    
    [TestMethod]
        public void TestMethod4()
        {
            Problem problem = new Problem(0, 2);

            problem.Add(new Przedmiot(0, 2, 2));
            problem.Add(new Przedmiot(1, 3, 1));
            problem.Add(new Przedmiot(2, 7, 4));

            Result result = problem.Solve(7);
            List<int> ints = new List<int> { 1, 2, 0 };

            CollectionAssert.AreEqual(ints, result.Numbers);

            Assert.AreEqual(2 + 3 + 7, result.SumValue);
            Assert.AreEqual(2+1+4, result.SumWeight);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Problem problem = new Problem(3, 2);
            Result result = problem.Solve(0);
            Assert.IsTrue(result.Numbers.Count == 0);
        }
    }
}
    