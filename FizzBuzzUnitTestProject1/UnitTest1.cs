using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void DivisibleByThree()
        {
            FizzBuzzConverter FB = new FizzBuzzConverter();
            int input = 3;
            string output = FB.Implementation(input);

            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        public void divisiblebyfive()
        {
            FizzBuzzConverter FB = new FizzBuzzConverter();
            int input = 5;
            string output = FB.Implementation(input);

            Assert.AreEqual("Buzz", output);
        }

       [TestMethod]
        public void divisiblebythreeandfive()
        {
            FizzBuzzConverter FB = new FizzBuzzConverter();
            int input = 15;

            string output = FB.Implementation(input);

            Assert.AreEqual("FizzBuzz", output);
        }

         [TestMethod]
        public void notdivisblebythreeorfive()
        {
            FizzBuzzConverter FB = new FizzBuzzConverter();
            int input = 7;

            string output = FB.Implementation(input);

            Assert.AreEqual("7", output);
        }


    }
}
