using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Factories;
using System;
using QuickGraph;

namespace QuickGraph
{
    [PexFactoryClass]
    public partial class BidirectionalGraphFactory
    {
        [PexFactoryMethod(typeof(BidirectionalGraph<int, Edge<int>>))]
        public static BidirectionalGraph<int, Edge<int>> Create(bool allowParralelEdges)
        {
            BidirectionalGraph<int, Edge<int>> bidirectionalGraph
               = new BidirectionalGraph<int, Edge<int>>();
            return bidirectionalGraph;
            // TODO: Edit factory method of BidirectionalGraph`2<Int32,Edge`1<Int32>>
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }

    }
}
