// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework.Exceptions;

namespace QuickGraph.Predicates
{
    public partial class InDictionaryVertexPredicateTVertexTValueTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(InDictionaryVertexPredicateTVertexTValueTest))]
        public void Constructor02()
        {
            InDictionaryVertexPredicate<int, int> inDictionaryVertexPredicate;
            inDictionaryVertexPredicate =
              this.Constructor<int, int>((IDictionary<int, int>)null);
            Assert.IsNotNull((object)inDictionaryVertexPredicate);
        }

    }
}
