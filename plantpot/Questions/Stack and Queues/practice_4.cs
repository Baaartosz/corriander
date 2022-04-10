using Coriander.DataStructures;
using Coriander.DataStructures.Collection;

namespace Coriander.Questions.Stack_and_Queues;

/*
 * Queue Via Stacks
 *
 * Implement a MyQueue class which implements a queue using two stacks.
 */

public class practice_4
{
    public class MyQueue<T> : IQueue<T>
    {
        private MyStack<T> _primary;
        private MyStack<T> _temp;
        private T _front;
        private int _items;

        public MyQueue()
        {
            _primary = new MyStack<T>();
            _temp = new MyStack<T>();
            _items = 0;
        }

        public void Enqueue(T data)
        {
            _primary.Push(data);
            _items++;
            if (_items == 1) _front = data;
        }

        public T Dequeue()
        {
            while (!_primary.IsEmpty())
            {
                if (_items == 1) break;
                _temp.Push(_primary.Pop());
                _items--;
                
            }
            
            T oldestItem = _primary.Pop();
            _front = default;
            _items--;
            
            while (!_temp.IsEmpty())
            {
                Enqueue(_temp.Pop());
            }
            
            return oldestItem;
        }

        public T Front() => _front;

        public bool IsEmpty() => _primary.IsEmpty();

        public static void Test()
        {
            Console.WriteLine("Stacks and Queues Q4");

            var q = new practice_4.MyQueue<int>();

            Console.WriteLine("ENQUEUE");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ", ");
                q.Enqueue(i);
            }

            Console.WriteLine("\nDEQUEUE");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(q.Dequeue() + " ,");
            }
        }
    }
}