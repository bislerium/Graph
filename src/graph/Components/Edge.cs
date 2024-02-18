namespace graph.Components
{

    // Just an Edge
    public record Edge<T>(Node<T> Src, Node<T> Dest);

    // An Edge with Optional Metadata
    public record Edge<T, U>(Node<T> Src, Node<T> Dest, U? Meta): Edge<T>(Src, Dest);
}
