using System;
using System.Collections.Generic;
using System.Linq;

namespace Dijkstras
{
    public class Dijkstras
    {
        public static (List<int>, List<int>) Find(int[,] graph, int idx_start_node, int idx_goal_node)
        {
            int n = graph.GetLength(0);
            int[] d = new int[n];
            int[] p = new int[n];
            int min_weight_node_idx = 0;
            List<int> U = new List<int>();
            U.Add(idx_start_node);
           
            for (int i = 0; i < n; i++)
                d[i] = graph[idx_goal_node,i];

            while (!U.Contains(idx_goal_node)) 
            {
                min_weight_node_idx = GetMinValueIdx(d);
                U.Add(min_weight_node_idx);

                for (int i = 0; i < n; i++)
                {
                    //Придумать что делать с бесконечностью!
                    if (!U.Contains(i))
                    {
                        if (d[i] > d[min_weight_node_idx] + graph[min_weight_node_idx, i]);
                        {
                            d[i] = d[min_weight_node_idx] + graph[min_weight_node_idx, i];
                            p[i] = i;
                        }
                    }
                }
            }
           
            

            
        }

        private static int GetMinValueIdx(int[] d)
        {
            int min_idx = 0;

            for(int i = 1; i < d.Length;i++)
                if (d[min_idx] > d[i])
                    min_idx = i;

            return min_idx;
        }
    }
}
