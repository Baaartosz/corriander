namespace Coriander.DataStructures.Collection
{
    public class Vector<T> : IVector<T>
    {
        private const int _startCapacity = 4;
        private int _items, _capacity;
        public T?[] _array;

        // Default Capacity
        public Vector()
        {
            _items = 0;
            _capacity = _startCapacity;
            _array = new T?[_capacity];
        }
        
        // Custom Capacity
        public Vector(int capacity)
        {
            _items = 0;
            _capacity = capacity;
            _array = new T?[_capacity];
        }

        public int Size() => _items;

        public int Capacity() => _capacity;

        public bool IsEmpty() => _items == 0;

        // Returns data from Index
        public T At(int index) => _array[index];

        public void Push(T? data)
        {
            if (Size() == Capacity()) Resize(Capacity() * 2);
            _array[_items] = data; // possible function SetAt(index, data)
            _items++;
        }

        public void Insert(int index, T data)
        {
            // BUG - Test function, possible logic error.
            if (Size() == Capacity()) Resize(Capacity() * 2);
            var newValue = data;
            for(int p = index; p < Capacity(); p++){ // O(n)
                // Swap by Deconstruction [new technique]
                (_array[p], newValue) = (newValue, _array[p]);
            }
            _items++;
        }

        public void Prepend(T data)
        {
            Insert(0, data);
        }

        public T Pop()
        {
            var tmp = _array[Size()];
            _array[Size()] = default;
            _items--;
            if (Size() < (Capacity() / 4))
            {
                Resize(Capacity()/2);
            }
            return tmp;
        }

        public void Delete(int index)
        {
            _array[index] = default;
            _items--;
            for(int p = index + 1; p < Capacity(); p++){ // O(n)
                var tmp = _array[p];
                _array[p-1] = tmp;
                _array[p] = default;
            }
        }

        public void Remove(T data)
        {
            int removed = 0;
            for(int i = 0; i < Capacity(); i++){ // O(n)
                if (_array != null && _array[i]!.Equals(data))
                {
                    _array[i] = default;
                    removed++;
                }
                else if (_array != null && removed > 0)
                {
                    var tmp = _array[i];
                    _array[i] = default;
                    _array[i - removed] = tmp;
                }
            }
        }

        public T? Find(T data)
        {
            for(int i = 0; i < Capacity(); i++){ // O(n)
                if (_array != null && _array[i]!.Equals(data))
                {
                    return _array[i];
                }
            }
            return default;
        }
        
        // Resizes array n*2 ( TODO - decrease size  1/4 of n. n = capacity; )
        private void Resize(int newCapacity)
        {
            var tmp = _array;
            _array = new T[newCapacity];
            for (int i = 0; i < tmp.Length; i++)
            {
                _array[i] = tmp[i];
            }
        }
    }
}