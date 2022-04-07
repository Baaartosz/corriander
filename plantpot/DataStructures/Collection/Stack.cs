using System;

namespace Coriander.DataStructures.Collection
{
    public class Stack<T> : IStack<T> {

        internal class StackNode<T> {
            internal T data;
            internal StackNode<T> next;

            public StackNode(T data){
                this.data = data;
            }
        }

        private StackNode<T> top;

        public T Pop()
        {
            if (top == null) throw new Exception("Empty Stack Exception");
        
            T item = top.data;
            top = top.next;
        
            return item;
        }

        public void Push(T data){
            StackNode<T> t = new StackNode<T>(data);
            t.next = top;
            top = t;
        }

        public T Peek(){
            if(top == null) throw new Exception("Empty Stack Exception");
            return top.data;
        }

        public bool IsEmpty(){
            return top == null;
        }  
    }
}