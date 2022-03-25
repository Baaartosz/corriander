/*
Three in One

Describe how you could use a single array to implement three stacks.

baaart.dev
*/

/*

Approach 1 ( Fixed Division ) [Simple]

Equally Divide the Array into three equal parts.

+ relitivity simple approach
- One Stack can run out of capacity while others can be empty.

Approach 2 ( Flexible Stack Size ) [Complex]

Circually Linked Array
Shifting nodes when capacity is exceede, expanding is possible too.

- Complex approach requiring long bits of code
+ Allows for flexible capacity of the three stacks optimsing for the best memory usage.

*/

public class FixedMultiSize<T>{

    // stack 1 start = size * 0/3
    // stack 2 start = size * 1/3
    // stack 3 start = size * 2/3
    // way to track beginning of stack, and write index
    int numOfStacks = 3;
    int stackCapacity;
    T[] values; // Stack Values
    int[] sizes; // Stack Sizes (Where the )

    public FixedMultiSize(int size){
        stackSize = size;
        values = new T[stackCapacity * numOfStacks];
        sizes = new int[numOfStacks];
    }

    public void Push(int stackNo, T data){
        if(IsFull(stack)){
            throw new FullStackException();
        }
    }

    public T Pop(int stackNo){

    }

    public T Peek(int stackNo){
        if(isEmpty(stackNo)){
            throw new EmptyStackException();
        }
        return values[IndexOfTop(stackNo)];
    }

    public boolean IsEmpty(int stackNo){
        return sizes[stackNo] == 0;
    }

    public boolean IsFull(int stackNo){
        return sizes[stackNo] == stackCapacity;
    }

    private int IndexOfTop(int stackNo){ // Gets top of stack from specified stack.
        int offset = stackNo * stackCapacity;
        int size = sizes[stackNo];
        return offset + size - 1;
    }

    //void push(int stackNo, T value)
    //T pop(int stackNo)
    //T peek(int stackNo)
    //IsStacksEmpty() { return IsEmpty(1) && IsEmpty(2) && IsEmpty(3) }
    //IsEmpty(int stackNo)
}