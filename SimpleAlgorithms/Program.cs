using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DynamicProgramming;
using GraphAlgorithms;
using OtherAlgorithms;
using Sort;

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
            DataSet.DataSet.RandomizeList(ref list, 10000, false);
            InsertSort.Sort(list);
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
            KnapsackProblem.Solve(new Dictionary<int, int>() { { 5, 10}, { 7, 15}, { 12, 5}, { 15, 4} }, 1000);
     
            using (FileStream fs = new FileStream(@"C:\Users\HexMage\Source\Repos\SimpleAlgorithms\SimpleAlgorithms\dataset\json\points.json", FileMode.OpenOrCreate))
            {
               var points = JsonSerializer.DeserializeAsync<List<Point>>(fs).Result;
               NearestNeighbors.Classify(points, new Point("Test", 44, 55), 5);

            }
        }
    }
}
