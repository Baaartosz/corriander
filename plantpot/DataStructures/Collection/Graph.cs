namespace Coriander.DataStructures
{
    public class Graph<T> : IGraph<T>
    {
        private INode<T>[] _nodes;

        public Graph(INode<T>[] nodes)
        {
            _nodes = nodes;
        }

        public INode<T>[] GetNodes()
        {
            return _nodes;
        }
    }
}