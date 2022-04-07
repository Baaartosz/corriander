namespace Coriander.DataStructures
{
    /// <summary>
    /// Mutable array with automatic resizing)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IVector<T>
    {
        // Returns size of ArrayList
        public int Size();
        
        // Returns current capacity of ArrayList
        public int Capacity();
        
        public bool IsEmpty();
        
        // Returns data at given index;
        public T At(int index);
        
        // Adds item to the end of the array.
        public void Push(T data);
        
        // Inserts item in given index, shuffling down the one after
        public void Insert(int index, T data);
        
        // Adds item at the beginning of array
        public void Prepend(T data);
        
        // Removes item from back of ArrayList and return.
        public T Pop();
        
        // Deletes item from ArrayList and shuffles rest down.
        public void Delete(int index);
        
        // Removes all occurrences of data.
        public void Remove(T data);
        
        // Returns first occurrence of data;
        public T Find(T data);
        
        // Resizes array n*2 or 1/4 of n. n = capacity;
        protected void Resize(int newCapacity);
    }
}