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

using System;

namespace SetOfStacks_Sandbox
{
    public class SetOfStacks<T>
    {
        private Stack<Stack<T>> _subStacks = new Stack<Stack<T>>();
        private int _capacity; // Amount of StackNodes kept in a single Stack.
        private int _items = 0; // Keep track of items in current Stack.

        public SetOfStacks(int capacity)
        {
            _capacity = capacity;
        }

        private void NewStack()
        {
            _subStacks.Push(new Stack<T>());
        }
        private void DestroyStack()
        {
            _subStacks.Pop();
        }
        
        public T Pop()
        {
            // Check if the sub-stack is empty.
            if(_subStacks.Peek().IsEmpty()) DestroyStack();
            if (_subStacks.IsEmpty()) throw new Exception("SetOfStacks is Empty");
            T value = _subStacks.Peek().Pop();
            _items--;
            return value;
        }

        public void Push(T data)
        {
            if(_items == _capacity) NewStack();
            if (IsEmpty()) NewStack();
            _subStacks.Peek().Push(data);
            _items++;
        }

        public T Peek()
        {
            if (_subStacks.IsEmpty()) throw new Exception("SetOfStacks is Empty");
            if (_subStacks.Peek().IsEmpty()) throw new Exception("SubStack is Empty.");
            return _subStacks.Peek().Peek();
        }

        public bool IsEmpty()
        {
            return _subStacks.IsEmpty();
        }
    }
}