using System;

namespace ZMatrixStruct
{
    public struct ZMatrix2x2
    {
        private readonly int[,] matrix;

        public int Track => matrix[0, 0] + matrix[1, 1];
        public int Determinant => matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        public ZMatrix2x2(int[,] data)
        {
            if (data.GetLength(0) != 2 || data.GetLength(1) != 2)
                throw new ArgumentException("Матрица должна быть 2x2.");

            matrix = new int[2, 2];
            Array.Copy(data, matrix, data.Length);
        }

        public override string ToString()
        {
            return $"{matrix[0, 0]} {matrix[0, 1]}\n{matrix[1, 0]} {matrix[1, 1]}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ZMatrix2x2)) return false;
            ZMatrix2x2 other = (ZMatrix2x2)obj;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    if (this.matrix[i, j] != other.matrix[i, j])
                        return false;
            return true;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + matrix[0, 0].GetHashCode();
                hash = hash * 23 + matrix[0, 1].GetHashCode();
                hash = hash * 23 + matrix[1, 0].GetHashCode();
                hash = hash * 23 + matrix[1, 1].GetHashCode();
                return hash;
            }
        }

        public static ZMatrix2x2 operator +(ZMatrix2x2 a, ZMatrix2x2 b)
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    result[i, j] = a.matrix[i, j] + b.matrix[i, j];
            return new ZMatrix2x2(result);
        }

        public static ZMatrix2x2 operator *(ZMatrix2x2 a, int k)
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    result[i, j] = a.matrix[i, j] * k;
            return new ZMatrix2x2(result);
        }

        public static ZMatrix2x2 operator *(ZMatrix2x2 a, ZMatrix2x2 b)
        {
            int[,] result = new int[2, 2];
            result[0, 0] = a.matrix[0, 0] * b.matrix[0, 0] + a.matrix[0, 1] * b.matrix[1, 0];
            result[0, 1] = a.matrix[0, 0] * b.matrix[0, 1] + a.matrix[0, 1] * b.matrix[1, 1];
            result[1, 0] = a.matrix[1, 0] * b.matrix[0, 0] + a.matrix[1, 1] * b.matrix[1, 0];
            result[1, 1] = a.matrix[1, 0] * b.matrix[0, 1] + a.matrix[1, 1] * b.matrix[1, 1];
            return new ZMatrix2x2(result);
        }

        public static bool operator ==(ZMatrix2x2 a, ZMatrix2x2 b) => a.Equals(b);
        public static bool operator !=(ZMatrix2x2 a, ZMatrix2x2 b) => !a.Equals(b);
    }
}