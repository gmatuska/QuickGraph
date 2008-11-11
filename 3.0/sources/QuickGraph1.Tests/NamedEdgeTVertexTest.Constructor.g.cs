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
    public partial class NamedEdgeTVertexTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(NamedEdgeTVertexTest))]
        public void Constructor03()
        {
            NamedEdge<int> namedEdge;
            namedEdge = this.Constructor<int>(2, 3, "");
            Assert.IsNotNull((object)namedEdge);
            Assert.AreEqual<string>("", namedEdge.Name);
            Assert.AreEqual<int>(2, ((Edge<int>)namedEdge).Source);
            Assert.AreEqual<int>(3, ((Edge<int>)namedEdge).Target);
        }

    }
}
