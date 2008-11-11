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
    public partial class IdentifiableEdgeTVertexTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(IdentifiableEdgeTVertexTest))]
        public void Constructor03()
        {
            IdentifiableEdge<int> identifiableEdge;
            identifiableEdge = this.Constructor<int>(2, 3, "");
            Assert.IsNotNull((object)identifiableEdge);
            Assert.AreEqual<string>("", identifiableEdge.ID);
            Assert.AreEqual<int>(2, ((Edge<int>)identifiableEdge).Source);
            Assert.AreEqual<int>(3, ((Edge<int>)identifiableEdge).Target);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(IdentifiableEdgeTVertexTest))]
        public void Constructor04()
        {
            IdentifiableEdge<int> identifiableEdge;
            identifiableEdge = this.Constructor<int>(2, 3, "");
            Assert.IsNotNull((object)identifiableEdge);
            Assert.AreEqual<string>("", identifiableEdge.ID);
            Assert.AreEqual<int>(2, ((Edge<int>)identifiableEdge).Source);
            Assert.AreEqual<int>(3, ((Edge<int>)identifiableEdge).Target);
        }

    }
}
