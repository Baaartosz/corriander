namespace Coriander.DataStructures
{
    public interface IStack<T>
    {
        public T Pop();
        public void Push(T data);
        public T Peek();
        public bool IsEmpty();
    }
}