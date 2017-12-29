using System;
using NUnit.Framework;

namespace CtCI
{
    [TestFixture]
    public class Chapter02Test
    {
        [TestCase]
        public void Question01()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode head = new LinkedListNode(1);
            head.AddNode(2).AddNode(3).AddNode(3).AddNode(4).AddNode(5);

            Assert.AreEqual(1, head.data);
            Assert.AreEqual(2, head.next.data);
            Assert.AreEqual(3, head.next.next.data);
            Assert.AreEqual(3, head.next.next.next.data);
            Assert.AreEqual(4, head.next.next.next.next.data);
            Assert.AreEqual(5, head.next.next.next.next.next.data);

            chapter02.Question01(head);

            Assert.AreEqual(1, head.data);
            Assert.AreEqual(2, head.next.data);
            Assert.AreEqual(3, head.next.next.data);
            Assert.AreEqual(4, head.next.next.next.data);
            Assert.AreEqual(5, head.next.next.next.next.data);
        }

        [TestCase]
        public void Question02()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode head = new LinkedListNode(1);
            head.AddNode(2).AddNode(3).AddNode(4).AddNode(5)
                .AddNode(6).AddNode(7).AddNode(8).AddNode(9);

            Assert.AreEqual(8, chapter02.Question02(head, 1).data);
            Assert.AreEqual(2, chapter02.Question02(head, 7).data);
        }

        [TestCase]
        public void Question03()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode head = new LinkedListNode(1);
            LinkedListNode middle = head.AddNode(2).AddNode(3).AddNode(4).AddNode(5);
            middle.AddNode(6).AddNode(7).AddNode(8).AddNode(9);

            Assert.AreEqual(5, middle.data);
            Assert.AreEqual(6, middle.next.data);

            chapter02.Question03(middle);

            Assert.AreEqual(6, middle.data);
            Assert.AreEqual(7, middle.next.data);
        }

        [TestCase]
        public void Question04()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode head = new LinkedListNode(3);
            head.AddNode(5).AddNode(8).AddNode(5)
                .AddNode(10).AddNode(2).AddNode(1);

            head = chapter02.Question04(head, 5);

            Assert.AreEqual(true, head.data < 5);
            Assert.AreEqual(true, head.next.data < 5);
            Assert.AreEqual(true, head.next.next.data < 5);
            Assert.AreEqual(false, head.next.next.next.data < 5);
            Assert.AreEqual(false, head.next.next.next.next.data < 5);
            Assert.AreEqual(false, head.next.next.next.next.next.data < 5);
            Assert.AreEqual(false, head.next.next.next.next.next.next.data < 5);

        }

        [TestCase]
        public void Question05()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode l1 = new LinkedListNode(1);
            l1.AddNode(2).AddNode(3);
            LinkedListNode l2 = new LinkedListNode(4);
            l2.AddNode(5).AddNode(6);

            // 321 + 654 = 975
            Assert.AreEqual(975, chapter02.Question05(l1, l2));

            // 123 + 456 = 579
            Assert.AreEqual(579, chapter02.Question05(l1, l2, true));
        }

        [TestCase]
        public void Question06()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode head = new LinkedListNode(1);
            head.AddNode(2).AddNode(3).AddNode(4).AddNode(5)
                .AddNode(4).AddNode(3).AddNode(2).AddNode(1);

            Assert.AreEqual(true, chapter02.Question06(head));

            head.AddNode(0);
            Assert.AreEqual(false, chapter02.Question06(head));
        }
    }
}
