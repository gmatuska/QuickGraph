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
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVertex02()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 2;
            this.AddVertex<int, Edge<int>>(bidirectionalGraph, 3);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void AddVertex05()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = new BidirectionalGraph<int, Edge<int>>(false, 1073741824);
            bidirectionalGraph.EdgeCapacity = 2;
            this.AddVertex<int, Edge<int>>(bidirectionalGraph, 3);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void AddVertex06()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            this.AddVertex<int, Edge<int>>(bidirectionalGraph, 0);
        }

    }
}
