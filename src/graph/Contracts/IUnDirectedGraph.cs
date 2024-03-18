using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IUnDirectedGraph<S, T, U>: IGraph<S, T, U>
        where S : Edge<T, U>
        where T : Node<U>
    {
        GraphType IGraph<S, T, U>.GraphType => GraphType.UnDirected;
    }

    public interface IUnDirectedGraph<S, T, U, V> : IUnDirectedGraph<S, T, U>, IGraph<S, T, U, V> 
        where S : Edge<T, U, V>
        where T : Node<U>;

    public interface IUnDirectedGraph<U> : IGraph<U>, IUnDirectedGraph<Edge<Node<U>, U>, Node<U>, U>;

    public interface IUnDirectedGraph<U, V> : IGraph<U, V>, IUnDirectedGraph<U>, IUnDirectedGraph<Edge<Node<U>, U, V>, Node<U>, U, V>;
}
