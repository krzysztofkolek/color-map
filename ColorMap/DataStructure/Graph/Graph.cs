namespace ColorMap.DataStructure.Graph
{
    using System.Collections.Generic;

    public class Graph<T>
    {
        private List<Vertex<T>> _vertices { get; set; }
        private bool[][] _edges;

        public Graph()
        {

        }

        public Graph(bool[][] edges)
        {
            _edges = edges;
        }

        public Graph<T> Build()
        {

        }
    }
}
