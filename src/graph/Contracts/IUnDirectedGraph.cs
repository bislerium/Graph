using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IUnDirectedGraph<S, T, U>: IGraph<S, T, U>
        where S : Edge<T, U>
        where T : Node<U>
        where U : class
    {
        GraphType IGraph<S, T, U>.GraphType => GraphType.UnDirected;
    }

    public interface IUnDirectedGraph<S, T, U, V> : IUnDirectedGraph<S, T, U>, IGraph<S, T, U, V> 
        where S : Edge<T, U, V>
        where T : Node<U>
        where U : class
        where V : class;
}
