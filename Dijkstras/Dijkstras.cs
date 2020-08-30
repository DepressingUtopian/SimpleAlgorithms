using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAlgorithms
{
    public class Dijkstras
    {
        public static (List<int> d, List<int> p) Find(int[,] graph, int idx_start_node, int idx_goal_node)
        {
            int n = graph.GetLength(0);
            List<int> d = new List<int>(n);
            List<int> p = new List<int>(n);
            int min_weight_node_idx = 0;
            List<int> U = new List<int>();
            U.Add(idx_start_node);

            //Заполнение данными весов путей из начальной вершины
            for (int i = 0; i < n; i++)
                d.Add(graph[idx_start_node, i]);

            

            while (!U.Contains(idx_goal_node)) 
            {
                min_weight_node_idx = GetMinValueIdx(d,U);
                U.Add(min_weight_node_idx);

                for (int i = 0; i < n; i++)
                {             
                    if (!U.Contains(i))
                    {
                        //Сравнение пути через опорную вершину и текушего веса
                        bool logic1 = ((d[i] > d[min_weight_node_idx] + graph[min_weight_node_idx, i])
                            && d[min_weight_node_idx] != 0 && graph[min_weight_node_idx, i] != 0);
                        //Проверка на то что новый путь существует (!= 0), а старый не существует (== 0)
                        bool logic2 = (d[i] == 0 && d[min_weight_node_idx] != 0 && graph[min_weight_node_idx, i] != 0);

                        if (logic1 || logic2)
                        {
                            d[i] = d[min_weight_node_idx] + graph[min_weight_node_idx, i];

                            if(!p.Contains(min_weight_node_idx))
                                        p.Add(min_weight_node_idx);

                        }
                    }

                }
            }
            return (d,p);   
        }

        
        private static int GetMinValueIdx(List<int> d, List<int> U)
        {      
            return Enumerable.Range(0, d.Count)
                .Where(x => (!U.Contains(x) && d[x] != 0))
                .Aggregate((x, y) => ((d[x] > d[y]) ? y : x));
        }
    }
}
