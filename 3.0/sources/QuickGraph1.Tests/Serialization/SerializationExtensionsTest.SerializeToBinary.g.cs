// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using QuickGraph;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Serialization
{
    public partial class SerializationExtensionsTest
    {
        [TestMethod]
        [PexRaisedException(typeof(ArgumentNullException))]
        [PexGeneratedBy(typeof(SerializationExtensionsTest))]
        public void SerializeToBinary01()
        {
            this.SerializeToBinary<int, Edge<int>>
                ((IGraph<int, Edge<int>>)null, (Stream)null);
        }

    }
}
