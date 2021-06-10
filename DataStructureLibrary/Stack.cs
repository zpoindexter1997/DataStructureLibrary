using System;
using System.Text;

namespace DataStructureLibrary
{
    public class Stack<T>
    {
        //InitialSize is just our holder for the default # of objects in our array
        private const int InitialSize = 8;
        //Creating an instance of our Item class named item
        public Item<T> item { get; set; }
        //Defining the fixed array of the Items of type T
        private Item<T>[] stack;
        //This will point to the index of the array at the top of the stack, default to -1 saying nothing in the stack
        private int Top = -1;
        //This will keep track of the objects in our array
        public int Count { get; private set; } = 0;
        //This will keep track of if our stack is "full" so we can do something to it when it gets full
        private bool Full => Count == stack.Length;
        //This will just say if the stack is empty or not
        public bool Empty => Count == 0;

        public void Push(T t)
        {
            //If the array is full, call method DoubleCapacity (which will create a new array with double the capacity (first time 16)
            if (Full) DoubleCapacity();
            //If it's not full, we crate a new instance of our item using the data they give us
            var item = new Item<T>(t);
            //We increment Top (since our array is getting 1 more item) and adds that item to our stack
            stack[++Top] = item;
            //Increments our count (first time means there will be 1 item in our stack)
            Count++;
        }

        //This will take an array of params T to push each one into our stack
        public void Push(params T[] ts)
        {
            foreach(var t in ts) {
                Push(t);
            }
        }
       
        public T Pop()
        {
            //If the stack is empty, throw this exception
            if (Empty) throw new Exception("Stack is empty!");
            //Create Item<T> type item that = our current stack's Top
            Item<T> item = stack[Top];
            //This will set the Top just Popped to null, then move the Top pointer down one
            stack[Top--] = null;
            //Decrement Count since we've lost an item
            Count--;
            //Returns the item that was Popped from the top
            return item.t;
        }

        //This method will just wipe our stack clean
        public void Reset()
        {
            Top = -1;
            Count = 0;
            stack = new Item<T>[InitialSize];
        }


        //This method will be called when our stack is full to create a new array, double the capacity, then copy the items from old small stack to new stack
        private void DoubleCapacity()
        {
            //New capacity takes our current stack's length and doubles it
            int newCapacity = stack.Length * 2;
            //Creates a new stack with a size of our new capacity
            Item<T>[] newStack = new Item<T>[newCapacity];

            //This loop will go through our smaller array and copies the items into our bigger array
            for(var idx = 0; idx < stack.Length; idx++)
            {
                newStack[idx] = stack[idx];
            }
            stack = newStack;
        }

        //Creating our constructor to set stack as a new array Item<DataType>[OurDefaultSize]
        public Stack()
        {
            stack = new Item<T>[InitialSize];
        }

    }


}
