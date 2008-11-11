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
        public void TryGetEdge01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false);
            Edge<int> edge = null;
            b = this.TryGetEdge<int, Edge<int>>(adjacencyGraph, 0, 2, out edge);
            Assert.AreEqual<bool>(false, b);
            Assert.IsNull((object)edge);
        }

    }
}
