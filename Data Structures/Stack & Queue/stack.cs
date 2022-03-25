/*
My implementation of a Stack Data Structure.
baaart.dev
*/

public class Stack<T> {

    private static class StackNode<T> {
        internal T data;
        internal StackNode<T> next;

        public StackNode(T data){
            this.data = data;
        }
    }

    private StackNode<T> top;

    public T Pop(){
        if(top == null) throw new EmptyStackException();
        
        T item = top.data;
        top = top.next;
        
        return item;
    }

    public void Push(T data){
        StackNode<T> t = new StackNode<T>(data);
        t.next = top;
        top = t;
    }

    public T peek(){
        if(top == null) throw new EmptyStackException();
        return top.data;
    }

    public bool IsEmpty(){
        return top == null;
    }
}