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
        public void VertexTypeGet01()
        {
            PexStore.Generated.Clear();
            this.VertexTypeGet<int, Edge<int>>();
            PexStore.Generated.Validate("result", "System.Int32");
        }

    }
}
