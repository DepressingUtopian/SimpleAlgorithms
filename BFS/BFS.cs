using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAlgorithms
{
    public class BFS
    {
        public static bool Find(int [,] graph, int idx_start_node, int idx_goal_node)
        {
            Queue<int> search_queue = new Queue<int>();
            Queue<int> searched = new Queue<int>();
     
            AddConnectedVertices(graph, idx_start_node,ref search_queue);

            while (search_queue.Count > 0)
            {
                int nodeNumber = search_queue.Dequeue();
                if (!searched.Contains(nodeNumber))
                {
                    if (nodeNumber == idx_goal_node)
                        return true;
                    else
                    {
                        AddConnectedVertices(graph, nodeNumber, ref search_queue);
                        searched.Enqueue(nodeNumber);
                    }
                }
            }
            return false;
        }
        
        private static void AddConnectedVertices(int[,] graph, int idx_node, ref Queue<int> queue)
        {
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                if (i == idx_node)
                    continue;
                if (graph[idx_node, i] != 0)
                    queue.Enqueue(i);
            }
        }
    }
}
