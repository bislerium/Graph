using graph.Components;
using graph.Contracts;
using graph.Enums;

namespace graph.Implementations
{
    public class Graph<T> : IGraph<T> where T : IEdgeBase<T>
    {
        private readonly IDictionary<Node<T>, T> _graph;

        private readonly ISet<Node<T>> _nodes; 

        public GraphType GraphType => throw new NotImplementedException();

        public void AddEdge(T edge)
        {
            
        }
    }
}
