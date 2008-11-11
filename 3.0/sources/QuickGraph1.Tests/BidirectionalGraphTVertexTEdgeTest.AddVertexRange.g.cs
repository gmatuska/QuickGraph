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
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class BidirectionalGraphTVertexTEdgeTest
    {

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVertexRange03()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 3;
            this.AddVertexRange<int, Edge<int>>(bidirectionalGraph, (IEnumerable<int>)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVertexRange06()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 3;
            this.AddVertexRange<int, Edge<int>>(bidirectionalGraph, (IEnumerable<int>)null);
        }

        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddVertexRange07()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            this.AddVertexRange<int, Edge<int>>(bidirectionalGraph, (IEnumerable<int>)null);
        }

    }
}
