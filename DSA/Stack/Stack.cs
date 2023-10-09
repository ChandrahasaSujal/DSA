using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class Stack
    {
        private int count;
        private int[] stack;

        public Stack(int size)
        {
            this.stack = new int[size];
        }

        public void Push(int value)
        {
            if (this.count == this.stack.Length)
            {
                Console.WriteLine("Stack is full.");
            }
            else
            {
                this.stack[this.count++] = value;
            }
        }

        public int Pop()
        {
            if (this.stack.Length == 0)
            {
                Console.WriteLine("Stack is Empty.");
            }
           
            return this.stack[--count];
        }

        public void Display()
        {
            if (this.stack.Length == 0)
            {
                Console.WriteLine("Stack is Empty.");
            }

            for (int i = 0; i < this.stack.Length; i++)
            {
                Console.WriteLine(this.stack[i]);
            }

        }
    }
}
