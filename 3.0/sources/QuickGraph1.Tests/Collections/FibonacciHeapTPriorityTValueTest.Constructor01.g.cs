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

namespace QuickGraph.Collections
{
    public partial class FibonacciHeapTPriorityTValueTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(FibonacciHeapTPriorityTValueTest))]
        public void Constructor0103()
        {
            FibonacciHeap<int, int> fibonacciHeap;
            fibonacciHeap = this.Constructor01<int, int>(HeapDirection.Increasing);
            Assert.IsNotNull((object)fibonacciHeap);
            Assert.AreEqual<HeapDirection>
                (HeapDirection.Increasing, fibonacciHeap.Direction);
            Assert.AreEqual<int>(0, fibonacciHeap.Count);
            Assert.IsNull(fibonacciHeap.Top);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(FibonacciHeapTPriorityTValueTest))]
        public void Constructor0104()
        {
            FibonacciHeap<int, int> fibonacciHeap;
            fibonacciHeap = this.Constructor01<int, int>(HeapDirection.Decreasing);
            Assert.IsNotNull((object)fibonacciHeap);
            Assert.AreEqual<HeapDirection>
                (HeapDirection.Decreasing, fibonacciHeap.Direction);
            Assert.AreEqual<int>(0, fibonacciHeap.Count);
            Assert.IsNull(fibonacciHeap.Top);
        }

    }
}
