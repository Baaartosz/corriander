/*
Stack of Plates

Imagine a (literal) stack of plates. If the stack gets too high, it might topple. 
Therefore in real-life, we would likely start a new stack when the previous stack 
exceeds some threshold.

Implement a data structure 'SetOfStacks' that mimics this.

'SetOfStacks' should be composed of several stacks once the previous one exceeds capacity.
SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack.

FOLLOW UP
---------

Implement a function popAt(int index) which preforms a pop operation at a specific sub-stack.

baaart.dev
*/

public class SetOfStacks {
    
    int stackCapacity = 30; // How much a Stack can hold before being starting new one.
    int stackIndex = 0;
    Stack<T>[] stacks; // this 
    // New stacks created in this array for access.
    public T Pop(){
        if(stacks[stackIndex].IsEmpty) throw new System.Exception("Stack Empty");
        T value = stacks[stackInde].Pop();
        return value;
    }
    /* FOLLOW UP
        public T popAt(int index){}
    */
    public void Push(T data){
        if(stacks[stackIndex].IsFull) newStack();
        stacks[stackIndex].Push(data);
    }
    public T Peek(){
        return stacks[stackIndex].Peek();
    }

    private void newStack(){
        stackIndex++;
        stacks[stackIndex] = new Stack<T>(stackCapacity);
    }
    // increment stack index
    // add new Stack Object to Stack<T> array.

    private void destroyStack(){

    }
    

    public boolean IsEmpty(){
        return stacks[0].IsEmpty; // Only need to check if Stack 0 is empty;
    }
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
        if(IsEmpty()) throw new EmptyStackException();
        T value = stackArray[items-1];
        stackArray[items-1] = null;
        items--;
        return value;
    }

    public void Push(T data){
        if(IsFull()) throw new FullStackException();
        stackArray[items] = data;
        items++;
    }

    public T Peek(){
        if(items == 0) throw new EmptyStackException();
        return stackArray[items-1];
    }

    public bool IsEmpty(){
        return items == 0;
    }

    public bool IsFull(){
        return items == capacity;
    }
}