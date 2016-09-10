using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static LinearAlgebra.Vector;

namespace LinearAlgebra
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void VectorHasXAndYValues()
        {
            Vector vec = new Vector();
            Assert.AreEqual(0, vec.x);
            Assert.AreEqual(0, vec.y);
            Assert.AreEqual(0, vec.z);
        }

        [TestMethod]
        public void VectorCanBeConstructedWithXYZValues()
        {
            Vector vec = new Vector(1, 2, 3);
            Assert.AreEqual(1, vec.x);
            Assert.AreEqual(2, vec.y);
            Assert.AreEqual(3, vec.z);
        }

        [TestMethod]
        public void VectorsCanBeComparedForEquality()
        {
            Vector vec1 = new Vector(1, 1, 1);
            Vector vec2 = new Vector(1, 1, 1);

            Assert.IsTrue(vec1 == vec2);
            Assert.AreEqual(vec1, vec2);
        }

        [TestMethod]
        public void VectorsCanBeComparedForInequality()
        {
            Vector vec1 = new Vector(1, 1, 1);
            Vector vec2 = new Vector(1, 2, 3);

            Assert.IsTrue(vec1 != vec2);
            Assert.AreNotEqual(vec1, vec2);
        }

        [TestMethod]
        public void VectorsCanBeAdded()
        {
            Vector vec1 = new Vector(1, 2, 3);
            Vector vec2 = new Vector(4, 5, 6);

            Vector expectedVec = new Vector(5, 7, 9);
            Vector actualVec = vec1 + vec2;

            Assert.AreEqual(expectedVec, actualVec);
        }
    }
}
