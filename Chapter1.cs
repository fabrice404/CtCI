using System;
using System.Collections.Generic;
using System.Text;

namespace CtCI
{
    // Arrays and Strings (page 90)
    public class Chapter1
    {
        // 1.1 Is Unique
        public bool Question01(string input)
        {
            var chars = new List<char>();
            foreach (char c in input.ToCharArray())
            {
                if (chars.Contains(c))
                {
                    return false;
                }
                chars.Add(c);
            }
            return true;
        }

        // 1.2 Check Permutation
        public bool Question02(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, int>();
            foreach (var c in a.ToCharArray())
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c] += 1;
                }
            }

            foreach (var c in b.ToCharArray())
            {
                if (!dict.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    dict[c] -= 1;
                    if (dict[c] == 0)
                    {
                        dict.Remove(c);
                    }
                }
            }

            return dict.Count == 0;
        }

        // 1.3 URLify
        public string Question03(string input, int length)
        {
            var result = new List<char>();

            foreach (char c in input.ToCharArray())
            {
                if (c == ' ')
                {
                    result.Add('%');
                    result.Add('2');
                    result.Add('0');
                }
                else
                {
                    result.Add(c);
                }
            }

            return new string(result.ToArray());
        }

        // 1.4 Palindrome Permutation
        public bool Question04(string input)
        {
            input = input.ToLower();
            var dict = new Dictionary<char, int>();
            int oddCount = 0;
            int lengthWithoutIgnoredChars = input.Length;
            foreach (var c in input.ToCharArray())
            {
                if ((int)c < char.GetNumericValue('a') || char.GetNumericValue('z') < (int)c)
                {
                    lengthWithoutIgnoredChars--;
                    continue;
                }

                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                    oddCount++;
                }
                else
                {
                    dict[c] += 1;
                    if (dict[c] % 2 == 0)
                    {
                        oddCount--;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
            }

            // string length is odd, odd count must be 1
            // if string length is even, odd count must be 0
            return
                (lengthWithoutIgnoredChars % 2 == 1 && oddCount == 1)
                ||
                (lengthWithoutIgnoredChars % 2 == 0 && oddCount == 0)
                ;
        }

        // 1.5 One Away
        public bool Question05(string a, string b)
        {
            if (Math.Abs(a.Length - b.Length) > 1)
            {
                return false;
            }

            string longest = a.Length >= b.Length ? a : b,
            shortest = a.Length >= b.Length ? b : a;

            int iL = 0,
            iS = 0;

            bool differenceFound = false;

            while (iL < longest.Length && iS < shortest.Length)
            {
                char cL = longest[iL],
                    cS = shortest[iS];

                if (cL.Equals(cS))
                {
                    iS++;
                }
                else
                {
                    if (differenceFound)
                    {
                        return false;
                    }
                    differenceFound = true;
                    if (longest.Length == shortest.Length)
                    {
                        iS++;
                    }
                }
                iL++;
            }

            return true;
        }

        // 1.6 String Compression
        public string Question06(string input)
        {
            var result = new StringBuilder();

            if (input.Length == 0)
            {
                return "";
            }
            char lastChar = input[0];
            int countChar = 1;

            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar.Equals(lastChar))
                {
                    countChar++;
                }
                else
                {
                    result.Append(lastChar + countChar.ToString());
                    countChar = 1;
                }

                lastChar = currentChar;
            }
            result.Append(lastChar + countChar.ToString());

            return result.Length > input.Length ? input : result.ToString();
        }

        // 1.7 Rotate Matrix
        public void Question07(int[][] matrix, int size)
        {
            for (var layer = 0; layer < size / 2; ++layer)
            {
                var first = layer;
                var last = (size - 1) - layer;

                for (var i = first; i < last; ++i)
                {
                    var offset = i - first;
                    var top = matrix[first][i];

                    // left -> top
                    matrix[first][i] = matrix[last - offset][first];

                    // bottom -> left
                    matrix[last - offset][first] = matrix[last][last - offset];

                    // right -> bottom
                    matrix[last][last - offset] = matrix[i][last];

                    // top -> right
                    matrix[i][last] = top;
                }
            }
        }

        // 1.8 Zero Matrix
        public void Question08(int[][] matrix)
        {
            var rows = new List<int>();
            var columns = new List<int>();

            // scan all zeros
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!rows.Contains(i))
                        {
                            rows.Add(i);
                        }
                        if (!columns.Contains(j))
                        {
                            columns.Add(j);
                        }
                    }
                }
            }

            // update rows
            foreach (int i in rows)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = 0;
                }
            }

            // update columns
            foreach (int j in columns)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i].Length > j)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }

        // 1.9 String Rotation
        public bool Question09(string a, string b)
        {
            if (a.Length == b.Length && a.Length > 0)
            {
                return (a + a).Contains(b);
            }
            return false;
        }
    }
}
