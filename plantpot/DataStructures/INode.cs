namespace Coriander.DataStructures
{
    public interface INode<T>
    {
        /*
         * public T data;
         * public STATE state
         * public IN ode<T>[] adjacent;
         */

        public enum State
        {
            Unvisited = 0,
            Visited = 1,
            Visiting = 2
        }

        public void SetState(INode<T>.State newState);
        public INode<T>.State GetState();
        public T GetData();
        public INode<T>[] GetAdjacent();
    }
}