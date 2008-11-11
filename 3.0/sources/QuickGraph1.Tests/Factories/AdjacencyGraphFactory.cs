using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Factories;
using System;
using QuickGraph;

namespace QuickGraph
{
    [PexFactoryClass]
    public partial class AdjacencyGraphFactory
    {
        [PexFactoryMethod(typeof(AdjacencyGraph<int, Edge<int>>))]
        public static AdjacencyGraph<int, Edge<int>> Create(bool directed)
        {
            AdjacencyGraph<int, Edge<int>> adjacencyGraph
               = new AdjacencyGraph<int, Edge<int>>(directed);
            return adjacencyGraph;
            // TODO: Edit factory method of AdjacencyGraph`2<Int32,Edge`1<Int32>>
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }

    }
}
