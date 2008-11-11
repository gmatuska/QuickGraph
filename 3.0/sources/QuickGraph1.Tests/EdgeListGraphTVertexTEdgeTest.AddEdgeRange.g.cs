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
    public partial class EdgeListGraphTVertexTEdgeTest
    {

        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(EdgeListGraphTVertexTEdgeTest))]
        public void AddEdgeRange03()
        {
            EdgeListGraph<int, Edge<int>> edgeListGraph;
            edgeListGraph = EdgeListGraphFactory.Create(false, true);
            this.AddEdgeRange<int, Edge<int>>(edgeListGraph, (IEnumerable<Edge<int>>)null);
        }

    }
}
