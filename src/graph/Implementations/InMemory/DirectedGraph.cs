using graph.Components;
using graph.Contracts;

namespace graph.Implementations.InMemory
{
    public class DirectedGraph<S, T, U, V> : Graph<S, T, U>, IGraph<S, T, U, V>
        where S : Edge<T, U, V>
        where T : Node<U>
        where V : DirectedMeta
    {

    }
    /// <summary>
    /// A Directed Graph that takes one generic types. Please see the type params for more information.
    /// </summary>
    /// <typeparam name="U">Type of data held by a Node</typeparam>
    public class DirectedGraph<U> : DirectedGraph<Edge<Node<U>, U, DirectedMeta>, Node<U>, U, DirectedMeta>, IDirectedGraph<U>;

    public class DirectedGraph<S, T, U, V, W> : DirectedGraph<S, T, U, V>, IDirectedGraph<S, T, U, V, W>
        where S : Edge<T, U, V>
        where T : Node<U>
        where V : DirectedMeta<W>
    {

    }

    /// <summary>
    /// A Directed Graph that takes two generic types. Please see the type params for more information.
    /// </summary>
    /// <typeparam name="U">Type of data held by a Node</typeparam>
    /// <typeparam name="W">Type of Metadata held by an Edge</typeparam>
    public class DirectedGraph<U, W> : DirectedGraph<Edge<Node<U>, U, DirectedMeta<W>>, Node<U>, U, DirectedMeta<W>, W>, IDirectedGraph<U, W>;
}
