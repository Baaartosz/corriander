/*
Stack Min

How could you design a Stack which, In addition to push() and pop() has a function min()
which returns the minimum element?

push(), pop() and min() should all operate at O(1) time.

baart.dev
*/


public class Stack {
    private class StackNode {
        internal int data;
        internal StackNode next;
        internal int subStackMin; // Keep track of sub-stack's minimum

        public StackNode(int data){
            this.data = data;
        }
    }

    private StackNode top = null;

    public int Pop(){
        if(top == null) throw new EmptyStackException();
        
        int item = top.data;
        top = top.next;
        
        return item;
    }

    public void Push(int data){
        StackNode t = new StackNode(data);
        t.next = top;
        if(top.subStackMin == null) {
            t.subStackMin = data;
        } else {
            if(top.subStackMin > data){
               t.subStackMin = data;     
            } else {
                t.subStackMin = top.subStackMin;
            }
        }
        top = t;
    }

    public int Peek(){
        if(top == null) throw new EmptyStackException();
        return top.data;
    }

    public int Min(){
        return top.subStackMin;
    }

    public bool IsEmpty(){
        return top == null;
    }
}