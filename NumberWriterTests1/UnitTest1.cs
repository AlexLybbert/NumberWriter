using NumberWriterLib;

namespace NumberWriterTests1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnsExpectedOutput()
        {
            // Arrange
            int upperBound = 15;
            Tuple<int, string> numberWord1 = new Tuple<int, string>(3, "Fizz");
            Tuple<int, string> numberWord2 = new Tuple<int, string>(5, "Buzz");

            // Act
            var numWriter = new NumberWriter();
            var result = numWriter.WriteNumbers(upperBound, numberWord1, numberWord2);

            // Assert
            var expectedOutput = new List<string>
            {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "Fizz Buzz"
            };
            CollectionAssert.AreEqual(expectedOutput, result.ToList());
        }

        [TestMethod]
        public void DivisibleInputsAreConverted()
        {
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(100, new Tuple<int, string>(3, "Fizz"), new Tuple<int, string>(5, "Buzz"));

            Assert.IsTrue(results?.Contains("Fizz Buzz"));
        }

        [TestMethod]
        public void CanHandleLargeNumber()
        {
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(100000000, new Tuple<int, string>(3, "Fizz"), new Tuple<int, string>(5, "Buzz"));

            Assert.IsTrue(results?.Count() == 100000000);
        }

        [TestMethod]
        public void ZeroInputReturnsNothing()
        {
            // Arrange
            int upperBound = 0;
            Tuple<int, string> numberWord1 = new Tuple<int, string>(3, "Fizz");
            Tuple<int, string> numberWord2 = new Tuple<int, string>(5, "Buzz");

            // Act
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(upperBound, numberWord1, numberWord2);

            // Assert
            var expectedOutput = new List<string>();
            CollectionAssert.AreEqual(expectedOutput, results.ToList());
        }

        [TestMethod]
        public void CanHandleNulls()
        {
            // Arrange
            int upperBound = 5;
            Tuple<int, string> numberWord1 = null;
            Tuple<int, string> numberWord2 = null;

            // Act
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(upperBound, numberWord1, numberWord2);

            // Assert
            var expectedOutput = new List<string>
            {
                "1", "2", "3", "4", "5"
            };
            CollectionAssert.AreEqual(expectedOutput, results.ToList());
        }

        [TestMethod]
        public void CanHandleInput2Null()
        {
            // Arrange
            int upperBound = 6;
            Tuple<int, string> numberWord1 = new Tuple<int, string>(2, "Fizz");
            Tuple<int, string> numberWord2 = null;

            // Act
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(upperBound, numberWord1, numberWord2);

            // Assert
            var expectedOutput = new List<string>
            {
                "1", "Fizz", "3", "Fizz", "5", "Fizz"
            };
            CollectionAssert.AreEqual(expectedOutput, results.ToList());
        }

        [TestMethod]
        public void CanHandleInput1Null()
        {
            // Arrange
            int upperBound = 10;
            Tuple<int, string> numberWord1 = null;
            Tuple<int, string> numberWord2 = new Tuple<int, string>(3, "Buzz");

            // Act
            var numWriter = new NumberWriter();
            var results = numWriter.WriteNumbers(upperBound, numberWord1, numberWord2);

            // Assert
            var expectedOutput = new List<string>
            {
                "1", "2", "Buzz", "4", "5", "Buzz", "7", "8", "Buzz", "10"
            };
            CollectionAssert.AreEqual(expectedOutput, results.ToList());
        }
    }
}