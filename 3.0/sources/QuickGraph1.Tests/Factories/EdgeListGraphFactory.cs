using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Factories;
using System;
using QuickGraph;

namespace QuickGraph
{
    [PexFactoryClass]
    public partial class EdgeListGraphFactory
    {
        [PexFactoryMethod(typeof(EdgeListGraph<int, Edge<int>>))]
        public static EdgeListGraph<int, Edge<int>> Create(bool isDirected, bool allowParralelEdges)
        {
            EdgeListGraph<int, Edge<int>> edgeListGraph
               = new EdgeListGraph<int, Edge<int>>(isDirected, allowParralelEdges);
            return edgeListGraph;
            // TODO: Edit factory method of EdgeListGraph`2<Int32,Edge`1<Int32>>
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }

    }
}
