using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    
    public class KnapsackProblem
    {

        /// <summary>
        ///Задача о рюкзаке 0-1
        /// </summary>
        /// <param name="objects">Представляет собой структуру вида {вес, стоймость}</param>
        /// <param name="capacity">Требуемая вместимость</param>
        /// <returns></returns>
        public static int Solve(Dictionary<int,int> objects, int capacity)
        {
            int size = objects.Count;
            int[,] matrix = new int[size, capacity];

            int i = 0;
            foreach (var elem in objects.Keys)
            {
                for (int j = 0; j < capacity; j++)
                {
                    if (j >= elem)
                    {
                        int valueCost = objects[elem] * (int)(j / elem);
                        int valueWeight = elem * (int)(j / elem);
                        if (i == 0)
                            matrix[i, j] = valueCost;
                        else
                            matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i - 1, j - valueWeight] + valueCost);

                    }
                    else
                        matrix[i, j] = 0;
                }
                i++;
            }
            return matrix[size - 1, capacity - 1];
        }
    }
}
