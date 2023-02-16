using NumberWriterLib;

namespace NumberWriterTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DivisibleInputsAreConverted()
        {
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(100);

            Assert.IsTrue(results?.Contains("Fizz Buzz"));
        }

        [TestMethod]
        public void ZeroInputReturnsNothing()
        {
            var numWriter = new NumberWriter();
            var results = numWriter?.WriteNumbers(0);

            Assert.IsTrue(results?.Count() == 0);
        }
    }
}