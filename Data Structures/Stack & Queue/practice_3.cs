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
    public class SetOfStacks<T> : IStack<T>
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
            if (IsEmpty()) throw new Exception("SetOfStacks is Empty");
            if (_subStacks.Peek().IsEmpty()) throw new Exception("SubStack is  empty.");
            return _subStacks.Peek().Peek();
        }

        public bool IsEmpty()
        {
            return _subStacks.IsEmpty();
        }
    }

    public class Stack<T> : IStack<T>
    {
        public class StackNode<T>
        {
            internal T Data;
            internal StackNode<T> Next;

            public StackNode(T data)
            {
                Data = data;
            }
        }

        private static StackNode<T> _top;
        
        public T Pop()
        {
            if (_top == null) throw new Exception("Empty Stack");
        
            T item = _top.Data;
            _top = _top.Next;
        
            return item;
        }

        public void Push(T data){
            StackNode<T> t = new StackNode<T>(data);
            t.Next = _top;
            _top = t;
        }

        public T Peek(){
            if(_top == null)throw new Exception("Empty Stack");
            return _top.Data;
        }

        public bool IsEmpty(){
            return _top == null;
        }
    }


    /// <summary>
    /// Abstract Data Type : Stack Implementation
    /// Additional Extra Info: Stacks are First In, Last Out.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Removes and Returns the last added item.
        /// </summary>
        /// <returns>T</returns>
        public T Pop();
        
        /// <summary>
        /// Adds item to the top of the Stack.
        /// </summary>
        /// <param name="data">T</param>
        public void Push(T data);
        
        /// <summary>
        /// Looks at top item in the Stack
        /// </summary>
        /// <returns>T</returns>
        public T Peek();
        
        /// <summary>
        /// Returns if Stack is Empty.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsEmpty();
    }
}