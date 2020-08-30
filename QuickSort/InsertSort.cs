using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class InsertSort
    {
        public static void Sort(List<int> list)
        {
            int saveIdx = 0;
            for (int i = 1; i < list.Count; i++)
            {
                saveIdx = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (list[saveIdx] < list[j])
                    {
                        Swap(list, saveIdx, j);
                        saveIdx = j;
                    }
                }
            }
        }

        private static void Swap(List<int> list, int i, int j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

    }
}
