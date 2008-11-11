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
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void Constructor0101()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            adjacencyGraph = this.Constructor01<int, Edge<int>>(false);
            Assert.IsNotNull((object)adjacencyGraph);
            Assert.AreEqual<bool>(true, adjacencyGraph.IsDirected);
            Assert.AreEqual<bool>(false, adjacencyGraph.AllowParallelEdges);
            Assert.AreEqual<int>(-1, adjacencyGraph.EdgeCapacity);
            Assert.AreEqual<bool>(true, adjacencyGraph.IsEdgesEmpty);
            Assert.AreEqual<int>(0, adjacencyGraph.EdgeCount);
        }

    }
}
