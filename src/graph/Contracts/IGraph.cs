using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IGraph<S, T, U>
        where S : Edge<T, U>
        where T : Node<U>
        where U : class

    {
        GraphType GraphType { get; }

        void AddNode(T node);

        void AddEdge(S edge);

        IEnumerable<T> GetNodeNeighbors(T node);

        IEnumerable<S> GetEdgeNeighbors(T node);

        bool ContainsNode(T node);
    }

    public interface IGraph<S, T, U, V>: IGraph<S, T, U> 
        where S : Edge<T, U, V>
        where T : Node<U>
        where U : class
        where V : class;
}
