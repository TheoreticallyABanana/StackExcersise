using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackyMethods;


namespace StackyExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling referenced stack methods
            methods stackyExtreme = new methods(10);

            //Pushing items into array
            stackyExtreme.push("a");
            stackyExtreme.push("b");
            stackyExtreme.push("c");
            stackyExtreme.push("d");

            //print contents of array
            Console.WriteLine(stackyExtreme.peek());

            //Removing top item from stack
            stackyExtreme.pop();
            Console.WriteLine(stackyExtreme.peek());

            //Filling stack
            stackyExtreme.push("e");
            stackyExtreme.push("f");
            stackyExtreme.push("g");
            stackyExtreme.push("h");
            stackyExtreme.push("i");
            stackyExtreme.push("j");

            //checking if the stack is full
            if (stackyExtreme.isFull())
            {
                Console.WriteLine("STACKY IS FULL");
            }

            //Removing stack contents 
            for (int i = 0; i < 10; i++)
            {
                stackyExtreme.pop();
            }

            //checking if the stack is empty
            if (stackyExtreme.isEmpty())
            {
                Console.WriteLine("STACKY IS EMPTY");
            }



            
        }
    }
}
