using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.UnitTest
{
    [TestClass]
    public sealed class CalculatorServiceTests
    {
        private CalculatorService service;

        [TestInitialize]
        public void TestInitialize()
        {
            this.service = new CalculatorService();
        }

        [TestMethod]
        public void SumTest_傳入augend為10_addend為20_預期回傳30()
        {
            var augend = 10;
            var addend = 20;

            var expected = 30;

            var actual = this.service.Sum(augend, addend);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiffrenceTest_傳入minuend為20_subtrahend為10_預期回傳10()
        {
            var minuend = 20;
            var subtrahend = 10;

            var expected = 10;

            var actual = this.service.Diffrence(minuend, subtrahend);

            Assert.AreEqual(expected, actual);
        }
    }
}