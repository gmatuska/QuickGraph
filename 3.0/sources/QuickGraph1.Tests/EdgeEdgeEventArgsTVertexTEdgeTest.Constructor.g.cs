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
    public partial class EdgeEdgeEventArgsTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(EdgeEdgeEventArgsTVertexTEdgeTest))]
        public void Constructor01()
        {
            EdgeEdgeEventArgs<int, Edge<int>> edgeEdgeEventArgs;
            edgeEdgeEventArgs =
              this.Constructor<int, Edge<int>>((Edge<int>)null, (Edge<int>)null);
            Assert.IsNotNull((object)edgeEdgeEventArgs);
            Assert.IsNull(edgeEdgeEventArgs.TargetEdge);
            Assert.IsNull(((EdgeEventArgs<int, Edge<int>>)edgeEdgeEventArgs).Edge);
        }

    }
}
