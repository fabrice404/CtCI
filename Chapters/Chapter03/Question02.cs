using System;
namespace CtCI.Chapter3
{
    public class Q2Stack
    {
        private Q2StackNode top;

        public int Pop()
        {
            if (this.top == null)
            {
                throw new Exception();
            }
            var result = this.top.data;
            this.top = this.top.next;
            return result;
        }

        public int Peek()
        {
            if (this.top == null)
            {
                throw new Exception();
            }
            return this.top.data;
        }

        public void Push(int data)
        {
            var t = new Q2StackNode(data)
            {
                next = this.top,
                min = (this.top == null || data < this.top.data) ? data : this.top.data
            };
            this.top = t;
        }

        public int Min()
        {
            if (top == null)
            {
                throw new Exception();
            }
            return top.min;
        }
    }

    public class Q2StackNode
    {
        public int data;
        public int min;
        public Q2StackNode next;

        public Q2StackNode(int data)
        {
            this.data = data;
        }
    }
}
