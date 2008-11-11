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
        public void AddVertex01()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = int.MinValue;
            this.AddVertex<int, Edge<int>>(undirectedGraph, 2);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVertex02()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = 0;
            this.AddVertex<int, Edge<int>>(undirectedGraph, 2);
        }

    }
}
