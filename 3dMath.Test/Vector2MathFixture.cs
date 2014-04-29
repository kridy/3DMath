using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3dMath.Test
{
    [TestClass]
    public class Vector2MathFixture
    {
        [TestMethod]
        public void TestAddTwoVectors()
        {
            var vRes = new Vector2(2.0, 2.0);
            var vP = new Vector2(1.0, 1.0);
            var vQ = new Vector2(1.0, 1.0);
            var vZ = new Vector2(1.0, 2.0);

            Assert.IsTrue(vRes == vP.Add(vQ));
            Assert.IsTrue(vRes == vP + vQ);
            Assert.IsFalse(vRes == vZ + vQ);
        }

        [TestMethod]
        public void TestSubtractTwoVectors()
        {
            var vRes = new Vector2(1.0, 1.0);
            var vP = new Vector2(2.0, 2.0);
            var vQ = new Vector2(1.0, 1.0);

            Assert.IsTrue(vRes == vP.Subtract(vQ));
            Assert.IsTrue(vRes == (vP - vQ));
        }

        [TestMethod]
        public void TestMultiplyScalarOntoVector()
        {
            var vRes = new Vector2(6.0, 6.0);
            var vP = new Vector2(2.0, 2.0);
            var scalar = 3;

            Assert.IsTrue(vRes == vP.Multiply(scalar));
            Assert.IsTrue(vRes == vP * scalar);
            Assert.IsTrue(vRes == scalar * vP);
        }

        [TestMethod]
        public void TestCommutativeProperties()
        {
            var vP = new Vector2(1.0, 1.0);
            var vQ = new Vector2(1.0, 1.0);

            Assert.IsTrue((vP + vQ) == (vQ + vP));
        }

        [TestMethod]
        public void TestAssociativePropperties()
        {
            var vP = new Vector2(1.0, 1.0);
            var vQ = new Vector2(1.0, 1.0);
            var vR = new Vector2(1.0, 1.0);
           
            Assert.IsTrue(vP + (vQ + vR) == (vP + vQ) + vR);
        }

        [TestMethod]
        public void TestDistributivePropperties()
        {
            var vP = new Vector2(1.0, 1.0);
            var vQ = new Vector2(2.0, 2.0);
            var a = 2;
            var b = 3;

            Assert.IsTrue((a * b) * vP == a * (b * vP));
            Assert.IsTrue(a * (vP + vQ) == (a * vP) + (a * vQ));
            Assert.IsTrue((a + b) * vP == (a * vP) + (b * vP));
        }

        [TestMethod]
        public void TestGetVectorNorm()
        {
            var a = -1.0;
            var b = 2.0;

            var zeroVector = new Vector2(0, 0);
            var vP = new Vector2(a, b);
            var vQ = new Vector2(b, a);

            var expectedNorm = Math.Sqrt((a * a) + (b * b));

            Assert.IsTrue(expectedNorm.Equals(vP.Magnitude));
            Assert.IsTrue(expectedNorm.Equals(vQ.Magnitude));
            Assert.IsTrue(zeroVector.Magnitude.Equals(0));

            Assert.IsTrue((a*vP).Magnitude.Equals(Math.Abs(a) * vP.Magnitude)); // |aP| = |a||P|
            Assert.IsTrue((vP + vQ).Magnitude <= vP.Magnitude + vQ.Magnitude);  // |P+Q|<=|P|+|Q|
        }

        [TestMethod]
        public void TestNormalization()
        {
            var a = -1.0;
            var b = 2.0;

            var an = 1/a;
            var bn = 1 /b;

            var expectedNorm = Math.Sqrt((an * an) + (bn * bn));
            var vactor = new Vector2(a, b).Normalized;
        }
    }

}
