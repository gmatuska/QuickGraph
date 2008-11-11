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
using System.Collections.Generic;

namespace QuickGraph
{
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(KeyNotFoundException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void InEdges01()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            this.InEdges<int, Edge<int>>(bidirectionalGraph, 0);
        }

        [TestMethod]
        [PexRaisedException(typeof(KeyNotFoundException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void InEdge01()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            this.InEdge<int, Edge<int>>(bidirectionalGraph, 0, 2);
        }

    }
}
