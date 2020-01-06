using System;
using System.Collections.Generic;

namespace SimpleAlgorithms
{
    public class BinarySearch
    {
        public static uint Find(int item,int[] array)
        {
            uint min = 0;
            uint max =  (uint)array.Length - 1;
            uint mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (item == array[mid])
                    return mid;
                else if (item > array[mid])
                {
                    min = mid + 1;
                }
                else if (item < array[mid])
                {
                    max = mid - 1;
                }
            }
            throw new Exception("Элемент не найдет!");

        }
        public static void RandomizeArray(ref int[] array,int N,bool isSort = false)
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
            if(isSort)
                Array.Sort<int>(array);

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
    }
}
