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
    public partial class NotStronglyConnectedGraphExceptionTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(NotStronglyConnectedGraphExceptionTest))]
        public void Constructor0102()
        {
            NotStronglyConnectedGraphException notStronglyConnectedGraphException;
            notStronglyConnectedGraphException = this.Constructor01((string)null);
            Assert.IsNotNull((object)notStronglyConnectedGraphException);
            Assert.IsNull(((Exception)notStronglyConnectedGraphException).InnerException);
        }

    }
}
