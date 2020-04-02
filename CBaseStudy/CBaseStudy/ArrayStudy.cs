using System;
using System.Collections.Generic
namespace CBaseStudy
{
    public class ArrayStudyClass
    {
        public void ArrayLearn()
        {
            int[] balance = new int[10];
            balance[0] = 1000;

            double[] balance2 = { 1.0, 2.0, 3.0, 4.0 };
            int[] marks = new int[5] { 1, 2, 3, 4, 5 };

            int i, j;

            for (i = 0; i < 10; i++)
            {
                balance[i] = i + 1000;
            }

            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, balance[j]);
            }

            //针对已知类型的数组，可以用foreach
            foreach (int x in balance)
            {
                Console.WriteLine("element:{0}", x);
            }

            Console.ReadKey();
        }



        //在一个二维数组中（每个一维数组的长度相同），每一行都按照从左到右递增的顺序排序，
        //每一列都按照从上到下递增的顺序排序。请完成一个函数，输入这样的一个二维数组和一个整数，判断数组中是否含有该整数。
        public bool Find(int target, int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length, j++)
                {
                    if(array[i][j] == target)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*
        在一个长度为n的数组里的所有数字都在0到n-1的范围内。
        数组中某些数字是重复的，但不知道有几个数字是重复的。
        也不知道每个数字重复几次。请找出数组中任意一个重复的数字。
        例如，如果输入长度为7的数组{2,3,1,0,2,5,3}，那么对应的输出是第一个重复的数字2。
         */
        public bool duplicate(int[] numbers, int[] duplication)
        {
            if (numbers.Length == 0) return false;
            int[] result = new int[numbers.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                foreach(int res in result)
                {
                    if (res == numbers[i])
                    {
                        duplication[0] = res;
                        return true;
                    }
                }
            }
            return false;
        }
        /*给定一个数组A[0,1,...,n-1],请构建一个数组B[0,1,...,n-1],
         * 其中B中的元素B[i]=A[0]*A[1]*...*A[i-1]*A[i+1]*...*A[n-1]。
         * 不能使用除法。（注意：规定B[0] = A[1] * A[2] * ... * A[n-1]，
         * B[n-1] = A[0] * A[1] * ... * A[n-2];）*/

        public int[] multiply(int[] A)
        {
            var B = new int[A.Length];
            var left = new int[A.Length];
            var right = new int[A.Length];

            left[0] = 1;
            right[A.Length - 1] = 1;

            for (var i = 1; i < A.Length; i++)
            {
                left[i] = left[i - 1] * A[i - 1];
            }

            for (var i = A.Length - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * A[i + 1];
            }

            for (var i = 0; i < A.Length; i++)
            {
                B[i] = left[i] * right[i];
            }

            return B;
        }
    }
}
