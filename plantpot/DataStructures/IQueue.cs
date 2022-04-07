namespace Coriander.DataStructures
{
    public interface IQueue<T>
    {
        public void Enqueue(T data);
        public T Dequeue();
        public T Front();
        public bool IsEmpty();
    }
}