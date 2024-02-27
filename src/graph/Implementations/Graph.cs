using graph.Components;
using graph.Contracts;
using graph.Enums;

namespace graph.Implementations
{
    /*public class Graph<T> : IGraph<T> where T : IEdgeBase<T>
    {
        private readonly IDictionary<Node<T>, T> _graph;

        private readonly ISet<Node<T>> _nodes; 

        public GraphType GraphType => throw new NotImplementedException();

        public void AddEdge(T edge)
        {
            
        }
    }*/

    public class Graph<S, T, U> : IDirectedGraph<S, T, U>
        where S : Edge<T, U, DirectedMeta>
        where T : Node<U>
        where U : class
    {
        public void AddEdge(S edge)
        {
            throw new NotImplementedException();
        }

        public void AddNode(T node)
        {
            throw new NotImplementedException();
        }

        public bool ContainsNode(T node)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<S> GetEdgeNeighbors(T node)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetNodeNeighbors(T node)
        {
            throw new NotImplementedException();
        }
    }
}
