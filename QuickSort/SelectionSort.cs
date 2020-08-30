using System;
using System.Collections.Generic;

namespace SimpleAlgorithms
{
    public class SelectionSort
    {
        private static int idxSmallest(List<int> list)
        {
            if (list.Count == 0)
                throw new Exception("Список пуст!");

            int smallest = list[0];
            int smallest_index = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    smallest_index = i;
                }
            }
            return smallest_index; 
        }
        public static void Sort(List<int> list,out List<int> newList)
        {
            int smallest = 0;
            newList = new List<int>();
            while (list.Count != 0)
            {
                smallest = idxSmallest(list);
                newList.Add(list[smallest]);
                list.RemoveAt(smallest);
            }
        }
    }
}
