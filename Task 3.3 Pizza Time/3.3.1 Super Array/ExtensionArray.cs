using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1_Super_Array
{
    public static class ExtensionArray
    {
        public static int GetSum(this int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentException("The array cannot be empty!");
            }
            else
            {
                return arr.Sum();
            }
        }

        public static double GetAverage(this int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentException("The array cannot be empty!");
            }
            else
            {
                return arr.Average();
            }
        }

        public static int Reiteration(this int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentException("The array cannot be empty!");
            }
            else
            {
                return arr.GroupBy(el => el).OrderBy(el => el.Count()).Last().Key;
            }
        }

        public static void ExtensionForeach(this int[] arr, Func<int, int> func)
        {
            if (arr == null)
            {
                throw new ArgumentException("The array cannot be empty!");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = func(arr[i]);
                }
            }
        }
    }
}
