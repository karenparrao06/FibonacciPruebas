
using Fibonacci;
using NUnit.Framework;


namespace TestFibonacci
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Fibonacci1 fibonacci = new Fibonacci1();
            var resultado = fibonacci.calcularFibonacci(null);
            Assert.AreEqual(false,resultado);
        }
    }
}