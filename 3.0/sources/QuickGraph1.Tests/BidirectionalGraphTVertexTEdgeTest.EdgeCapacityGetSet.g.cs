// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class BidirectionalGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(BidirectionalGraphTVertexTEdgeTest))]
        public void EdgeCapacityGetSet01()
        {
            PexStore.Generated.Clear();
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph;
            bidirectionalGraph = BidirectionalGraphFactory.Create(false);
            this.EdgeCapacityGetSet<int, Edge<int>>(bidirectionalGraph, 0);
            PexStore.Generated.Validate("result", "0");
        }

    }
}
