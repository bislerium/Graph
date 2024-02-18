using graph.Components;
using graph.Enums;
using graph.Model;

namespace graph.Contracts
{
    public abstract class DirectedGraph<S, T> : IGraph<S, T, DirectedMeta> where S : Edge<T, DirectedMeta>
    {
        public GraphType GraphType => GraphType.Directed;

        public abstract void AddEdge(S edge);
    }
}
