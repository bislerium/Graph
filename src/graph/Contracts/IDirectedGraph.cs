using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IDirectedGraph<S, T, U, V> : IGraph<S, T, U, V>
        where S : Edge<T, U, V>
        where T : Node<U>
        where U : class
        where V : DirectedMeta
    {
        GraphType IGraph<S, T, U>.GraphType => GraphType.Directed;
    }

    public interface IDirectedGraph<S, T, U, V, W> : IDirectedGraph<S, T, U, V>
        where S : Edge<T, U, V>
        where T : Node<U>
        where U : class
        where V : DirectedMeta<W>
        where W : class;
}
