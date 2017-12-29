using System;
using System.Collections.Generic;

namespace CtCI
{
    public class Chapter02
    {
        // 2.1 Remove Dups
        public void Question01(LinkedListNode head)
        {
            var values = new List<int>();
            LinkedListNode current = head;

            while (current.next != null)
            {
                values.Add(current.data);
                if (values.Contains(current.next.data))
                {
                    current.next = current.next.next;
                }
                current = current.next;
            }
        }

        // 2.2 Return Kth to Last 
        public LinkedListNode Question02(LinkedListNode head, int k)
        {
            LinkedListNode current = head,
                runner = head;
            for (int i = 0; i < k; i++)
            {
                runner = runner.next;
            }

            while (runner.next != null)
            {
                runner = runner.next;
                current = current.next;
            }

            return current;
        }

        // 2.3 Delete Middle Node
        public void Question03(LinkedListNode node)
        {
            node.data = node.next.data;
            node.next = node.next.next;
        }

    }
}
