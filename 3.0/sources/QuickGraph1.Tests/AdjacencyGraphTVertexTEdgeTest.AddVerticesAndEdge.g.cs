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
    public partial class AdjacencyGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge01()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge02()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false);
            edge = EdgeFactory.Create(0, 3);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge03()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph = AdjacencyGraphFactory.Create(false);
            edge = EdgeFactory.Create(15811584, 15811584);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(AdjacencyGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge04()
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph;
            Edge<int> edge;
            bool b;
            adjacencyGraph =
              AdjacencyGraphFactory.Create(PexSafeHelpers.ByteToBoolean((byte)128));
            edge = EdgeFactory.Create(0, 3);
            b = this.AddVerticesAndEdge<int, Edge<int>>(adjacencyGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

    }
}
