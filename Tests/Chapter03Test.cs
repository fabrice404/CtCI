using System;
using NUnit.Framework;

namespace CtCI
{
    [TestFixture]
    public class Chapter03Test
    {
        [TestCase]
        public void Question01() { }

        [TestCase]
        public void Question02()
        {
            var stack = new Chapter3.Q2Stack();

            stack.Push(5);
            Assert.AreEqual(5, stack.Min());

            stack.Push(6);
            Assert.AreEqual(5, stack.Min());

            stack.Push(3);
            Assert.AreEqual(3, stack.Min());

            stack.Push(7);
            Assert.AreEqual(3, stack.Min());

            stack.Pop();
            Assert.AreEqual(3, stack.Min());

            stack.Pop();
            Assert.AreEqual(5, stack.Min());
        }
    }
}
