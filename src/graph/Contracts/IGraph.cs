using graph.Components;
using graph.Enums;

namespace graph.Contracts
{
    public interface IGraph<S, T> where S : Edge<T>
    {
        GraphType GraphType { get; }

        void AddEdge(S edge);
    }

    public interface IGraph<S, T, U>: IGraph<S, T> where S : Edge<T, U>
    {
    }
}
