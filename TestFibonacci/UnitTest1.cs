
using Fibonacci;
using NUnit.Framework;


namespace TestFibonacci
{
    public class Tests
    {
        Fibonacci1 fibonacci;
        [SetUp]
        public void Setup()
        {
            fibonacci = new Fibonacci1();
        }

        [Test]
        public void TestNull()
        {
            var result = fibonacci.calcularFibonacci(null);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestNegativos()
        {
            var result = fibonacci.calcularFibonacci(-1);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestLimite()
        {
            var result = fibonacci.calcularFibonacci(501);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestCero()
        {
            var result = fibonacci.calcularFibonacci(0);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestaLetras()
        {
            Assert.That(() =>
                fibonacci.calcularFibonacci(int.Parse("abc")),
                Throws.Exception);
        }


    }
}