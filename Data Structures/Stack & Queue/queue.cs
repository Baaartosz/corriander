/*
My implementation of a Queue Data Structure.
baaart.dev
*/

public class Queue<T>{

    private static class QueueNode<T>{
        private T data;
        private QueueNode<T> next;

        public QueueNode(T data){
            this.data = data;
        }
    }

    private QueueNode<T> head;
    private QueueNode<T> tail;

    public void Enqueue(T data){
        QueueNode<T> q = new QueueNode<T>(data);

        if(tail != null){
            tail.next = q;
        }
        tail = q;

        if(head == null){
            head = tail;
        }
    }

    public T Dequeue(){
        if(head == null) throw new NoSuchElementException();
        
        T data = head.data;
        head = head.next;
        
        if(head == null){
            tail = null;
        }

        return data;
    }

    public T Front(){
        if(head == null) throw new NoSuchElementException();
        return head.data;
    }

    public bool IsEmpty(){
        return head == null;
    }
}