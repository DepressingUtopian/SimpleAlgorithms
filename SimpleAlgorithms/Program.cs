using System;
using System.Collections.Generic;

namespace SimpleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[0];
            List<int> list = new List<int>();
            List<int> sortedList;
            //BinarySearch.RandomizeArray(ref array,100000000,true);
           // BinarySearch.Find(array[3], array);

            DataSet.DataSet.RandomizeList(ref list, 10000, false);
            SelectionSort.Sort(list,out sortedList);
            DataSet.DataSet.RandomizeList(ref list, 10000, false);
            QuickSort.Sort(list);
            var graph =  DataSet.DataSet.GenMatrixGraph(6,10);
            BFS.Find(graph,1,5);
        }
    }
}
