using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 6)] //Add test data <-------
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            var test = new UnitTestMethods();
            //Arrange
            // create a Calculator object


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5, 10, -5)]//Add test data <-------
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5, 4, 20)]//Add test data <-------
        public void Multiply(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,5,4)]//Add test data <-------
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            var expected = 'h';

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName2()
        {

        }
    }
}
