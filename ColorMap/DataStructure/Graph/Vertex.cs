namespace ColorMap.DataStructure.Graph
{
    using System.Collections.Generic;

    public class Vertex<T>
    {
        private T data;
        private LinkedList<Vertex<T>> neighbors;
    }
}
