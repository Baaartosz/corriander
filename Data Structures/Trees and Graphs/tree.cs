public interface ITree<T> {
    public Node<T> root;

    public void Insert(T data);
    public Node<T> Search(T data);
}

public class Tree : ITree<T> {
    public Node root;
}

public class Node<T>{
    public T data;
    public Node leftChild;
    public Node rightChild;
}
