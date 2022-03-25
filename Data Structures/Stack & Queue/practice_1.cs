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

/* Fixed Approach */
public class FixedMultiSize<T>{
    int numOfStacks = 3;
    int stackCapacity;
    T[] values; // Stack Values
    int[] sizes; // Stack Sizes (Where the )

    public FixedMultiSize(int size){
        stackSize = size;
        values = new T[stackCapacity * numOfStacks];
        sizes = new int[numOfStacks];
    }

    /* Adds to top of specifed stack */
    public void Push(int stackNo, T data){
        if(IsFull(stack)){
            throw new FullStackException();
        }

        /* Increment stack pointer then add to stack */
        sizes[stackNo]++;
        values[IndexOfTop(stackNo)] = data;
    }

    /* Removes and returns top element of stack  */
    public T Pop(int stackNo){
        if(IsEmpty(stackNo)){
            throw new EmptyStackException();
        }
        
        int topIndex = IndexOfTop(stackNo);
        int data = values[topIndex];
        
        values[topIndex] = null;
        sizes[stackNo]--;
        
        return data;
    }

    /* Returns top item of stack */
    public T Peek(int stackNo){
        if(isEmpty(stackNo)){
            throw new EmptyStackException();
        }
        return values[IndexOfTop(stackNo)];
    }

    /* Returns if a stack is empty */
    public boolean IsEmpty(int stackNo){
        return sizes[stackNo] == 0;
    }

    /* Returns if a stack is full */
    public boolean IsFull(int stackNo){
        return sizes[stackNo] == stackCapacity;
    }

    /* Returns top index from stack */
    private int IndexOfTop(int stackNo){ 
        int offset = stackNo * stackCapacity;
        int size = sizes[stackNo];
        return offset + size - 1;
    }
}