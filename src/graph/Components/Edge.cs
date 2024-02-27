namespace graph.Components
{

    // Just an Edge
    public record Edge<T, U>(T Src, T Dest) where T : Node<U>;

    // An Edge with Optional Metadata
    public record Edge<T, U, V>(T Src, T Dest, V? Meta): Edge<T, U>(Src, Dest) where T : Node<U>;
}
