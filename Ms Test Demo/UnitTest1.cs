namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator c = new Calculator();
            int result = c.Add(5, 5);
            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Bank b = new Bank();

            int result = b.Deposit(200, 1000);
           
           Assert.AreEqual(1200, result);
            
        }

        [TestMethod]
        public void TestMethod3()
        {
            Bank b = new Bank();
          
            int result1 = b.Withdraw(200, 1000);
            Assert.AreEqual(800, result1);
        }

    }
}