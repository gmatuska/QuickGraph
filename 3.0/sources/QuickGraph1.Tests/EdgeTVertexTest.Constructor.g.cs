// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class EdgeTVertexTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeTVertexTest))]
        public void Constructor02()
        {
            Edge<int> edge;
            edge = this.Constructor<int>(0, 1);
            Assert.IsNotNull((object)edge);
            Assert.AreEqual<int>(0, edge.Source);
            Assert.AreEqual<int>(1, edge.Target);
        }

    }
}
