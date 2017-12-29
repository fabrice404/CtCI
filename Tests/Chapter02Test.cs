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
            LinkedListNode root = new LinkedListNode(1);
            root.AddNode(2).AddNode(3).AddNode(3).AddNode(4).AddNode(5);

            Assert.AreEqual(1, root.data);
            Assert.AreEqual(2, root.next.data);
            Assert.AreEqual(3, root.next.next.data);
            Assert.AreEqual(3, root.next.next.next.data);
            Assert.AreEqual(4, root.next.next.next.next.data);
            Assert.AreEqual(5, root.next.next.next.next.next.data);

            chapter02.Question01(root);

            Assert.AreEqual(1, root.data);
            Assert.AreEqual(2, root.next.data);
            Assert.AreEqual(3, root.next.next.data);
            Assert.AreEqual(4, root.next.next.next.data);
            Assert.AreEqual(5, root.next.next.next.next.data);
        }

        [TestCase]
        public void Question02()
        {
            Chapter02 chapter02 = new Chapter02();
            LinkedListNode root = new LinkedListNode(1);
            root.AddNode(2).AddNode(3).AddNode(4).AddNode(5)
                .AddNode(6).AddNode(7).AddNode(8).AddNode(9);

            Assert.AreEqual(8, chapter02.Question02(root, 1).data);
            Assert.AreEqual(2, chapter02.Question02(root, 7).data);
        }
    }
}
