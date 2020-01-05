using System;

namespace SimpleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            BinarySearch.RandomizeArray(ref array,100000000);
            BinarySearch.Find(array[3], array);
        }
    }
}
