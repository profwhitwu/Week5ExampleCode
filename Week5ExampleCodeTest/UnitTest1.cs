namespace Week5ExampleCodeTest
{
    [TestClass]
    public class UnitTest1
    {
        public Week5ExampleCode? week5Example;
        
        [TestInitialize]
        public void Setup()
        {
            week5Example = new Week5ExampleCode();
        }
        
        [TestMethod]
        public void CalculateFizzBuzz_IsDivisibleBy3_ReturnsFizz()
        {
            // arrange
            var numberToTest = 12;

            // act
            var result = week5Example?.CalculateFizzBuzz(numberToTest);

            // assert
            Assert.AreEqual(FizzBuzz.Fizz, result);

        }

        [TestMethod]
        public void CalculateFizzBuzz_IsDivisibleBy5_ReturnsBuzz()
        {
            // arrange
            var numberToTest = 10;

            // act
            var result = week5Example?.CalculateFizzBuzz(numberToTest);

            // assert
            Assert.AreEqual(FizzBuzz.Buzz, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_IsDivisibleBy3And5_ReturnsFizzBuzz()
        {
            // arrange
            var numberToTest = 30;

            // act
            var result = week5Example?.CalculateFizzBuzz(numberToTest);

            // assert
            Assert.AreEqual(FizzBuzz.FizzBuzz, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_IsNotDivisibleBy3Or5_ReturnsDefault()
        {
            // arrange
            var numberToTest = 7;

            // act
            var result = week5Example?.CalculateFizzBuzz(numberToTest);

            // assert
            Assert.AreEqual(FizzBuzz.Default, result);
        }
    }
}