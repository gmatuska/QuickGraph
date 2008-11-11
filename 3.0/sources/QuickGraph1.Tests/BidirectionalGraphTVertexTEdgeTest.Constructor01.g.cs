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
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void Constructor0101()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = this.Constructor01<int, Edge<int>>(false);
            Assert.IsNotNull((object)bidirectionalGraph);
            Assert.AreEqual<int>(-1, bidirectionalGraph.EdgeCapacity);
            Assert.AreEqual<bool>(true, bidirectionalGraph.IsDirected);
            Assert.AreEqual<bool>(false, bidirectionalGraph.AllowParallelEdges);
            Assert.AreEqual<bool>(true, bidirectionalGraph.IsEdgesEmpty);
            Assert.AreEqual<int>(0, bidirectionalGraph.EdgeCount);
        }

    }
}
