using System;
namespace CtCI
{
    public class LinkedListNode
    {
        public LinkedListNode next = null;
        public int data;

        public LinkedListNode(int data)
        {
            this.data = data;
        }

        public LinkedListNode AddNode(int data)
        {
            LinkedListNode last = new LinkedListNode(data);
            LinkedListNode node = this;
            while(node.next != null) {
                node = node.next;
            }
            node.next = last;
            return node.next;
        }
    }
}
