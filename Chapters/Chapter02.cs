using System;
using System.Collections.Generic;
using System.Text;

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

        // 2.4 Partition
        public LinkedListNode Question04(LinkedListNode head, int x)
        {
            var current = head;
            LinkedListNode left0 = null,
                leftN = null,
                right0 = null,
                rightN = null;

            while (current != null)
            {
                int data = current.data;
                if (data >= x)
                {
                    if (right0 == null)
                    {
                        right0 = new LinkedListNode(data);
                        rightN = right0;
                    }
                    else
                    {
                        rightN = rightN.AddNode(data);
                    }
                }
                else
                {
                    if (left0 == null)
                    {
                        left0 = new LinkedListNode(data);
                        leftN = left0;
                    }
                    else
                    {
                        leftN = leftN.AddNode(data);
                    }
                }
                current = current.next;
            }

            if (left0 == null)
            {
                return right0;
            }
            else
            {
                leftN.next = right0;
                return left0;
            }
        }

        // 2.5 Sum Lists
        public int Question05(LinkedListNode l1, LinkedListNode l2, bool leftToRight = false)
        {
            string ListToString(LinkedListNode head, bool ltr)
            {
                var result = new StringBuilder();
                var current = head;
                while (current != null)
                {
                    if (ltr)
                    {
                        result.Append(current.data);
                    }
                    else
                    {
                        result.Insert(0, current.data);
                    }
                    current = current.next;
                }
                return result.ToString();
            }
            return int.Parse(ListToString(l1, leftToRight)) + int.Parse(ListToString(l2, leftToRight));
        }

        // 2.6 Palindrome
        public bool Question06(LinkedListNode head)
        {
            if (head == null)
            {
                return false;
            }

            var stack = new Stack<int>();
            var current = head;

            while (current != null)
            {
                stack.Push(current.data);
                current = current.next;
            }

            current = head;

            while (current != null)
            {
                if (stack.Count == 0 || current.data != stack.Pop())
                {
                    return false;
                }
                current = current.next;
            }

            return stack.Count == 0;
        }

        // 2.7 Intersection
        public LinkedListNode Question07(LinkedListNode l1, LinkedListNode l2)
        {
            var s1 = new Stack<LinkedListNode>();
            var current = l1;
            while (current != null)
            {
                s1.Push(current);
                current = current.next;
            }

            var s2 = new Stack<LinkedListNode>();
            current = l2;
            while (current != null)
            {
                s2.Push(current);
                current = current.next;
            }

            LinkedListNode result = null;
            while (s1.Count > 0 && s2.Count > 0)
            {
                if (s1.Peek() == s2.Pop())
                {
                    result = s1.Pop();
                }
            }

            return result;
        }
    }
}
