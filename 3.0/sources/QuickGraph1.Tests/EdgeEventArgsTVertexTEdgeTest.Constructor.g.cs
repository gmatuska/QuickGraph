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

namespace QuickGraph
{
    public partial class EdgeEventArgsTVertexTEdgeTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeEventArgsTVertexTEdgeTest))]
        public void Constructor05()
        {
            EdgeEventArgs<int, Edge<int>> edgeEventArgs;
            edgeEventArgs = this.Constructor<int, Edge<int>>((Edge<int>)null);
            Assert.IsNotNull((object)edgeEventArgs);
            Assert.IsNull(edgeEventArgs.Edge);
        }

    }
}
