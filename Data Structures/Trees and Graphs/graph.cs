/*
My implementation of the Graph.

baaart.dev
*/

public class Graph<T>{
        public Node<T>[] nodes; 

        public Graph(Node<T>[] nodes){
            this.nodes = nodes;
        }

        public Node<T>[] getNodes(){
            return nodes;
        }
    }

public class Node<T>{
    public T data;
    public STATE state;
    public Node<T>[] adjacent;

    public enum STATE { Unvisited, Visited, Visiting }

    public Node(T data, Node<T>[] adjacents){
        state = STATE.Unvisited;
        this.data = data;
        this.adjacents = adjacents;
    }

    public Node<T>[] getAdjacent(){
        return children;
    }
}