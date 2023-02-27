using System;
using System.Collections.Generic;

namespace aStack
{
    class Program
    {
        private int[] values;
        private int topIdx = -1;
        private Stack<string> newStack = new Stack<string>();

        public Program(int size)
        {
            this.values = new int[size];
        }

        public void Push(int value)
        {
            if (this.IsFull)
            {
                throw new Exception("Stack full");
            }

            this.topIdx++;
            this.values[topIdx] = value;

            this.newStack.Push(value.ToString());
        }

        public int Pop()
        {
            var value = this.values[this.topIdx];
            this.topIdx--;

            this.newStack.Pop();

            return value;
        }

        public void SwapXY()
        {
            if (this.topIdx >= 1)
            {
                int temp = this.values[topIdx];
                this.values[topIdx] = this.values[topIdx - 1];
                this.values[topIdx - 1] = temp;

                var inputs = this.newStack.ToArray();
                string tempInput = inputs[topIdx];
                inputs[topIdx] = inputs[topIdx - 1];
                inputs[topIdx - 1] = tempInput;
                this.newStack = new Stack<string>(inputs);
            }
        }

        public void Clear()
        {
            this.newStack.Clear();
            this.topIdx = -1;
        }

        public bool IsEmpty
        {
            get
            {
                return this.topIdx == -1;
            }
        }

        public bool IsFull
        {
            get
            {
                return this.topIdx == this.values.Length - 1;
            }
        }

        public string StringMaker()
        {
            return String.Join(", ", this.newStack);
        }
    }
}
