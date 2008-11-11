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
    public partial class ReversedEdgeTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(ReversedEdgeTVertexTEdgeTest))]
        public void Constructor01()
        {
            ReversedEdge<int, Edge<int>> reversedEdge;
            reversedEdge = this.Constructor<int, Edge<int>>((Edge<int>)null);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(ReversedEdgeTVertexTEdgeTest))]
        public void Constructor02()
        {
            Edge<int> edge;
            ReversedEdge<int, Edge<int>> reversedEdge;
            edge = EdgeFactory.Create(0, 2);
            reversedEdge = this.Constructor<int, Edge<int>>(edge);
            Assert.IsNotNull((object)reversedEdge);
            Assert.IsNotNull(reversedEdge.OriginalEdge);
            Assert.AreEqual<int>(0, reversedEdge.OriginalEdge.Source);
            Assert.AreEqual<int>(2, reversedEdge.OriginalEdge.Target);
        }

    }
}
