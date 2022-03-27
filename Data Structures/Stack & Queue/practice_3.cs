/*
Stack of Plates

Imagine a (literal) stack of plates. If the stack gets too high, it might topple. 
Thereforem in real-life, we would likely start a new stack when the previous stack 
exceeds some threshold.

Implement a data structure 'SetOfStacks' that mimics this.

'SetOfStacks' should be composed of several stacks once the previous one exceeds capacity.
SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack.

FOLLOW UP
---------

Implement a function popAt(int index) which preforms a pop operation at a specific sub-stack.

baaart.dev
*/

public class StackOfPlates {
    
    int stackCapacity = 30; // How much a Stack can hold before being starting new one.
    int stackIndex = 0;
    Stack<T>[] stacks;
    int[] sizes;
    // New stacks created in this array for access.
    public T pop(){}
    // FOLLOW UP
    // public T popAt(int index){}
    public void push(T data){}
    public T peek(){}

    private void newStack(){}
    // increment stack index
    // add new Stack Object to Stack<T> array.

    private void destroyStack(){}
    // save tmp var of stackIndex

    public boolean IsEmpty(){}
    // returns if stacks are empty.
}

/*
My implementation of a Stack Data Structure 
using an Array
baaart.dev
*/
public class Stack<T> {

    private T[] stackArray;
    private int capacity;
    private int items = 0;
    public Stack(int capacity){
        this.capacity = capacity;
        stackArray = new T[capacity];
    }

    public T Pop(){
        if(top == null) throw new EmptyStackException();
        
        T item = top.data;
        top = top.next;
        
        return item;
    }

    public void Push(T data){
        if(items == capacity) throw new FullStackException()
        stackArray[items] = data;
        items++;
    }

    public T peek(){
        if(items == 0) throw new EmptyStackException();
        return stackArray[items-1];
    }

    public bool IsEmpty(){
        return items == 0;
    }
}