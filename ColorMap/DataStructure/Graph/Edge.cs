namespace ColorMap.DataStructure.Graph
{

    public class Edge<T>
    {
        public Vertex<T> Node1 { get; set; }
        public Vertex<T> Node2 { get; set; }

        public Edge()
        {
            Node1 = new Vertex<T>();
            Node2 = new Vertex<T>();
        }
    }
}
