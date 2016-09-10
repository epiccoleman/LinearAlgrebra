using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static LinearAlgebra.Vector;

namespace LinearAlgebra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VectorHasXAndYValues()
        {
            Vector vec = new Vector();
            Assert.AreEqual(0, vec.x);
            Assert.AreEqual(0, vec.y);
        }
    }
}
