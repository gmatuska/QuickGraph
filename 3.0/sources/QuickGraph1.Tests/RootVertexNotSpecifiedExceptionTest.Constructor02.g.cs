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
    public partial class RootVertexNotSpecifiedExceptionTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(RootVertexNotSpecifiedExceptionTest))]
        public void Constructor0202()
        {
            RootVertexNotSpecifiedException rootVertexNotSpecifiedException;
            rootVertexNotSpecifiedException = this.Constructor02("", (Exception)null);
            Assert.IsNotNull((object)rootVertexNotSpecifiedException);
            Assert.IsNull(((Exception)rootVertexNotSpecifiedException).InnerException);
        }

    }
}
