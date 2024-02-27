using graph.Enums;

namespace graph.Components
{
    public class DirectedMeta
    {
        public EdgeDirectionType EdgeDirectionType { get; set; }
    }

    public class DirectedMeta<T> : DirectedMeta
    {
        public T? Value { get; set; }
    }
}
