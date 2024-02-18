using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public abstract class UnDirectedGraph<S, T>: IGraph<S, T> where S : Edge<T>
    {
        public GraphType GraphType => GraphType.UnDirected;

        public abstract void AddEdge(S edge);
    }
    public abstract class UnDirectedGraph<T, U, V> : UnDirectedGraph<T, U>, IGraph<T, U, V> where T : Edge<U, V>
    {
    }
}
