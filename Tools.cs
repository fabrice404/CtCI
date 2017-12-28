using System;
using System.Diagnostics;

namespace CtCI
{
    public struct Tools
    {
        public static int[][] GenerateMatrix(int m, int n, int min, int max)
        {
            var matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = RandomInt(min, max);
                }
            }
            return matrix;
        }

        private static Random _random = new Random();
        public static int RandomInt(int n)
        {
            return _random.Next(n);
        }
        public static int RandomInt(int min, int max)
        {
            return RandomInt(max - min + 1) + min;
        }
    }
}
