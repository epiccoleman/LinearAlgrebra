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
        public void IdenticalVectorsAreEqual()
        {
            Vector vec1 = new Vector(1, 1, 1);
            Vector vec2 = new Vector(1, 1, 1);

            Assert.IsTrue(vec1 == vec2);
            Assert.AreEqual(vec1, vec2);
        }

        [TestMethod]
        public void DifferentVectorsAreNotEqual()
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

        [TestMethod]
        public void VectorsCanBeSubtracted()
        {
            Vector vec1 = new Vector(4, 5, 6);
            Vector vec2 = new Vector(1, 2, 3);


            Vector expectedVec = new Vector(3, 3, 3);
            Vector actualVec = vec1 - vec2;

            Assert.AreEqual(expectedVec, actualVec);
        }

        [TestMethod]
        public void VectorsCanBeRepresentedAsAString()
        {
            Vector vec = new Vector(4, 2, 0);
            Assert.AreEqual("vec: x:4.000 y:2.000 z:0.000", vec.ToString()); 
        }
    }
}
