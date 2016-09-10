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
    }
}
