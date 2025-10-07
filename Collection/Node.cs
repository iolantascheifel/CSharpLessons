namespace Collection;

public class Node<T>
{
    public Node<T>? Next { get; set; }
    public required T Data { get; set; }
}