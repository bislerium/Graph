using graph.Components;
using graph.Contracts;
using graph.Enums;
using System.Xml.Linq;

namespace graph.Implementations.InMemory
{
    public class Graph<S, T, U> : IGraph<S, T, U>
        where S : Edge<T, U>
        where T : Node<U>
    {
        private readonly Dictionary<T, List<S>> _adjacencyList = new();

        public GraphType GraphType { get; set; }

        public void AddEdge(S edge)
        {
            AddNode(edge.Src);
            AddNode(edge.Dest);

            if (_adjacencyList.TryGetValue(edge.Src, out var listSrc))
            {
                listSrc.Add(edge);
            }
            else
            {
                _adjacencyList[edge.Src] = [edge];
            }

            if(_adjacencyList.TryGetValue(edge.Dest, out var listDest))
            {
                listDest.Add(edge);
            }
            else
            {
                _adjacencyList[edge.Dest] = [edge];
            }
        }

        public void AddNode(T node)
        {
            if (!_adjacencyList.ContainsKey(node))
            {
                _adjacencyList[node] = [];
            }
        }

        public bool TryAddNode(T node, out List<S>? list)
        {
            bool exist = _adjacencyList.TryGetValue(node, out list);
            if (!exist)
            {
                AddNode
            }
        }

        public bool ContainsNode(T node)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<S> GetEdgeNeighbors(T node)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetNodeNeighbors(T node)
        {
            throw new NotImplementedException();
        }
    }
}
