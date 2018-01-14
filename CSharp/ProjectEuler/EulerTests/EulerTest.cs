using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using Enumerable = System.Linq.Enumerable;

namespace EulerTests
{
    [TestClass]
    public class EulerTest
    {
        [TestMethod]
        public void Problem1_FindSumOfMultiplesOfThreeAndFiveBelow10()
        {
            int sum = Problems1.Problem1FindSumOfMultiplesOfThreeAndFiveBelow(10);
            
            Assert.AreEqual(23, sum, "Sum is not equal to 23");
        }

        [TestMethod]
        public void Problem1_FindSumOfMultiplesOfThreeAndFiveBelow1000()
        {
            int sum = Problems1.Problem1FindSumOfMultiplesOfThreeAndFiveBelow(1000);

            Assert.AreEqual(233168, sum, "Sum is not equal to 23");
        }

        [TestMethod]
        public void Problem2_FindSumOfEvenFibonacciNumbersUnder100()
        {
            uint sum = Problems1.Problem2FindSumOfEvenFibonacciNumbers(100U);

            Assert.AreEqual(188U, sum, "Sum is not equal to 44");
        }

        [TestMethod]
        public void Problem2_FindSumOfEvenFibonacciNumbersUnder4000000()
        {
            uint sum = Problems1.Problem2FindSumOfEvenFibonacciNumbers(4000000);

            Assert.AreEqual(4613732U, sum, "Sum is not equal to 4613732");
        }

        [TestMethod]
        public void Problem3_FindLargestPrimeFactorOf13195()
        {
            var num = 13195UL;
            var largestFactor = 0UL;
            var factors = Problems1.Problem3FindPrimveFactorsOfLargeNumber(num);
            var prod = factors.Aggregate((a, x) => a * x);
            if (prod == num)
            {
                largestFactor = (ulong)factors.Max(x=>x);
            }

            Assert.AreEqual(29UL, largestFactor, "Largest factor not equal to 29");
        }

        [TestMethod]
        public void Problem3_FindLargestPrimeFactorOf600851475143()
        {
            var num = 600851475143UL;
            var largestFactor = 0UL;
            var factors = Problems1.Problem3FindPrimveFactorsOfLargeNumber(num);
            var prod = factors.Aggregate((a, x) => a * x);
            if (prod == num)
            {
                largestFactor = (ulong)factors.Max(x => x);
            }

            Assert.AreEqual(6857UL, largestFactor, "Largest factor not equal to 6857");
        }
         

        /*******************   Test Helper Methods **********************************************/

        [TestMethod]
        public void HelpersFindPrimesLessThan20()
        {
            var num = 20UL;
            var primes = Helpers.SieveOfEratosthenes(num);

            Assert.AreEqual(8UL, (ulong)primes.Count, "Number of primes not equal to 8");
        }

        [TestMethod]
        public void HelpersFindPrimesLessThan1000000()
        {
            var num = 1000000UL;
            var primes = Helpers.SieveOfEratosthenes(num);
            Assert.AreEqual(78498UL, (ulong)primes.Count, "Number of primes not equal to 78498");
        }

        [TestMethod]
        public void HelpersFindPrimesLessThan1000000000()
        {
            var num = 1000000000UL;
            var primes = Helpers.SieveOfEratosthenes(num);
            Assert.AreEqual(50847534UL, (ulong)primes.Count, "Number of primes not equal to 50847534");
        }

        [TestMethod]
        public void HelpersTestIsPrimeByTrialDivision()
        {
            var is2prime = Helpers.IsPrimeByTrialDivision(2L);
            var is19Prime = Helpers.IsPrimeByTrialDivision(19L);
            var is7927Prime = Helpers.IsPrimeByTrialDivision(7927L);
            var is6Prime = Helpers.IsPrimeByTrialDivision(6L);
            var is54932947823Prime = Helpers.IsPrimeByTrialDivision(54932947823);

            Assert.IsTrue(is2prime, "2 is the even prime. this function sucks.");
            Assert.IsTrue(is19Prime, "19 is prime. fail.");
            Assert.IsTrue(is7927Prime, "7927 is prime. fail.");
            Assert.IsFalse(is6Prime, "idiot");
            Assert.IsFalse(is54932947823Prime, "54932947823 is not prime. fail.");


        }

        [TestMethod]
        public void HelpersTestIsPrimeByTrialDivisionFor50DigitPrime()
        {
            var isPrime = Helpers.IsPrimeByTrialDivision(5915587277UL);
            Assert.IsTrue(isPrime, "5915587277 is the even prime. this function sucks.");
        }
    }
}
