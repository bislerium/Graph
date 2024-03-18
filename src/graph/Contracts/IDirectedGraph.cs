using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IDirectedGraph<S, T, U, V> : IGraph<S, T, U, V>
        where S : Edge<T, U, V>
        where T : Node<U>
        where V : DirectedMeta
    {
        GraphType IGraph<S, T, U>.GraphType => GraphType.Directed;
    }

    public interface IDirectedGraph<S, T, U, V, W> : IDirectedGraph<S, T, U, V>
        where S : Edge<T, U, V>
        where T : Node<U>
        where V : DirectedMeta<W>;

    public interface IDirectedGraph<U> : IGraph<U>, IDirectedGraph<Edge<Node<U>, U, DirectedMeta>, Node<U>, U, DirectedMeta>;

    public interface IDirectedGraph<U, W>: IGraph<U, DirectedMeta<W>>, IDirectedGraph<U>,  IDirectedGraph<Edge<Node<U>, U, DirectedMeta<W>>, Node<U>, U, DirectedMeta<W>, W>;
}
