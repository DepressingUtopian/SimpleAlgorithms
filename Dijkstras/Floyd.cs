using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GraphAlgorithms
{
    public class Floyd
    {
        public static (int weight, List<int> path) Find(int[,] graph, int idx_start_node, int idx_goal_node)
        {
            int[,] resultMatrix = graph;
            List<int> path = new List<int>();

            path.Add(idx_start_node);

            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                    for (int k = 0; k < graph.GetLength(1); k++)
                        if (resultMatrix[i, j] != 0 && resultMatrix[k, i] != 0)
                        {
                            //Пропускаем петли
                            if (j == k)
                                continue;

                            int minValue = 0;
                            if (resultMatrix[j, k] == 0)
                                minValue = resultMatrix[i, j] + resultMatrix[k, i];
                            else
                                minValue = Math.Min(resultMatrix[j, k], resultMatrix[i, j] + resultMatrix[k, i]);

                            if (resultMatrix[j, k] != minValue && j == idx_start_node && k == idx_goal_node)
                                path.Add(i);
                            resultMatrix[j, k] = minValue;
                        }
            path.Add(idx_goal_node);

            return (resultMatrix[idx_start_node, idx_goal_node], path);
        }        
    }
}
