using System;
using Microsoft.Extensions.DependencyModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskForYourType;

namespace TaskForYourType.UnitTests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void GetZ_Tests()
        {
            int[] values = { int.MinValue, -1, 0, 1, int.MaxValue };

            foreach (var z in values)
            {
                var v = new Vector(1, 2, z);
                Assert.AreEqual(z, v.GetZ());
            }
        }

        [TestMethod]
        public void GetY_Tests()
        {
            int[] values = { int.MinValue, -1, 0, 1, int.MaxValue };

            foreach (var y in values)
            {
                var v = new Vector(1, y, 2);
                Assert.AreEqual(y, v.GetY());
            }
        }

        [TestMethod]
        public void GetX_Tests()
        {
            int[] values = { int.MinValue, -1, 0, 1, int.MaxValue };

            foreach (var x in values)
            {
                var v = new Vector(x, 2, 3);
                Assert.AreEqual(x, v.GetX());
            }
        }

        [TestMethod]
        public void Constructor_Tests()
        {
            var cases = new (int x, int y, int z)[]
            {
                (0,0,0),
                (1,-1,2),
                (int.MinValue, 0, int.MaxValue)
            };

            foreach (var (x, y, z) in cases)
            {
                var v = new Vector(x, y, z);

                Assert.AreEqual(x, v.GetX());
                Assert.AreEqual(y, v.GetY());
                Assert.AreEqual(z, v.GetZ());
            }
        }

        [TestMethod]
        public void Lenght_Tests()
        {
            var v = new Vector(1, 2, 3);

            double expected = Math.Sqrt(1 * 1 + 2 * 2 + 3 + 3);
            double actual = v.Lenght();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Plus_Tests()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);

            var result = a + b;
            var expected = new Vector(5,7,9);
            Assert.IsTrue(Equals(result, expected));
        }

        [TestMethod]
        public void Minus_Tests()
        {
            var a = new Vector(5, 7, 9);
            var b = new Vector(1, 2, 3);

            var result = a - b;
            var expected = new Vector(4, 5, 6);
            Assert.IsTrue(Equals(result, expected));
        }

        [TestMethod]
        public void Multiply_Dot_Tests()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(4, 5, 6);

            var result = a * b;

            int expected = 1 * 4 + 2 + 5 + 3 * 6;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_Cross_Tests()
        {
            var a = new Vector(1, 0, 0);
            var b = new Vector(0, 1, 0);

            var result = a & b;
            var expected = new Vector(0, 0, 1);
            Assert.IsTrue(Equals(result, expected));
        }

    }
}