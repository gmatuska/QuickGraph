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
using System.Collections.Generic;

namespace QuickGraph.Collections
{
    public partial class VertexListTVertexTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(VertexListTVertexTest))]
        public void Constructor04()
        {
            VertexList<int> vertexList;
            vertexList = this.Constructor<int>();
            Assert.IsNotNull((object)vertexList);
            Assert.AreEqual<int>(0, ((List<int>)vertexList).Capacity);
            Assert.AreEqual<int>(0, ((List<int>)vertexList).Count);
        }

    }
}
