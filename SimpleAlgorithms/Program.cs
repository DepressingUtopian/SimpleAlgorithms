using System;
using System.Collections.Generic;
using GraphAlgorithms;

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
            int[,] test_graph = { {0,7,9,0,0,14},
                                  {7,0,10,15,0,0},
                                  {9,10,0,11,0,2},
                                  {0,15,11,0,6,0},
                                  {0,0,0,6,0,9},
                                  {14,0,2,0,9,0}
                                }; 
            Dijkstras.Find(test_graph, 0, 5);
            Floyd.Find(test_graph, 0, 5);        
        }
    }
}
