namespace Coriander.DataStructures
{
    public interface IGraph<T>
    {
        public INode<T>[] GetNodes();
    }

    public class Graph<T> : IGraph<T>
    {
        private INode<T>[] _nodes;

        public Graph(INode<T>[] nodes)
        {
            _nodes = nodes;
        }

        public INode<T>[] GetNodes()
        {
            throw new System.NotImplementedException();
        }
    }
    
    public interface INode<T>
    {
        /*
         * public T data;
         * public STATE state
         * public INode<T>[] adjacent;
         */
        
        public enum STATE { Unvisited, Visited, Visiting }

        public INode<T>[] GetAdjacent();
    }

    public class Node<T> : INode<T>
    {
        private INode<T>[] _adjacentNodes;

        public Node(INode<T>[] adjacentNodes)
        {
            _adjacentNodes = adjacentNodes;
        }

        public INode<T>[] GetAdjacent()
        {
            throw new System.NotImplementedException();
        }
    }
}