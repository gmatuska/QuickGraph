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
using System.Runtime.InteropServices;

namespace QuickGraph
{
    public partial class QuickGraphResourceManagerTest
    {

        [TestMethod]
        [PexRaisedException(typeof(ArgumentNullException))]
        [PexGeneratedBy(typeof(QuickGraphResourceManagerTest))]
        public void DumpResources03()
        {
            this.DumpResources((string)null);
        }

        [TestMethod]
        [Ignore]
        [Description("the test state was: path bounds exceeded")]
        public void DumpResources04()
        {
            this.DumpResources("");
        }

    }
}
