using System;

namespace Coriander.DataStructures
{
    public class Queue<T> : IQueue<T>
    {

        public class QueueNode<T>
        {
            public T data;
            public QueueNode<T> next;

            public QueueNode(T data)
            {
                this.data = data;
            }
        }

        private QueueNode<T> head;
        private QueueNode<T> tail;

        public void Enqueue(T data)
        {
            QueueNode<T> q = new QueueNode<T>(data);

            if (tail != null)
            {
                tail.next = q;
            }

            tail = q;

            if (head == null)
            {
                head = tail;
            }
        }

        public T Dequeue()
        {
            if (head == null) throw new Exception("No Such Element Exception");

            T data = head.data;
            head = head.next;

            if (head == null)
            {
                tail = null;
            }

            return data;
        }

        public T Front()
        {
            if (head == null) throw new Exception("No Such Element Exception");
            return head.data;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}