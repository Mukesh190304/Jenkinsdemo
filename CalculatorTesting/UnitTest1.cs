using CalculatorApp;

namespace CalculatorTesting

{

    [TestFixture]

    public class Tests

    {

        private Calculator _calculator;

        [SetUp]

        public void Setup()

        {

            _calculator = new Calculator();

        }

        [Test]

        public void Add_TwoNumbers_Equal()

        {

            int result = _calculator.add(10, 2);

            Assert.AreEqual(12, result);

        }

        // This test should use a different expected value

        [Test]

        public void Add_TwoNumbers_NotEqual()

        {

            int result = _calculator.add(10, 2);

            Assert.AreNotEqual(15, result); // 12 ≠ 15, so this will pass

        }

        [Test]

        public void Product_TwoNumbers_Equal()

        {

            int result = _calculator.product(4, 5);

            Assert.AreEqual(20, result);

        }

        // Again, use a different expected value

        [Test]

        public void Product_TwoNumbers_NotEqual()

        {

            int result = _calculator.product(4, 5);

            Assert.AreNotEqual(25, result); // 20 ≠ 25, so this will pass

        }
         [Test]

        public void Product_TwoNumbers_NotEqual1()

        {

            int result = _calculator.product(4, 5);

            Assert.AreNotEqual(25, result); // 20 ≠ 25, so this will pass

        }
        

    }

}

