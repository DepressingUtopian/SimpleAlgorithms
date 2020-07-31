using System;
using System.Collections.Generic;

namespace SimpleAlgorithms
{
    public class BinarySearch
    {
        public static uint Find(int item, int[] array)
        {
            uint min = 0;
            uint max = (uint)array.Length - 1;
            uint mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (item == array[mid])
                    return mid;
                else if (item > array[mid])
                {
                    min = mid + 1;
                }
                else if (item < array[mid])
                {
                    max = mid - 1;
                }
            }
            throw new Exception("Элемент не найдет!");

        }
    }
}
