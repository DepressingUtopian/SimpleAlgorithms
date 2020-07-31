using System;
using System.Collections.Generic;

namespace DataSet
{
    public class DataSet
    {
        private static Random randomGen = new Random();
        public static int[,] GenMatrixGraph(int numberOfVertices, int numberОfRibs,
            bool negativePath = false, bool oriented = false, bool cycles = false, int minWeight = 0, int maxWeight = 10)
        {
            int[,] graph = new int[numberOfVertices, numberOfVertices];
            int newWeight = 0;
            int countFilledRibs = 0;
            int numCycles = (!cycles) ? numberOfVertices : 0;

            if (oriented)
            {
                if (numberОfRibs > numberOfVertices * numberOfVertices - numCycles)
                    throw new Exception("Число ребер должно быть меньше чем число вершин в квадрате!");
            }
            else
            {
                if (numberОfRibs > (numberOfVertices * numberOfVertices - numCycles) / 2)
                    throw new Exception("Число ребер должно быть меньше! " + " " + "  ");
            }


            while(countFilledRibs < numberОfRibs)
                for (int i = 0; i < numberOfVertices; i++)
                    for (int j = 0; j < numberOfVertices; j++)
                    {
                        if (countFilledRibs >= numberОfRibs)
                            return graph;
                        newWeight = (!negativePath) ? randomGen.Next(minWeight, maxWeight) : randomGen.Next(0, maxWeight);

                        if (i == j && !cycles)
                            continue;
                            
                        if (newWeight != 0)
                        {
                            if (!oriented)
                            {
                                if (graph[i, j] == 0 && graph[j, i] == 0)
                                {
                                    countFilledRibs++;
                                    graph[i, j] = newWeight;
                                    graph[j, i] = newWeight;
                                }
                            }
                            else
                            {
                                countFilledRibs++;
                                graph[i, j] = newWeight;
                            }
                        }
                    }
            return graph;
        }

        private static int Factorial(int n)
        {
            int value = 1;
            for (int i = 1; i <= n; i++)
                value *= i;
            return value;
        }

        public static void RandomizeList(ref List<int> list, int N, bool isSort = false)
        {
            if (N <= 0)
                throw new Exception("Задан не верный размер массива!");

            Random random = new Random();
            //Инициализация списка
            list = new List<int>();

            //Заполнение списка
            for (int i = 0; i < N; i++)
                list.Add(random.Next(0, Int32.MaxValue));
            //Сортировка списка
            if (isSort)
                list.Sort();

        }
        public static void RandomizeArray(ref int[] array, int N, bool isSort = false)
        {
            if (N <= 0)
                throw new Exception("Задан не верный размер массива!");

            Random random = new Random();
            //Инициализация массива
            array = new int[random.Next(0, N)];

            //Заполнение массива
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, Int32.MaxValue);
            //Сортировка массива
            if (isSort)
                Array.Sort<int>(array);

        }
    }
}

