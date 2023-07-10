namespace NUnitDemo
{
    public class Tests
    {
        private int val = 0;
        [SetUp]
        public void Setup()
        {
            //test data initialization
            val = 10;
        }
        [Test]
        public void Test2()
        {
            Assert.That(2 * val, Is.EqualTo(20));
        }
        [Test]
        public void Test1()
        {
            Calculator c = new Calculator();
            //Assert.AreEqual(10,c.Add(5,5));//classical model usage of Assert
            Assert.That(c.Add(5, 5), Is.EqualTo(10));//constraint model usage of Assert
        }
        [TearDown]
        //finally
        public void TearDown()
        {
            val = 0;
        }
        
        [Test]
        public void TestMethod2()
        {
            Bank b = new Bank();
            
            Assert.That(b.Deposit(5, 5), Is.EqualTo(10));
        }

        [Test]
         public void TestMethod3()
        {
            Bank b = new Bank();
          
            Assert.That(b.Withdraw(5, 5), Is.EqualTo(10));
        }

    }
}