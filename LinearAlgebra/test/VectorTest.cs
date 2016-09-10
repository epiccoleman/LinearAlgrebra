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
        }

        [TestMethod]
        public void VectorCanBeConstructedWithXAndYValues()
        {
            Vector vec = new Vector(1, 2);
            Assert.AreEqual(1, vec.x);
            Assert.AreEqual(2, vec.y);
        }

        [TestMethod]
        public void VectorsCanBeAdded()
        {
            Vector vec1 = new Vector(1, 2);
            Vector vec2 = new Vector(3, 4);

            Vector expectedVec = new Vector(4, 6);
            Vector actualVec = vec1 + vec2;

            Assert.AreEqual(expectedVec.x, actualVec.x);
            Assert.AreEqual(expectedVec.y, actualVec.y);
        }

        [TestMethod]
        public void VectorsCanBeComparedForEquality()
        {
            Vector vec1 = new Vector(1, 1);
            Vector vec2 = new Vector(1, 1);

            Assert.IsTrue(vec1 == vec2);
            Assert.AreEqual(vec1, vec2);
        }

        [TestMethod]
        public void VectorsCanBeComparedForInequality()
        {
            Vector vec1 = new Vector(1, 1);
            Vector vec2 = new Vector(1, 2);

            Assert.IsTrue(vec1 != vec2);
            Assert.AreNotEqual(vec1, vec2);
        }
    }
}
