namespace Coriander.DataStructures.Collection
{
    public class Node<T> : INode<T>
    {
        private T _data;
        private INode<T>[] _adjacentNodes;
        private INode<T>.State _state = INode<T>.State.Unvisited;

        public Node( T data, INode<T>[] adjacentNodes)
        {
            _adjacentNodes = adjacentNodes;
            _data = data;
        }

        public void SetState(INode<T>.State newState)
        {
            _state = newState;
        }

        public INode<T>.State GetState()
        {
            return _state;
        }

        public T GetData()
        {
            return _data;
        }

        public INode<T>[] GetAdjacent()
        {
            return _adjacentNodes;
        }
    }
}