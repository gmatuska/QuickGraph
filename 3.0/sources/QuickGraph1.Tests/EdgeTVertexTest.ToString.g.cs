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
    public partial class EdgeTVertexTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(EdgeTVertexTest))]
        public void ToString02()
        {
            Edge<int> edge;
            string s;
            edge = EdgeFactory.Create(0, 2);
            s = this.ToString<int>(edge);
            Assert.AreEqual<string>("0->2", s);
        }

    }
}
