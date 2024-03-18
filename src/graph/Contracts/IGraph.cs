using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IGraph<S, T, U>
        where S : Edge<T, U>
        where T : Node<U>

    {
        GraphType GraphType { get; }

        void AddNode(T node);

        void AddEdge(S edge);

        IEnumerable<T> GetNodeNeighbors(T node);

        IEnumerable<S> GetEdgeNeighbors(T node);

        bool ContainsNode(T node);
    }

    public interface IGraph<U> : IGraph<Edge<Node<U>, U>, Node<U>, U>;

    public interface IGraph<S, T, U, V>: IGraph<S, T, U> 
        where S : Edge<T, U, V>
        where T : Node<U>;

    public interface IGraph<U, V> : IGraph<U>, IGraph<Edge<Node<U>, U, V>, Node<U>, U, V>;
}
