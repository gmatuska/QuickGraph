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
using Microsoft.Pex.Framework.Exceptions;
using System.Collections.Generic;

namespace QuickGraph
{
    public partial class BidirectionalGraphTVertexTEdgeTest
    {

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge03()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 3;
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, (Edge<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddEdge05()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 3;
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdge09()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(KeyNotFoundException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddEdge11()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            Edge<int> edge;
            bool b;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            edge = EdgeFactory.Create(0, 3);
            b = this.AddEdge<int, Edge<int>>(bidirectionalGraph, edge);
        }

    }
}
