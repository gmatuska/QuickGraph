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
    public partial class EdgeListGraphTVertexTEdgeTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeListGraphTVertexTEdgeTest))]
        public void IsDirectedGet03()
        {
            PexStore.Generated.Clear();
            EdgeListGraph<int, Edge<int>> edgeListGraph;
            edgeListGraph = EdgeListGraphFactory.Create(false, true);
            this.IsDirectedGet<int, Edge<int>>(edgeListGraph);
            PexStore.Generated.Validate("result", "false");
        }

    }
}
