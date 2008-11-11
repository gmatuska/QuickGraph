// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class UndirectedGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddEdgeRange01()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = 2;
            this.AddEdgeRange<int, Edge<int>>(undirectedGraph, (IEnumerable<Edge<int>>)null);
        }

    }
}
