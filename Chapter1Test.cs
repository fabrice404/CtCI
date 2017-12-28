using System;
using NUnit.Framework;

namespace CtCI
{
    [TestFixture]
    public class Chapter1Test
    {
        [TestCase]
        public void Question01()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual(true, chapterI.Question01("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, chapterI.Question01("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(true, chapterI.Question01(""));
        }

        [TestCase]
        public void Question02()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual(true, chapterI.Question02("abc", "cba"));
            Assert.AreEqual(true, chapterI.Question02("abc", "abc"));
            Assert.AreEqual(false, chapterI.Question02("aabc", "abbc"));
        }

        [TestCase]
        public void Question03()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual("abc%20d%20e%20f", chapterI.Question03("abc d e f", 9));

        }

        [TestCase]
        public void Question04()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual(true, chapterI.Question04("Tact Coa"));
            Assert.AreEqual(true, chapterI.Question04("tattarrattat"));
            Assert.AreEqual(true, chapterI.Question04(""));
            Assert.AreEqual(true, chapterI.Question04("Dennis, Nell, Edna, Leon, Nedra, Anita, Rolf, Nora, Alice, Carol, Leo, Jane, Reed, Dena, Dale, Basil, Rae, Penny, Lana, Dave, Denny, Lena, Ida, Bernadette, Ben, Ray, Lila, Nina, Jo, Ira, Mara, Sara, Mario, Jan, Ina, Lily, Arne, Bette, Dan, Reba, Diane, Lynn, Ed, Eva, Dana, Lynne, Pearl, Isabel, Ada, Ned, Dee, Rena, Joel, Lora, Cecil, Aaron, Flora, Tina, Arden, Noel, and Ellen sinned."));
        }

        [TestCase]
        public void Question05()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual(true, chapterI.Question05("pale", "ple"));
            Assert.AreEqual(true, chapterI.Question05("pales", "pale"));
            Assert.AreEqual(true, chapterI.Question05("pale", "bale"));
            Assert.AreEqual(false, chapterI.Question05("pale", "bake"));
        }

        [TestCase]
        public void Question06()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual("a3", chapterI.Question06("aaa"));
            Assert.AreEqual("a2b1c5a3", chapterI.Question06("aabcccccaaa"));
        }

        [TestCase]
        public void Question07()
        {
            Chapter1 chapterI = new Chapter1();
            int size = 3,
                top = 0,
                right = size - 1,
                bottom = size - 1,
                left = 0;

            var matrix = Tools.GenerateMatrix(size, size, 0, 10);

            // I store desired values beceause array is a reference type
            // https://stackoverflow.com/questions/1533757/is-int-a-reference-type-or-a-value-type
            var topLeft = matrix[top][left];
            var topRight = matrix[top][right];
            var bottomRight = matrix[bottom][right];
            var bottomLeft = matrix[bottom][left];

            chapterI.Question07(matrix, size);

            // topLeft      0,0 -> topRight     0,2
            Assert.AreEqual(topLeft, matrix[top][right]);

            // topRight     0,2 -> bottomRight  2,2
            Assert.AreEqual(topRight, matrix[bottom][right]);

            // bottomRight  2,2 -> bottomLeft   2,0
            Assert.AreEqual(bottomRight, matrix[bottom][left]);

            // bottomLeft   2,0 -> topLeft      0,0
            Assert.AreEqual(bottomLeft, matrix[top][left]);
        }

        [TestCase]
        public void Question08()
        {
            Chapter1 chapterI = new Chapter1();

            var matrix = new int[5][];
            matrix[0] = new int[] { 1, 1, 1, 1, 1 };
            matrix[1] = new int[] { 1, 0, 1, 1, 1 };
            matrix[2] = new int[] { 1, 1, 1, 1, 1 };
            matrix[3] = new int[] { 1, 1, 1, 0, 1 };
            matrix[4] = new int[] { 1, 1, 1, 1, 1 };

            chapterI.Question08(matrix);

            Assert.AreEqual(new int[] { 1, 0, 1, 0, 1 }, matrix[0]);
            Assert.AreEqual(new int[] { 0, 0, 0, 0, 0 }, matrix[1]);
            Assert.AreEqual(new int[] { 1, 0, 1, 0, 1 }, matrix[2]);
            Assert.AreEqual(new int[] { 0, 0, 0, 0, 0 }, matrix[3]);
            Assert.AreEqual(new int[] { 1, 0, 1, 0, 1 }, matrix[4]);
        }

        [TestCase]
        public void Question09()
        {
            Chapter1 chapterI = new Chapter1();
            Assert.AreEqual(true, chapterI.Question09("waterbottle", "erbottlewat"));
            Assert.AreEqual(false, chapterI.Question09("abc", "cba"));
        }
    }
}
