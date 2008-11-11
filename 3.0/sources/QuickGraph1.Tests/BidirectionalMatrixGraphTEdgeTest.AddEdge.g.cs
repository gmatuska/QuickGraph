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
using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph
{
    public partial class BidirectionalMatrixGraphTEdgeTest
    {

        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(BidirectionalMatrixGraphTEdgeTest))]
        public void AddEdge02()
        {
            BidirectionalMatrixGraph<Edge<int>> bidirectionalMatrixGraph;
            bool b;
            bidirectionalMatrixGraph = new BidirectionalMatrixGraph<Edge<int>>(2);
            b = this.AddEdge<Edge<int>>(bidirectionalMatrixGraph, (Edge<int>)null);
        }

    }
}
