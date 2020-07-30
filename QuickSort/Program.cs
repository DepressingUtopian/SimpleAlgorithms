using System;
using System.Collections.Generic;

namespace SimpleAlgorithms
{
    public class QuickSort
    {
        private static Random randomGen = new Random();
        public static void Sort(List<int> list)
        {
            SortIteration(ref list,0, list.Count - 1);
        }

        private static void SortIteration(ref List<int> list, int left, int right)
        {

            if (left < right)
            {
                if (list.Count < 2)
                    return;
                if (list.Count == 2)
                {
                    if (list[0] > list[1])
                    {
                        int temp = list[0];
                        list[0] = list[1];
                        list[1] = temp;
                    }
                    return;
                }

                int supportElemIdx = PartitionChora(ref list, left, right);

                SortIteration(ref list, left, supportElemIdx);
                SortIteration(ref list, supportElemIdx + 1, right);
            }
        }

        private static int PartitionChora(ref List<int> mainList, int left, int right)
        {
            int pivotElem = mainList[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i++;
                }
                while (mainList[i] < pivotElem);

                do
                {
                    j--;
                }
                while (mainList[j] > pivotElem);

                if (i >= j)
                    return j;

                int temp = mainList[i];
                mainList[i] = mainList[j];
                mainList[j] = temp;
            }
        }
    }

}
