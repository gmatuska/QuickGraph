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
    public partial class TaggedEdgeTVertexTTagTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(TaggedEdgeTVertexTTagTest))]
        public void Constructor02()
        {
            TaggedEdge<int, int> taggedEdge;
            taggedEdge = this.Constructor<int, int>(0, 1, 2);
            Assert.IsNotNull((object)taggedEdge);
            Assert.AreEqual<int>(2, taggedEdge.Tag);
            Assert.AreEqual<int>(0, ((Edge<int>)taggedEdge).Source);
            Assert.AreEqual<int>(1, ((Edge<int>)taggedEdge).Target);
        }

    }
}
