namespace ColorMap.DataStructure.Graph
{
    using System.Collections.Generic;

    public class Vertex<T>
    {
        public T Data;
        public LinkedList<Edge<T>> Neighbors { get; set; }

        public Vertex()
        {
            Neighbors = new LinkedList<Edge<T>>();
        }

        public Vertex(T input)
        {
            Data = input;
            Neighbors = new LinkedList<Edge<T>>();
        }


        public Vertex(T input, LinkedList<Edge<T>> neighbors)
        {
            Data = input;
            Neighbors = neighbors;
        }
    }
}
