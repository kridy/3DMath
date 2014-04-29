using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3dMath.Test
{
    [TestClass]
    public class Vector2EqualityFixture
    {
        [TestMethod]
        public void VectorXEqualsVactorX()
        {
            var vectorX = new Vector2(1.0, 1.0);
            
            Assert.IsTrue(vectorX == vectorX);
            Assert.IsTrue(vectorX.Equals(vectorX));
            Assert.IsTrue(vectorX.Equals((object)vectorX));
        }

        [TestMethod]
        public void VectorXEqualsVectorY()
        {
            var vectorX = new Vector2(1.0, 1.0);
            var vectorY = new Vector2(1.0, 1.0);

            Assert.IsTrue(vectorX == vectorY);
            Assert.IsFalse(vectorX != vectorY);
            Assert.IsTrue(vectorX.Equals(vectorY));
            Assert.IsTrue(vectorX.Equals((object)vectorY));
        }

        [TestMethod]
        public void VectorXNotEqualsVectorY()
        {
            var vectorX = new Vector2(1.0, 1.0);
            var vectorY = new Vector2(2.0, 2.0);

            Assert.IsFalse(vectorX == vectorY);
            Assert.IsTrue(vectorX != vectorY);
            Assert.IsFalse(vectorX.Equals(vectorY));
            Assert.IsFalse(vectorX.Equals((object)vectorY));
        }

        [TestMethod]
        public void VectorXEqualsVectorYEqualsVectorZTransitiveEquality()
        {
            var vectorX = new Vector2(1.0, 1.0);
            var vectorY = new Vector2(1.0, 1.0);
            var vectorZ = new Vector2(1.0, 1.0);

            Assert.IsTrue(vectorX.Equals(vectorY));
            Assert.IsTrue(vectorY.Equals(vectorZ));
            Assert.IsTrue(vectorX.Equals(vectorZ));

            Assert.IsTrue(vectorX.Equals((object)vectorY));
            Assert.IsTrue(vectorY.Equals((object)vectorZ));
            Assert.IsTrue(vectorX.Equals((object)vectorZ));
        }

        [TestMethod]
        public void VectorXEqualsNull()
        {
            var vectorX = new Vector2(1.0, 1.0);
            Assert.IsFalse(vectorX.Equals(null));
        }
        

    }
}
