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
    public partial class UndirectedGraphTVertexTEdgeTest
    {
        [TestMethod]
        [PexGeneratedBy(typeof(UndirectedGraphTVertexTEdgeTest))]
        public void VerticesGet01()
        {
            PexStore.Generated.Clear();
            UndirectedGraph<int, Edge<int>> undirectedGraph;
            undirectedGraph = new UndirectedGraph<int, Edge<int>>(false);
            undirectedGraph.EdgeCapacity = 0;
            this.VerticesGet<int, Edge<int>>(undirectedGraph);
            PexStore.Generated.Validate("result", "Count = 0");
        }

    }
}
