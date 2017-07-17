using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackyExcersise
{
    class stackyMethod
    {
        string[] stackArray;
        int top;
        int maxSize = 0;

        public stackyMethod(int elementSize)
        {
            maxSize = elementSize;
            stackArray = new String[maxSize];
        }

        public void push(string j) // put item on top of stack
        {
            stackArray[++top] = j; // increment top, insert item
        }
        public string pop() // take item from top of stack
        {
            return stackArray[top--]; // access item, decrement top
        }
        public string peek() // peek at top of stack
        {
            return stackArray[top];
        }
        public bool isEmpty() // true if stack is empty
        {
            return (top == -1);
        }
        public bool isFull() // true if stack is full
        {
            return (top == maxSize - 1);
        }
    }
}
