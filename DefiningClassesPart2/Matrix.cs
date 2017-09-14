using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Matrix<T> : Number
        where T : struct
    {
        private T[,] m;
        public Matrix(int row, int col)
        {
            m = new T[row, col];
        }
        //indexer
        public T this[int x, int y]
        {
            get
            {
                return m[x, y];
            }
            set
            {
                m[x, y] = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    sb.Append(this[i, j] + " ");
                }
                sb.Append("\r\n");
            }
            return sb.ToString();
        }
        public static Matrix<T> operator+ (Matrix<T> a, Matrix<T> b)
        {
            if((a.m.GetLength(0) != b.m.GetLength(0)) || (a.m.GetLength(1) != b.m.GetLength(1)))
            {
                throw new ArgumentException("The matrices must be of the same size");
            }
            Matrix<T> result = new Matrix<T>(a.m.GetLength(0), a.m.GetLength(1));
            for(int i = 0; i < a.m.GetLength(0); i++)
            {
                for(int j = 0; j < a.m.GetLength(1); j++)
                {
                    dynamic x = a.m[i, j];
                    dynamic y = b.m[i, j];
                    result[i, j] = x + y;
                }
            }
            return result;
        }
        public static Matrix<T> operator- (Matrix<T> a, Matrix<T> b)
        {
            if ((a.m.GetLength(0) != b.m.GetLength(0)) || (a.m.GetLength(1) != b.m.GetLength(1)))
            {
                throw new ArgumentException("The matrices must be of the same size");
            }
            Matrix<T> result = new Matrix<T>(a.m.GetLength(0), a.m.GetLength(1));
            for (int i = 0; i < a.m.GetLength(0); i++)
            {
                for (int j = 0; j < a.m.GetLength(1); j++)
                {
                    dynamic x = a.m[i, j];
                    dynamic y = b.m[i, j];
                    result[i, j] = x - y;
                }
            }
            return result;
        }

        public static Matrix<T> operator* (Matrix<T> a, Matrix<T> b)
        {
            if (a.m.GetLength(1) != b.m.GetLength(0))
            {
                throw new ArgumentException("There must be at least one match between matrices' row vs col count!");
            }
            Matrix<T> result = new Matrix<T>(a.m.GetLength(0), b.m.GetLength(1));
            for(int i = 0; i < a.m.GetLength(0); i++)
            {
                for(int j = 0; j < b.m.GetLength(1); j++)
                {
                    result[i, j] = GetSum(a, b, i, j );
                }
            }
            return result;
        }

        public static implicit operator bool(Matrix<T> matrix)
        {
            if (matrix.m.GetLength(0) == 0 || matrix.m.GetLength(1) == 0)
            {
                return false;
            }
            for(int i = 0; i < matrix.m.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.m.GetLength(1); j++)
                {
                    dynamic a = matrix[i, j];
                    if(a == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static dynamic GetSum(Matrix<T> a, Matrix<T> b, int row, int col)
        {
            dynamic sum = 0;
            for(int i = 0; i < a.m.GetLength(1); i++)
            {
                dynamic x = a[row, i];
                dynamic y = b[i, col];
                sum += (x * y);
            }
            return sum;
        }
    }
}
