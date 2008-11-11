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
    public partial class UndirectedGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void Constructor02()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            undirectedGraph = this.Constructor<int, Edge<int>>();
            Assert.IsNotNull((object)undirectedGraph);
            Assert.AreEqual<int>(4, undirectedGraph.EdgeCapacity);
            Assert.AreEqual<bool>(false, undirectedGraph.IsDirected);
            Assert.AreEqual<bool>(true, undirectedGraph.AllowParallelEdges);
            Assert.AreEqual<int>(0, undirectedGraph.EdgeCount);
        }

    }
}
