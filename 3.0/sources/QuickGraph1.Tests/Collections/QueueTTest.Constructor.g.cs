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
    public partial class QueueTTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(QueueTTest))]
        public void Constructor02()
        {
            Queue<int> queue;
            queue = this.Constructor<int>();
            Assert.IsNotNull((object)queue);
            Assert.AreEqual<int>(0, ((Queue<int>)queue).Count);
        }

    }
}
