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
    public partial class UndirectedGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexRaisedException(typeof(NullReferenceException))]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge01()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            bool b;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = 2;
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, (Edge<int>)null);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge02()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            Edge<int> edge;
            bool b;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = int.MinValue;
            edge = EdgeFactory.Create(3, 4);
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge03()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            Edge<int> edge;
            bool b;
            undirectedGraph =
              new UndirectedGraph<int, Edge<int>>(PexSafeHelpers.ByteToBoolean((byte)128));
            undirectedGraph.EdgeCapacity = int.MinValue;
            edge = EdgeFactory.Create(3, 4);
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge04()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            Edge<int> edge;
            bool b;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = int.MinValue;
            edge = EdgeFactory.Create(15811584, 15811584);
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge05()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            Edge<int> edge;
            bool b;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = 0;
            edge = EdgeFactory.Create(0, 0);
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge06()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            Edge<int> edge;
            bool b;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = 0;
            edge = EdgeFactory.Create(603979776, 25165824);
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void AddVerticesAndEdge07()
        {
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            Edge<int> edge;
            bool b;
            undirectedGraph =
              new UndirectedGraph<int, Edge<int>>(PexSafeHelpers.ByteToBoolean((byte)16));
            undirectedGraph.EdgeCapacity = 1;
            edge = EdgeFactory.Create(0, 0);
            b = this.AddVerticesAndEdge<int, Edge<int>>(undirectedGraph, edge);
            Assert.AreEqual<bool>(true, b);
        }

    }
}
