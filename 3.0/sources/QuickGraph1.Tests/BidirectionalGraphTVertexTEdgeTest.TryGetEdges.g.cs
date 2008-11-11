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
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void TryGetEdges01()
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bool b;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            IEnumerable<Edge<int>> iEnumerable = null;
            b = this.TryGetEdges<int, Edge<int>>(bidirectionalGraph, 0, 2, out iEnumerable);
            Assert.AreEqual<bool>(false, b);
            Assert.IsNull((object)iEnumerable);
        }

    }
}
